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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OsuDesktop
{
    public partial class WinForm : Form
    {
        protected int RandomNumber { get; set; }
        protected string JsonText { get; set; }

        protected string ApiCode;
        public WinForm()
        {
            InitializeComponent();
            GetApiCode();
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
            //Beatmap BeatmapOsu;
            using (WebClient wc = new WebClient())
            {
                JsonText = wc.DownloadString("https://osu.ppy.sh/api/get_beatmaps?k="+ApiCode +"&s="+RandomNumber.ToString());

                JsonText = JsonText.Trim('[');
                JsonText = JsonText.Trim(']');

                Console.WriteLine(JsonText);

                //BeatmapOsu = JsonConvert.DeserializeObject<Beatmap>(JsonText);

                //if (JsonText!="")
                //    SongNameText.Text = BeatmapOsu.beatmap_id;
                
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
    }
}