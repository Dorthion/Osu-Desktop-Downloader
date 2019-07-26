using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Globalization;
using System.Windows.Forms;
using System.Resources;
using System.Reflection;

namespace OsuDesktop
{
    public partial class WinForm : Form
    {
        protected int RandomNumber { get; set; }
        protected string ApiCode;                                               //Put "your" api code here
        protected int SelectedBeatmap = 0;

        private List<Beatmap> JsonText { get; set; }

        internal static string cul = Properties.Settings.Default.Language;
        internal ResourceManager rm = new ResourceManager("OsuDesktop.Resources." + cul, Assembly.GetExecutingAssembly());
        WMPLib.WindowsMediaPlayer PreviewSong;
        public WinForm()
        {
            GetApiCode();
            InitializeComponent();
        }

        private void GetApiCode()
        {
            using (StreamReader sr = new StreamReader("..\\..\\ApiCode.ddd"))   //Or get from safety place (.gitignore)
            {
                ApiCode = sr.ReadLine();
            }
        }

        private int Rng()
        {
            int Number;
            Random rng = new Random();
            Number = rng.Next(1, 1000000);
            return Number;
        }

        private void DownloadBtn_Click(object sender, EventArgs e)
        {
            Process.Start("osu://dl/" + RandomNumber);
        }

        private void RandomButtom_Click(object sender, EventArgs e)
        {
            SongImg.Image = null;
            SelectedBeatmap = 0;
            RandomNumber = Rng();
            DownloadJson();
            ChangeImg();
        }

        private void DownloadJson()
        {
            string FullJsonText;
            using (WebClient wc = new WebClient())
            {
                FullJsonText = wc.DownloadString("https://osu.ppy.sh/api/get_beatmaps?k=" + ApiCode + "&s=" + RandomNumber.ToString());
                while (FullJsonText == "[]")
                {
                    RandomNumber = Rng();
                    FullJsonText = wc.DownloadString("https://osu.ppy.sh/api/get_beatmaps?k=" + ApiCode + "&s=" + RandomNumber.ToString());
                }

                JsonText = JsonConvert.DeserializeObject<List<Beatmap>>(FullJsonText);
                ChangeMainText();
            }
        }

        private void ChangeMainText()
        {
            #region Main_Panel
            TitleText.Text = rm.GetString("Title") + " " + JsonText.ElementAt(SelectedBeatmap).title;
            ArtistText.Text = rm.GetString("Artist") + " " + JsonText.ElementAt(SelectedBeatmap).artist;
            CreatorText.Text = rm.GetString("Creator") + " " + JsonText.ElementAt(SelectedBeatmap).creator;
            DiffNameText.Text = rm.GetString("Difficulty") + " " + JsonText.ElementAt(SelectedBeatmap).version;
            PassTriedText.Text = rm.GetString("PassTried") + " " + JsonText.ElementAt(SelectedBeatmap).passcount
                + "/" + JsonText.ElementAt(SelectedBeatmap).playcount;
            DrainLengthText.Text = rm.GetString("DrainLength") + " " + JsonText.ElementAt(SelectedBeatmap).hit_length
                + "/" + JsonText.ElementAt(SelectedBeatmap).total_length + " " + rm.GetString("Seconds");
            BPMText.Text = rm.GetString("BPM") + " " + JsonText.ElementAt(SelectedBeatmap).bpm;
            StarsText.Text = rm.GetString("Stars") + " " + String.Format("{0:#.##}", JsonText.ElementAt(SelectedBeatmap).difficultyrating);
            SubmitDateText.Text = rm.GetString("SubmitDate") + " " + JsonText.ElementAt(SelectedBeatmap).submit_date;
            #endregion

            ListCountText.Text = string.Format("{0}", SelectedBeatmap + 1) + "/" + JsonText.Count;
            RngNumText.Text = RandomNumber.ToString();
        }

        private void ChangeImg()
        {
            string TempPath = Path.GetTempPath() + "OsuDesktopTmp\\";

            bool exists = Directory.Exists(TempPath);

            if (!exists)
                Directory.CreateDirectory(TempPath);

            string result = Path.GetTempPath() + "OsuDesktopTmp\\" + RandomNumber + ".jpg";
            string BeatmapImg = "https://assets.ppy.sh/beatmaps/" + RandomNumber + "/covers/cover.jpg";

            using (WebClient wc = new WebClient())
            {
                try
                {
                    wc.DownloadFile(new Uri(BeatmapImg), result);
                }
                catch (WebException)
                {
                    SongImg.Image = SongImg.ErrorImage;
                }
                finally
                {
                    if (SongImg.Image != SongImg.ErrorImage)
                        SongImg.Image = Bitmap.FromFile(result);
                }
            }
        }

        private void BtnRigthList_Click(object sender, EventArgs e)
        {
            if (JsonText != null && SelectedBeatmap + 1 < JsonText.Count)
            {
                SelectedBeatmap++;
                ChangeMainText();
            }
        }

        private void BtnLeftList_Click(object sender, EventArgs e)
        {
            if (JsonText != null && SelectedBeatmap > 0)
            {
                SelectedBeatmap--;
                ChangeMainText();
            }
        }

        private void SongImg_Click(object sender, EventArgs e)
        {
            if(PreviewSong != null)
            {
                this.PreviewSong.controls.stop();
                PreviewSong = null;
            }  

            PreviewSong = new WMPLib.WindowsMediaPlayer();
            PreviewSong.PlayStateChange += new WMPLib._WMPOCXEvents_PlayStateChangeEventHandler(Player_PlayStateChange);
            PreviewSong.MediaError += new WMPLib._WMPOCXEvents_MediaErrorEventHandler(Player_MediaError);
            PreviewSong.URL = "https://b.ppy.sh/preview/" + RandomNumber + ".mp3";
            PreviewSong.controls.play();
        }

        private void Player_PlayStateChange(int NewState)
        {
            if ((WMPLib.WMPPlayState)NewState == WMPLib.WMPPlayState.wmppsStopped)
            {
                PreviewSong = null;
                System.GC.Collect();
            }
        }

        private void Player_MediaError(object pMediaObject)
        {
            MessageBox.Show("Cant play preview song. \nOOF.");
        }

        private void BeatmapText_Click(object sender, EventArgs e)
        {
            WinSettings Settings = new WinSettings();
            Settings.Show();
        }
    }
}
