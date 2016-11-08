namespace PortableHotspotWindows
{
    partial class MainForm
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
            this.StartNetworkButton = new System.Windows.Forms.Button();
            this.MainMenuStripMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setNetworkButton = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SSIDLabel = new System.Windows.Forms.Label();
            this.KeyLabel = new System.Windows.Forms.Label();
            this.SSIDTextBox = new System.Windows.Forms.TextBox();
            this.KeyTextBox = new System.Windows.Forms.TextBox();
            this.MainStatusStripMenu = new System.Windows.Forms.StatusStrip();
            this.StatusConnectionLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.InformationTextBox = new System.Windows.Forms.RichTextBox();
            this.NetworkListComboBox = new System.Windows.Forms.ComboBox();
            this.ShareInternetButton = new System.Windows.Forms.Button();
            this.StopNetworkButton = new System.Windows.Forms.Button();
            this.MainMenuStripMenu.SuspendLayout();
            this.MainStatusStripMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartNetworkButton
            // 
            this.StartNetworkButton.Location = new System.Drawing.Point(51, 118);
            this.StartNetworkButton.Name = "StartNetworkButton";
            this.StartNetworkButton.Size = new System.Drawing.Size(90, 30);
            this.StartNetworkButton.TabIndex = 0;
            this.StartNetworkButton.Text = "Start";
            this.StartNetworkButton.UseVisualStyleBackColor = true;
            this.StartNetworkButton.Click += new System.EventHandler(this.StartNetworkButton_Click);
            // 
            // MainMenuStripMenu
            // 
            this.MainMenuStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.MainMenuStripMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenuStripMenu.Name = "MainMenuStripMenu";
            this.MainMenuStripMenu.Size = new System.Drawing.Size(302, 24);
            this.MainMenuStripMenu.TabIndex = 1;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setNetworkButton});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // setNetworkButton
            // 
            this.setNetworkButton.Name = "setNetworkButton";
            this.setNetworkButton.Size = new System.Drawing.Size(152, 22);
            this.setNetworkButton.Text = "Set Network";
            this.setNetworkButton.Click += new System.EventHandler(this.setNetworkButton_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // SSIDLabel
            // 
            this.SSIDLabel.AutoSize = true;
            this.SSIDLabel.Location = new System.Drawing.Point(27, 41);
            this.SSIDLabel.Name = "SSIDLabel";
            this.SSIDLabel.Size = new System.Drawing.Size(45, 18);
            this.SSIDLabel.TabIndex = 2;
            this.SSIDLabel.Text = "SSID";
            // 
            // KeyLabel
            // 
            this.KeyLabel.AutoSize = true;
            this.KeyLabel.Location = new System.Drawing.Point(27, 80);
            this.KeyLabel.Name = "KeyLabel";
            this.KeyLabel.Size = new System.Drawing.Size(35, 18);
            this.KeyLabel.TabIndex = 3;
            this.KeyLabel.Text = "Key";
            // 
            // SSIDTextBox
            // 
            this.SSIDTextBox.Location = new System.Drawing.Point(101, 38);
            this.SSIDTextBox.Name = "SSIDTextBox";
            this.SSIDTextBox.Size = new System.Drawing.Size(176, 26);
            this.SSIDTextBox.TabIndex = 4;
            // 
            // KeyTextBox
            // 
            this.KeyTextBox.Location = new System.Drawing.Point(101, 77);
            this.KeyTextBox.Name = "KeyTextBox";
            this.KeyTextBox.Size = new System.Drawing.Size(176, 26);
            this.KeyTextBox.TabIndex = 5;
            // 
            // MainStatusStripMenu
            // 
            this.MainStatusStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusConnectionLabel});
            this.MainStatusStripMenu.Location = new System.Drawing.Point(0, 339);
            this.MainStatusStripMenu.Name = "MainStatusStripMenu";
            this.MainStatusStripMenu.Size = new System.Drawing.Size(302, 22);
            this.MainStatusStripMenu.TabIndex = 6;
            this.MainStatusStripMenu.Text = "statusStrip1";
            // 
            // StatusConnectionLabel
            // 
            this.StatusConnectionLabel.Name = "StatusConnectionLabel";
            this.StatusConnectionLabel.Size = new System.Drawing.Size(67, 17);
            this.StatusConnectionLabel.Text = "Not Started";
            // 
            // InformationTextBox
            // 
            this.InformationTextBox.Location = new System.Drawing.Point(20, 222);
            this.InformationTextBox.Name = "InformationTextBox";
            this.InformationTextBox.ReadOnly = true;
            this.InformationTextBox.Size = new System.Drawing.Size(257, 96);
            this.InformationTextBox.TabIndex = 7;
            this.InformationTextBox.Text = "";
            // 
            // NetworkListComboBox
            // 
            this.NetworkListComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.NetworkListComboBox.FormattingEnabled = true;
            this.NetworkListComboBox.Location = new System.Drawing.Point(20, 154);
            this.NetworkListComboBox.Name = "NetworkListComboBox";
            this.NetworkListComboBox.Size = new System.Drawing.Size(257, 26);
            this.NetworkListComboBox.TabIndex = 8;
            // 
            // ShareInternetButton
            // 
            this.ShareInternetButton.Location = new System.Drawing.Point(20, 186);
            this.ShareInternetButton.Name = "ShareInternetButton";
            this.ShareInternetButton.Size = new System.Drawing.Size(257, 30);
            this.ShareInternetButton.TabIndex = 9;
            this.ShareInternetButton.Text = "Share Internet ";
            this.ShareInternetButton.UseVisualStyleBackColor = true;
            this.ShareInternetButton.Click += new System.EventHandler(this.ShareInternetButton_Click);
            // 
            // StopNetworkButton
            // 
            this.StopNetworkButton.Location = new System.Drawing.Point(165, 118);
            this.StopNetworkButton.Name = "StopNetworkButton";
            this.StopNetworkButton.Size = new System.Drawing.Size(100, 30);
            this.StopNetworkButton.TabIndex = 10;
            this.StopNetworkButton.Text = "Stop";
            this.StopNetworkButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 361);
            this.Controls.Add(this.StopNetworkButton);
            this.Controls.Add(this.ShareInternetButton);
            this.Controls.Add(this.NetworkListComboBox);
            this.Controls.Add(this.InformationTextBox);
            this.Controls.Add(this.MainStatusStripMenu);
            this.Controls.Add(this.KeyTextBox);
            this.Controls.Add(this.SSIDTextBox);
            this.Controls.Add(this.KeyLabel);
            this.Controls.Add(this.SSIDLabel);
            this.Controls.Add(this.StartNetworkButton);
            this.Controls.Add(this.MainMenuStripMenu);
            this.Font = new System.Drawing.Font("Arial", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Portable Hotspot Windows";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainMenuStripMenu.ResumeLayout(false);
            this.MainMenuStripMenu.PerformLayout();
            this.MainStatusStripMenu.ResumeLayout(false);
            this.MainStatusStripMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartNetworkButton;
        private System.Windows.Forms.MenuStrip MainMenuStripMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setNetworkButton;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label SSIDLabel;
        private System.Windows.Forms.Label KeyLabel;
        private System.Windows.Forms.TextBox SSIDTextBox;
        private System.Windows.Forms.TextBox KeyTextBox;
        private System.Windows.Forms.StatusStrip MainStatusStripMenu;
        private System.Windows.Forms.ToolStripStatusLabel StatusConnectionLabel;
        private System.Windows.Forms.RichTextBox InformationTextBox;
        private System.Windows.Forms.ComboBox NetworkListComboBox;
        private System.Windows.Forms.Button ShareInternetButton;
        private System.Windows.Forms.Button StopNetworkButton;
    }
}

