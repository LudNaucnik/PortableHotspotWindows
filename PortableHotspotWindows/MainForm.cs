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
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            NetworkInfo = Hotspot.GetNetworkInfo();
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

        private void setNetworkButton_Click(object sender, EventArgs e)
        {
            SetNetworkForm Form = new SetNetworkForm();
            Form.ShowDialog();
            NetworkInfo = Hotspot.GetNetworkInfo();
        }
    }
}
