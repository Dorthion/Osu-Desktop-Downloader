using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private string ApiCode ="";
        public WinForm()
        {
            InitializeComponent();
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
            string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            using (WebClient wc = new WebClient())
            {
                //wc.DownloadProgressChanged += wc_DownloadProgressChanged;
                /*wc.DownloadFile(
                    //new Uri("http://osu.ppy.sh/d/923703"),
                    new Uri("https://osu.ppy.sh/s/923703"),

                    "C:\\Users\\Dorthion\\Desktop\\oof.osz"
                );*/
                //Actually Do Nothing
            }
        }

        private bool CheckBeatmap()
        {
            return true;
        }

        private void RandomButton_Click(object sender, EventArgs e)
        {
            SongImg.Image = null;
            RandomNumber = Rng();
            DownloadJson();
            ChangeImg();
            RngNumText.Text = "Wylosowana liczba: " + RandomNumber;
        }

        private void DownloadJson()
        {
            using (WebClient wc = new WebClient())
            {
                JsonText = wc.DownloadString("https://osu.ppy.sh/api/get_beatmaps?k="+ApiCode +"&s="+RandomNumber.ToString());
                Console.WriteLine(JsonText);
            }
        }

        private bool JsonExists()
        {

            return true;
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
