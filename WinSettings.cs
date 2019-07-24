using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        }

        private void RadioBtnClassic_CheckedChanged(object sender, EventArgs e)
        {
            RadioBtnModern.Checked = false;
        }

        private void RadioBtnModern_CheckedChanged(object sender, EventArgs e)
        {
            RadioBtnModern.Checked = true;
        }

        private void SaveSettings()
        {
            if (RadioBtnClassic.Checked)
                Properties.Settings.Default.Style = true;
            else Properties.Settings.Default.Style = false;
            Properties.Settings.Default.Language = LanguageList.SelectedItem.ToString();
            Properties.Settings.Default.Save();
        }
    }
}
