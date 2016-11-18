using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SerialOperations;

namespace PortableHotspotWindows
{
    public partial class RegisterForm : Form
    {
        Operations opr = new Operations();
        SerialKeyIOClass IOKey = new SerialKeyIOClass();
        public Boolean ValidationKey { get; set; }
        public RegisterForm()
        {
            InitializeComponent();
            ValidationKey = false;
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            if (RegisterTextBox.Text == null)
            {
                MessageBox.Show("Provide Serial Key", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ValidationKey = false;
                RegisterTextBox.Focus();
            }
            else if (opr.VerifyCode(RegisterTextBox.Text) == false)
            {
                MessageBox.Show("Invalid Serial Key", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ValidationKey = false;
                RegisterTextBox.Text = null;
                RegisterTextBox.Focus();
            }
            else
            {
                MessageBox.Show("Valid Serial Key", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ValidationKey = true;
                IOKey.WriteLicence(RegisterTextBox.Text);
                LoggerClass.WriteLog("Inserted Valid Serial Key EncyptedKey=" + System.IO.File.ReadAllText(SerialKeyIOClass.LicencePath));
                this.Close();
            }
        }
    }
}
