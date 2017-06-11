using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace PortableHotspotWindows
{
    public partial class SettingsForm : Form
    {
        String SettingsPath = Application.StartupPath + @"\settings.conf";
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Settings NewSettings = new Settings();
            NewSettings.CheckValidSettings = @"OK";
            NewSettings.EnableLogging = EnableLoggingCheckBox.Checked;
            NewSettings.StartHotspotAutomatically = StartHotspotAutomaticallyCheckBox.Checked;
            File.Delete(SettingsPath);
            String jsonSettings = JsonConvert.SerializeObject(NewSettings);
            File.WriteAllText(SettingsPath, jsonSettings);
            MainForm.ReadSettings();
            UpdateSettings();
            MessageBox.Show("Settings Saved", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoggerClass.WriteLogInformation("Settings Saved");
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            UpdateSettings();
        }

        public void UpdateSettings()
        {
            EnableLoggingCheckBox.Checked = MainForm.ApplicationSettings.EnableLogging;
            StartHotspotAutomaticallyCheckBox.Checked = MainForm.ApplicationSettings.StartHotspotAutomatically;

        }
    }
}
