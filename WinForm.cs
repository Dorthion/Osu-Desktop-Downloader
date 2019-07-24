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
        protected string ApiCode;

        private List<Beatmap> JsonText { get; set; }

        internal static string cul = Properties.Settings.Default.Language;
        internal ResourceManager rm = new ResourceManager("OsuDesktop.Resources." + cul, Assembly.GetExecutingAssembly());

        public WinForm()
        {
            GetApiCode();
            InitializeComponent();
        }

        private void GetApiCode()
        {
            using (StreamReader sr = new StreamReader("..\\..\\ApiCode.ddd"))
            {
                ApiCode = sr.ReadLine();
            }
        }
        
        private int Rng()
        {
            int Number;
            Random rng = new Random();
            Number = rng.Next(1, 100000);
            return Number;
        }

        private void LoadLanguage()
        {
            switch (Properties.Settings.Default.Language)
            {
                case "English":
                   // rm = Resources.en;
                    break;
            }
        }

        private void DownloadBtn_Click(object sender, EventArgs e)
        {
            Process.Start("osu://dl/" + RandomNumber);
        }

        private void RandomButton_Click(object sender, EventArgs e)
        {
            SongImg.Image = null;
            RandomNumber = Rng();
            DownloadJson();
            ChangeImg();
            RngNumText.Text = RandomNumber.ToString();
        }

        private void DownloadJson()
        {
            string FullJsonText;
            using (WebClient wc = new WebClient())
            {
                FullJsonText = wc.DownloadString("https://osu.ppy.sh/api/get_beatmaps?k="+ApiCode +"&s="+RandomNumber.ToString());

                if (FullJsonText != "[]")
                {
                    JsonText = JsonConvert.DeserializeObject<List<Beatmap>>(FullJsonText);
                    Console.WriteLine(JsonText.ElementAt(0).title);
                    SongNameText.Text = rm.GetString("BeatmapName") + " " + JsonText.ElementAt(0).title;
                }
            }
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
                try{
                    wc.DownloadFile(new Uri(BeatmapImg), result);
                }
                catch(WebException)
                {
                    SongImg.Image = SongImg.ErrorImage;
                }
                finally{
                    if(SongImg.Image!=SongImg.ErrorImage)
                        SongImg.Image = Bitmap.FromFile(result);
                }
            }
        }

        private void BeatmapText_Click(object sender, EventArgs e)
        {
            WinSettings Settings = new WinSettings();
            Settings.Show();
        }
    }
}