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
            this.ShowPassButton = new System.Windows.Forms.Button();
            this.StartStopButton = new System.Windows.Forms.Button();
            this.MainMenuStripMenu.SuspendLayout();
            this.MainStatusStripMenu.SuspendLayout();
            this.SuspendLayout();
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
            this.setNetworkButton.Size = new System.Drawing.Size(138, 22);
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
            this.SSIDTextBox.ReadOnly = true;
            this.SSIDTextBox.Size = new System.Drawing.Size(176, 26);
            this.SSIDTextBox.TabIndex = 4;
            // 
            // KeyTextBox
            // 
            this.KeyTextBox.Location = new System.Drawing.Point(101, 77);
            this.KeyTextBox.Name = "KeyTextBox";
            this.KeyTextBox.PasswordChar = '●';
            this.KeyTextBox.ReadOnly = true;
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
            // ShowPassButton
            // 
            this.ShowPassButton.BackgroundImage = global::PortableHotspotWindows.Properties.Resources.showPass;
            this.ShowPassButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ShowPassButton.Location = new System.Drawing.Point(247, 77);
            this.ShowPassButton.Name = "ShowPassButton";
            this.ShowPassButton.Size = new System.Drawing.Size(30, 25);
            this.ShowPassButton.TabIndex = 20;
            this.ShowPassButton.UseVisualStyleBackColor = true;
            this.ShowPassButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ShowPassButton_MouseDown);
            this.ShowPassButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ShowPassButton_MouseUp);
            // 
            // StartStopButton
            // 
            this.StartStopButton.Location = new System.Drawing.Point(74, 129);
            this.StartStopButton.Name = "StartStopButton";
            this.StartStopButton.Size = new System.Drawing.Size(161, 40);
            this.StartStopButton.TabIndex = 21;
            this.StartStopButton.Text = "Start Hotspot";
            this.StartStopButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 361);
            this.Controls.Add(this.StartStopButton);
            this.Controls.Add(this.ShowPassButton);
            this.Controls.Add(this.InformationTextBox);
            this.Controls.Add(this.MainStatusStripMenu);
            this.Controls.Add(this.KeyTextBox);
            this.Controls.Add(this.SSIDTextBox);
            this.Controls.Add(this.KeyLabel);
            this.Controls.Add(this.SSIDLabel);
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
        private System.Windows.Forms.Button ShowPassButton;
        private System.Windows.Forms.Button StartStopButton;
    }
}

