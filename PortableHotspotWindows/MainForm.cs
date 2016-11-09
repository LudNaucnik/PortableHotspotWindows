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
        }

        private void setNetworkButton_Click(object sender, EventArgs e)
        {
            SetNetworkForm Form = new SetNetworkForm();
            Form.ShowDialog();
            NetworkInfo = Hotspot.GetNetworkInfo();
        }

        private void ShowPassButton_MouseDown(object sender, MouseEventArgs e)
        {
            KeyTextBox.PasswordChar = '\0';
        }

        private void ShowPassButton_MouseUp(object sender, MouseEventArgs e)
        {
            KeyTextBox.PasswordChar = '●';
        }
    }
}
