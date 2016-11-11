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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainMenuStripMenu = new System.Windows.Forms.MenuStrip();
            this.SetNetworkButton = new System.Windows.Forms.ToolStripMenuItem();
            this.RegisterButton = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutButton = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitButton = new System.Windows.Forms.ToolStripMenuItem();
            this.SSIDLabel = new System.Windows.Forms.Label();
            this.KeyLabel = new System.Windows.Forms.Label();
            this.SSIDTextBox = new System.Windows.Forms.TextBox();
            this.KeyTextBox = new System.Windows.Forms.TextBox();
            this.MainStatusStripMenu = new System.Windows.Forms.StatusStrip();
            this.StatusConnectionLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.InformationTextBox = new System.Windows.Forms.RichTextBox();
            this.StartStopButton = new System.Windows.Forms.Button();
            this.ConnectedClientsListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NumClientsLabel = new System.Windows.Forms.Label();
            this.ConnectedUsersTimer = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.ShowPassButton = new System.Windows.Forms.Button();
            this.MainMenuStripMenu.SuspendLayout();
            this.MainStatusStripMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenuStripMenu
            // 
            this.MainMenuStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SetNetworkButton,
            this.RegisterButton,
            this.AboutButton,
            this.ExitButton});
            this.MainMenuStripMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenuStripMenu.Name = "MainMenuStripMenu";
            this.MainMenuStripMenu.Size = new System.Drawing.Size(563, 24);
            this.MainMenuStripMenu.TabIndex = 1;
            // 
            // SetNetworkButton
            // 
            this.SetNetworkButton.Name = "SetNetworkButton";
            this.SetNetworkButton.Size = new System.Drawing.Size(83, 20);
            this.SetNetworkButton.Text = "Set Network";
            this.SetNetworkButton.Click += new System.EventHandler(this.setNetworkButton_Click);
            // 
            // RegisterButton
            // 
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(61, 20);
            this.RegisterButton.Text = "Register";
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // AboutButton
            // 
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(52, 20);
            this.AboutButton.Text = "About";
            // 
            // ExitButton
            // 
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(37, 20);
            this.ExitButton.Text = "Exit";
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
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
            this.MainStatusStripMenu.Size = new System.Drawing.Size(563, 22);
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
            this.InformationTextBox.Size = new System.Drawing.Size(513, 96);
            this.InformationTextBox.TabIndex = 7;
            this.InformationTextBox.Text = "";
            // 
            // StartStopButton
            // 
            this.StartStopButton.Location = new System.Drawing.Point(72, 129);
            this.StartStopButton.Name = "StartStopButton";
            this.StartStopButton.Size = new System.Drawing.Size(180, 70);
            this.StartStopButton.TabIndex = 21;
            this.StartStopButton.Text = "Start Hotspot";
            this.StartStopButton.UseVisualStyleBackColor = true;
            this.StartStopButton.Click += new System.EventHandler(this.StartStopButton_Click);
            // 
            // ConnectedClientsListBox
            // 
            this.ConnectedClientsListBox.FormattingEnabled = true;
            this.ConnectedClientsListBox.ItemHeight = 18;
            this.ConnectedClientsListBox.Location = new System.Drawing.Point(308, 87);
            this.ConnectedClientsListBox.Name = "ConnectedClientsListBox";
            this.ConnectedClientsListBox.Size = new System.Drawing.Size(225, 112);
            this.ConnectedClientsListBox.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(308, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 18);
            this.label1.TabIndex = 23;
            this.label1.Text = "Number Of Clients:";
            // 
            // NumClientsLabel
            // 
            this.NumClientsLabel.AutoSize = true;
            this.NumClientsLabel.Location = new System.Drawing.Point(453, 50);
            this.NumClientsLabel.Name = "NumClientsLabel";
            this.NumClientsLabel.Size = new System.Drawing.Size(17, 18);
            this.NumClientsLabel.TabIndex = 24;
            this.NumClientsLabel.Text = "0";
            // 
            // ConnectedUsersTimer
            // 
            this.ConnectedUsersTimer.Interval = 1000;
            this.ConnectedUsersTimer.Tick += new System.EventHandler(this.ConnectedUsersTimer_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            this.notifyIcon1.BalloonTipTitle = "Information";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Portable Hotspot Windows";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 361);
            this.Controls.Add(this.NumClientsLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ConnectedClientsListBox);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Portable Hotspot Windows";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.MainMenuStripMenu.ResumeLayout(false);
            this.MainMenuStripMenu.PerformLayout();
            this.MainStatusStripMenu.ResumeLayout(false);
            this.MainStatusStripMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip MainMenuStripMenu;
        private System.Windows.Forms.ToolStripMenuItem SetNetworkButton;
        private System.Windows.Forms.ToolStripMenuItem AboutButton;
        private System.Windows.Forms.ToolStripMenuItem ExitButton;
        private System.Windows.Forms.Label SSIDLabel;
        private System.Windows.Forms.Label KeyLabel;
        private System.Windows.Forms.TextBox SSIDTextBox;
        private System.Windows.Forms.TextBox KeyTextBox;
        private System.Windows.Forms.StatusStrip MainStatusStripMenu;
        private System.Windows.Forms.ToolStripStatusLabel StatusConnectionLabel;
        private System.Windows.Forms.RichTextBox InformationTextBox;
        private System.Windows.Forms.Button ShowPassButton;
        private System.Windows.Forms.Button StartStopButton;
        private System.Windows.Forms.ListBox ConnectedClientsListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label NumClientsLabel;
        private System.Windows.Forms.Timer ConnectedUsersTimer;
        private System.Windows.Forms.ToolStripMenuItem RegisterButton;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

