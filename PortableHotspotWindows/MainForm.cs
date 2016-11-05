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
        HotspotClass Hotspot = new HotspotClass();
        NetworkInfoClass NetworkInfo = new NetworkInfoClass();
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            NetworkInfo = Hotspot.CheckNetwork();
            InformationTextBox.AppendText(NetworkInfo.NetworkStatus + " ");
            InformationTextBox.AppendText(NetworkInfo.SSID + " ");
            InformationTextBox.AppendText(NetworkInfo.NumOfClients + " ");
            InformationTextBox.AppendText(NetworkInfo.Key + " ");
            foreach(String client in NetworkInfo.ConnectedClients)
            {
                InformationTextBox.AppendText(client + " ");
            }
            populateConnections();
        }

        public void populateConnections()
        {
            NetworkListComboBox.Items.Clear();
            Hotspot.GetConnections().ForEach(Connection => { NetworkListComboBox.Items.Add(Connection); });
        }

        private void ShareInternetButton_Click(object sender, EventArgs e)
        {
            Hotspot.ShareInternet("Ethernet", NetworkListComboBox.SelectedItem.ToString(), true);
            InformationTextBox.AppendText(Hotspot.Message);
        }

        private void StartNetworkButton_Click(object sender, EventArgs e)
        {
            Hotspot.Create(SSIDTextBox.Text, KeyTextBox.Text);
            Hotspot.Start();
            populateConnections();
            InformationTextBox.AppendText(Hotspot.Message);
        }
    }
}
