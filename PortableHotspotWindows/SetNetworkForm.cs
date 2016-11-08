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
    public partial class SetNetworkForm : Form
    {
        SerialOperations.Operations SOperations = new SerialOperations.Operations();
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
        }

        public void populateConnections()
        {
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SetButton_Click(object sender, EventArgs e)
        {
            Hotspot.Create(SSIDTextBox.Text, KeyTextBox.Text);
            Hotspot.Start();
            populateConnections();
            InformationTextBox.AppendText(Hotspot.Message);
        }
    }
}
