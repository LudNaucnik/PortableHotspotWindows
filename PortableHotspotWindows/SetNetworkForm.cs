using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PortableHotspotWindows
{
    public partial class SetNetworkForm : Form
    {
        HotspotClass Hotspot = new HotspotClass();
        NetworkInfoClass NetworkInfo = new NetworkInfoClass();
        public SetNetworkForm()
        {
            InitializeComponent();
        }

        private void SetNetworkForm_Load(object sender, EventArgs e)
        {
            NetworkInfo = Hotspot.GetNetworkInfo();
            populateConnections();
            UpdateTextBox();
        }

        public void populateConnections()
        {
            FromNetworkListComboBox.Items.Clear();
            ToNetworkListComboBox.Items.Clear();
            Hotspot.GetConnections().ForEach(Connection => { ToNetworkListComboBox.Items.Add(Connection); });
            Hotspot.GetConnections().ForEach(Connection => { FromNetworkListComboBox.Items.Add(Connection); });
        }

        private void ShareInternetButton_Click(object sender, EventArgs e)
        {
            try
            {
                Hotspot.ShareInternet(FromNetworkListComboBox.SelectedItem.ToString(), ToNetworkListComboBox.SelectedItem.ToString(), true);
                InformationTextBox.AppendText(Hotspot.Message);
                LoggerClass.WriteLog(Hotspot.Message);
                AutoScrollTextArea();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SetButton_Click(object sender, EventArgs e)
        {
            if (SSIDTextBox.Text.Length < 4 || SSIDTextBox.Text.Length > 16)
            {
                MessageBox.Show("SSID must between 4 and 16 characters", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SSIDTextBox.Text = null;
            }
            else if (KeyTextBox.Text.Length < 8 || KeyTextBox.Text.Length > 63)
            {
                MessageBox.Show("Key must between 8 and 63 characters", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                KeyTextBox.Text = null;
            }
            else
            {
                Hotspot.Create(Regex.Replace(SSIDTextBox.Text, @"\s+", ""), KeyTextBox.Text);
                Hotspot.WriteLog = true;
                Hotspot.Start();
                Hotspot.GetNetworkInfo();
                Hotspot.WriteLog = false;
                populateConnections();
                InformationTextBox.AppendText(Hotspot.Message);
                AutoScrollTextArea();
            }
        }

        private void AutoScrollTextArea()
        {
            InformationTextBox.SelectionStart = InformationTextBox.Text.Length;
            InformationTextBox.ScrollToCaret();
        }

        private void UpdateTextBox()
        {
            SSIDTextBox.Text = NetworkInfo.SSID;
            KeyTextBox.Text = NetworkInfo.Key;
        }

        private void FromNetworkListComboBox_Click(object sender, EventArgs e)
        {
            FromNetworkListComboBox.DroppedDown = true;
        }

        private void ToNetworkListComboBox_Click(object sender, EventArgs e)
        {
            ToNetworkListComboBox.DroppedDown = true;
        }

        private void ShowPassButton_MouseDown(object sender, MouseEventArgs e)
        {
            KeyTextBox.PasswordChar = '\0';
        }

        private void ShowPassButton_MouseUp(object sender, MouseEventArgs e)
        {
            KeyTextBox.PasswordChar = '●';
            KeyTextBox.Focus();
        }
    }
}
