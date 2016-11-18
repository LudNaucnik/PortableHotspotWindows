namespace PortableHotspotWindows
{
    partial class SetNetworkForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetNetworkForm));
            this.ShareInternetButton = new System.Windows.Forms.Button();
            this.ToNetworkListComboBox = new System.Windows.Forms.ComboBox();
            this.KeyTextBox = new System.Windows.Forms.TextBox();
            this.SSIDTextBox = new System.Windows.Forms.TextBox();
            this.KeyLabel = new System.Windows.Forms.Label();
            this.SSIDLabel = new System.Windows.Forms.Label();
            this.FromNetworkListComboBox = new System.Windows.Forms.ComboBox();
            this.SetButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ShowPassButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ShareInternetButton
            // 
            this.ShareInternetButton.Location = new System.Drawing.Point(324, 158);
            this.ShareInternetButton.Name = "ShareInternetButton";
            this.ShareInternetButton.Size = new System.Drawing.Size(90, 50);
            this.ShareInternetButton.TabIndex = 5;
            this.ShareInternetButton.Text = "Share Internet ";
            this.ShareInternetButton.UseVisualStyleBackColor = true;
            this.ShareInternetButton.Click += new System.EventHandler(this.ShareInternetButton_Click);
            // 
            // ToNetworkListComboBox
            // 
            this.ToNetworkListComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ToNetworkListComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ToNetworkListComboBox.FormattingEnabled = true;
            this.ToNetworkListComboBox.Location = new System.Drawing.Point(96, 185);
            this.ToNetworkListComboBox.Name = "ToNetworkListComboBox";
            this.ToNetworkListComboBox.Size = new System.Drawing.Size(220, 26);
            this.ToNetworkListComboBox.TabIndex = 4;
            this.ToNetworkListComboBox.Click += new System.EventHandler(this.ToNetworkListComboBox_Click);
            // 
            // KeyTextBox
            // 
            this.KeyTextBox.Location = new System.Drawing.Point(96, 83);
            this.KeyTextBox.Name = "KeyTextBox";
            this.KeyTextBox.PasswordChar = '●';
            this.KeyTextBox.Size = new System.Drawing.Size(220, 26);
            this.KeyTextBox.TabIndex = 1;
            // 
            // SSIDTextBox
            // 
            this.SSIDTextBox.Location = new System.Drawing.Point(96, 51);
            this.SSIDTextBox.Name = "SSIDTextBox";
            this.SSIDTextBox.Size = new System.Drawing.Size(220, 26);
            this.SSIDTextBox.TabIndex = 0;
            // 
            // KeyLabel
            // 
            this.KeyLabel.AutoSize = true;
            this.KeyLabel.Location = new System.Drawing.Point(22, 86);
            this.KeyLabel.Name = "KeyLabel";
            this.KeyLabel.Size = new System.Drawing.Size(35, 18);
            this.KeyLabel.TabIndex = 13;
            this.KeyLabel.Text = "Key";
            // 
            // SSIDLabel
            // 
            this.SSIDLabel.AutoSize = true;
            this.SSIDLabel.Location = new System.Drawing.Point(22, 54);
            this.SSIDLabel.Name = "SSIDLabel";
            this.SSIDLabel.Size = new System.Drawing.Size(45, 18);
            this.SSIDLabel.TabIndex = 12;
            this.SSIDLabel.Text = "SSID";
            // 
            // FromNetworkListComboBox
            // 
            this.FromNetworkListComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.FromNetworkListComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.FromNetworkListComboBox.FormattingEnabled = true;
            this.FromNetworkListComboBox.Location = new System.Drawing.Point(96, 153);
            this.FromNetworkListComboBox.Name = "FromNetworkListComboBox";
            this.FromNetworkListComboBox.Size = new System.Drawing.Size(220, 26);
            this.FromNetworkListComboBox.TabIndex = 3;
            this.FromNetworkListComboBox.Click += new System.EventHandler(this.FromNetworkListComboBox_Click);
            // 
            // SetButton
            // 
            this.SetButton.Location = new System.Drawing.Point(322, 54);
            this.SetButton.Name = "SetButton";
            this.SetButton.Size = new System.Drawing.Size(90, 50);
            this.SetButton.TabIndex = 14;
            this.SetButton.Text = "Set";
            this.SetButton.UseVisualStyleBackColor = true;
            this.SetButton.Click += new System.EventHandler(this.SetButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 18);
            this.label1.TabIndex = 15;
            this.label1.Text = "Share Internet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 18);
            this.label2.TabIndex = 16;
            this.label2.Text = "Network Info";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 18);
            this.label3.TabIndex = 17;
            this.label3.Text = "From";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 18);
            this.label4.TabIndex = 18;
            this.label4.Text = "To";
            // 
            // ShowPassButton
            // 
            this.ShowPassButton.BackgroundImage = global::PortableHotspotWindows.Properties.Resources.showPass;
            this.ShowPassButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ShowPassButton.Location = new System.Drawing.Point(286, 83);
            this.ShowPassButton.Name = "ShowPassButton";
            this.ShowPassButton.Size = new System.Drawing.Size(30, 25);
            this.ShowPassButton.TabIndex = 19;
            this.ShowPassButton.UseVisualStyleBackColor = true;
            this.ShowPassButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ShowPassButton_MouseDown);
            this.ShowPassButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ShowPassButton_MouseUp);
            // 
            // SetNetworkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 253);
            this.Controls.Add(this.ShowPassButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SetButton);
            this.Controls.Add(this.FromNetworkListComboBox);
            this.Controls.Add(this.ShareInternetButton);
            this.Controls.Add(this.ToNetworkListComboBox);
            this.Controls.Add(this.KeyTextBox);
            this.Controls.Add(this.SSIDTextBox);
            this.Controls.Add(this.KeyLabel);
            this.Controls.Add(this.SSIDLabel);
            this.Font = new System.Drawing.Font("Arial", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SetNetworkForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Set Hotspot";
            this.Load += new System.EventHandler(this.SetNetworkForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ShareInternetButton;
        private System.Windows.Forms.ComboBox ToNetworkListComboBox;
        private System.Windows.Forms.TextBox KeyTextBox;
        private System.Windows.Forms.TextBox SSIDTextBox;
        private System.Windows.Forms.Label KeyLabel;
        private System.Windows.Forms.Label SSIDLabel;
        private System.Windows.Forms.ComboBox FromNetworkListComboBox;
        private System.Windows.Forms.Button SetButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ShowPassButton;
    }
}