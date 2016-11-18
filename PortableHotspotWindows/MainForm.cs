using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PortableHotspotWindows
{
    public partial class MainForm : Form
    {
        SerialOperations.Operations opr = new SerialOperations.Operations();
        SerialKeyIOClass IOkey = new SerialKeyIOClass();
        HotspotClass Hotspot = new HotspotClass();
        NetworkInfoClass NetworkInfo = new NetworkInfoClass();
        Boolean IsNetworkStarted;
        public const uint ES_CONTINUOUS = 0x80000000;
        public const uint ES_SYSTEM_REQUIRED = 0x00000001;

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern uint SetThreadExecutionState([In] uint esFlags);
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            UpdateLabelsText();
            ConnectedUsersTimer.Start();
            ContextMenu NotificationMenu = new ContextMenu();
            MenuItem Item1 = new MenuItem
            {
                Index = 0,
                Text = "Show Program"
            };
            Item1.Click += Item1_Click;
            MenuItem Item2 = new MenuItem
            {
                Index = 1,
                Text = "Exit"
            };
            Item2.Click += Item2_Click;
            NotificationMenu.MenuItems.Add(Item1);
            NotificationMenu.MenuItems.Add(Item2);
            notifyIcon1.ContextMenu = NotificationMenu;
            if (IOkey.ReadLicence() == false)
            {
                RegisterButton.PerformClick();
            }
            else
            {
                LoggerClass.WriteLog("Licence Verified" + Environment.NewLine + "Program Started");
                RegisterButton.Visible = false;
            }
            if(NetworkInfo.NetworkStatus == "Started")
            {
                LoggerClass.WriteLog("Hotspot Started");
            }
            else
            {
                LoggerClass.WriteLog("Hotspot Not Started");
            }
        }

        private void Item2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Item1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
            notifyIcon1.Visible = false;
        }

        private void setNetworkButton_Click(object sender, EventArgs e)
        {
            Boolean CheckStartSetNetwork;
            SetNetworkForm Form = new SetNetworkForm();
            if (NetworkInfo.NetworkStatus == "Started")
            {
                CheckStartSetNetwork = true;
            }
            else
            {
                Hotspot.Start();
                CheckStartSetNetwork = false;
            }
            this.Hide();
            Form.ShowDialog();
            if (CheckStartSetNetwork == false)
            {
                Hotspot.Stop();
            }
            this.Show();
            UpdateLabelsText();
            StartStopButton.Focus();
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
                LoggerClass.WriteLog("Hotspot Started");
                ConnectedUsersTimer.Start();
                SetThreadExecutionState(ES_CONTINUOUS | ES_SYSTEM_REQUIRED);
            }
            else
            {
                Hotspot.Stop();
                LoggerClass.WriteLog("Hotspot Stopped");
                ConnectedUsersTimer.Stop();
                SetThreadExecutionState(ES_CONTINUOUS);
            }
            UpdateLabelsText();
            InformationTextBox.AppendText(Hotspot.Message);
            LoggerClass.WriteLog(Hotspot.Message);
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

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are You Sure?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                LoggerClass.WriteLog("Program Exited");
                SetThreadExecutionState(ES_CONTINUOUS);
                Hotspot.Stop();
                Environment.Exit(0);
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            RegisterForm frm = new RegisterForm();
            this.Hide();
            frm.ShowDialog();
            if (frm.ValidationKey == true)
            {
                this.Show();
                StartStopButton.Focus();
                RegisterButton.Visible = false;
            }
            else
            {
                Environment.Exit(0);
            }
        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            AboutForm frm = new AboutForm();
            this.Hide();
            frm.ShowDialog();
            this.Show();
            StartStopButton.Focus();
        }
    }
}
