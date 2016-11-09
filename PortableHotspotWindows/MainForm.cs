using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PortableHotspotWindows
{
    public partial class MainForm : Form
    {
        SerialOperations.Operations SOperations = new SerialOperations.Operations();
        HotspotClass Hotspot = new HotspotClass();
        NetworkInfoClass NetworkInfo = new NetworkInfoClass();
        Boolean IsNetworkStarted;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            UpdateLabelsText();
            ConnectedUsersTimer.Start();
        }

        private void setNetworkButton_Click(object sender, EventArgs e)
        {
            SetNetworkForm Form = new SetNetworkForm();
            this.Hide();
            Form.ShowDialog();
            this.Show();
            UpdateLabelsText();
        }

        private void ShowPassButton_MouseDown(object sender, MouseEventArgs e)
        {
            KeyTextBox.PasswordChar = '\0';
        }

        private void ShowPassButton_MouseUp(object sender, MouseEventArgs e)
        {
            KeyTextBox.PasswordChar = '●';
        }

        private void StartStopButton_Click(object sender, EventArgs e)
        {
            if (IsNetworkStarted == false)
            {
                Hotspot.Start();
                ConnectedUsersTimer.Start();
            }
            else
            {
                Hotspot.Stop();
                ConnectedUsersTimer.Stop();
            }
            UpdateLabelsText();
            InformationTextBox.AppendText(Hotspot.Message);
            AutoScrollTextArea();
        }

        private void UpdateLabelsText()
        {
            NetworkInfo = new NetworkInfoClass();
            NetworkInfo = Hotspot.GetNetworkInfo();
            SSIDTextBox.Text = NetworkInfo.SSID;
            KeyTextBox.Text = NetworkInfo.Key;
            StatusConnectionLabel.Text = NetworkInfo.NetworkStatus;
            if (NetworkInfo.NetworkStatus == "Started")
            {
                StartStopButton.Text = "Stop Hostspot";
                IsNetworkStarted = true;
            }
            else
            {
                StartStopButton.Text = "Start Hotspot";
                IsNetworkStarted = false;
            }
            NumClientsLabel.Text = NetworkInfo.NumOfClients;
            if (NetworkInfo.NumOfClients != "0")
            {
                ConnectedClientsListBox.Items.Clear();
                for (int i = 1; i < NetworkInfo.ConnectedClients.Count; i++)
                {
                    ConnectedClientsListBox.Items.Add(NetworkInfo.ConnectedClients.ElementAt(i));
                }
            }
            else
            {
                ConnectedClientsListBox.Items.Clear();
            }
        }

        private void AutoScrollTextArea()
        {
            InformationTextBox.SelectionStart = InformationTextBox.Text.Length;
            InformationTextBox.ScrollToCaret();
        }

        private void ConnectedUsersTimer_Tick(object sender, EventArgs e)
        {
            UpdateLabelsText();
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                notifyIcon1.Visible = true;
                notifyIcon1.BalloonTipText = NetworkInfo.SSID + " " + NetworkInfo.NetworkStatus;
                notifyIcon1.ShowBalloonTip(3000);
                this.ShowInTaskbar = false;
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
            notifyIcon1.Visible = false;
        }
    }
}
