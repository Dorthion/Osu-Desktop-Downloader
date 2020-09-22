using BeatmapMethods;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Windows.Forms;

namespace OsuDesktop.Views.ModernSubViews
{
    public partial class FormMainWindow : Form
    {
        private string ApiCode { get; set; }
        private int RandomNumber { get; set; }
        private int SelectedBeatmap { get; set; } = 0;
        private List<Beatmap> JsonText { get; set; }
        internal static string cul = Properties.Settings.Default.Language;
        internal ResourceManager rm = new ResourceManager("OsuDesktop.Resources." + cul, Assembly.GetExecutingAssembly());
        //WMPLib.WindowsMediaPlayer PreviewSong;

        public FormMainWindow()
        {
            ApiCode = BM.GetApiCode();
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            using (var pen = new Pen(Color.White, 1))
            {
                e.Graphics.DrawRectangle(pen, 577, 0, 651, 196);
            }

            using (var pen = new Pen(Color.White, 2))
            {
                e.Graphics.DrawRectangle(pen, 577, 231, 421, 250); //Name
                e.Graphics.DrawRectangle(pen, 1128, 231, 100, 250); //Mods
                e.Graphics.DrawRectangle(pen, 1078, 231, 50, 250); //PP
                e.Graphics.DrawRectangle(pen, 998, 231, 80, 250); //Combo
                e.Graphics.DrawLine(pen, 577, 266, 1228, 266);
            }

            using (var pen = new Pen(Color.White, 3))
            {
                e.Graphics.DrawRectangle(pen, 10, 0, 530, 480);
            }
        }

        private void NextBeatmapBtn_Click(object sender, EventArgs e)
        {
            #region Clean_Win
            BeatmapImage.Image = null;
            SelectedBeatmap = 0;
            RandomNumber = BM.Rng();
            #endregion

            #region Download_Information
            string temp = BM.DownloadJson(ApiCode, RandomNumber);
            JsonText = JsonConvert.DeserializeObject<List<Beatmap>>(temp);

            ChangeMainText();
            Refresh();
            #endregion

            #region Download_Image
            if (BM.DownloadImage(RandomNumber))
            {
                BeatmapImage.Image = Bitmap.FromFile(Path.GetTempPath() + "OsuDesktopTmp\\" + RandomNumber + ".jpg");
                BeatmapImage.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else BeatmapImage.Image = BeatmapImage.ErrorImage;
            #endregion
        }

        private void ChangeMainText()
        {
            #region Main_Panel
            TitleText.Text = rm.GetString("Title") + " " + JsonText.ElementAt(SelectedBeatmap).title;
            ArtistText.Text = rm.GetString("Artist") + " " + JsonText.ElementAt(SelectedBeatmap).artist;
            CreatorText.Text = rm.GetString("Creator") + " " + JsonText.ElementAt(SelectedBeatmap).creator;
            DifficultyText.Text = rm.GetString("Difficulty") + " " + JsonText.ElementAt(SelectedBeatmap).version;
            PassTriedText.Text = rm.GetString("PassTried") + " " + JsonText.ElementAt(SelectedBeatmap).passcount
                + "/" + JsonText.ElementAt(SelectedBeatmap).playcount;
            DrainLengthText.Text = rm.GetString("DrainLength") + " " + JsonText.ElementAt(SelectedBeatmap).hit_length
                + "/" + JsonText.ElementAt(SelectedBeatmap).total_length + " " + rm.GetString("Seconds");
            BPMText.Text = rm.GetString("BPM") + " " + JsonText.ElementAt(SelectedBeatmap).bpm;
            StarsText.Text = rm.GetString("Stars") + " " + String.Format("{0:#.##}", JsonText.ElementAt(SelectedBeatmap).difficultyrating);
            SubmitDateText.Text = rm.GetString("SubmitDate") + " " + JsonText.ElementAt(SelectedBeatmap).submit_date;
            #endregion

            //ListCountText.Text = string.Format("{0}", SelectedBeatmap + 1) + "/" + JsonText.Count;
            BeatmapID.Text = RandomNumber.ToString();
        }
    }
}
