using System;
using System.Windows.Forms;

namespace OsuDesktop
{
    public partial class WinSettings : Form
    {
        public WinSettings()
        {
            InitializeComponent();
        }

        private void WinSettings_FormClosed(object sender, FormClosedEventArgs e) => SaveSettings();

        private void SaveBtn_Click(object sender, EventArgs e) => SaveSettings();

        private void WinSettings_Load(object sender, EventArgs e)
        {
            RadioBtnClassic.Checked = Properties.Settings.Default.Style;
            RadioBtnModern.Checked = !Properties.Settings.Default.Style;
            LanguageList.SelectedItem = Properties.Settings.Default.Language;
            CheckRanked.Checked = Properties.Settings.Default.Ranked;
            CheckLove.Checked = Properties.Settings.Default.LoveState;
            CheckQual.Checked = Properties.Settings.Default.Qualified;
            CheckGrave.Checked = Properties.Settings.Default.Graveyard;
            CheckPen.Checked = Properties.Settings.Default.Pending;
        }
        
        private void SaveSettings()
        {
            Properties.Settings.Default.Style = RadioBtnClassic.Checked;
            Properties.Settings.Default.Language = LanguageList.SelectedItem.ToString();
            Properties.Settings.Default.Ranked = CheckRanked.Checked;
            Properties.Settings.Default.LoveState = CheckLove.Checked;
            Properties.Settings.Default.Qualified = CheckQual.Checked;
            Properties.Settings.Default.Graveyard = CheckGrave.Checked;
            Properties.Settings.Default.Pending = CheckPen.Checked;
            Properties.Settings.Default.Save();
        }
    }
}
