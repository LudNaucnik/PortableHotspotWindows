namespace PortableHotspotWindows
{
    partial class SettingsForm
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
            this.EnableLoggingCheckBox = new System.Windows.Forms.CheckBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CancelButtonSettings = new System.Windows.Forms.Button();
            this.StartHotspotAutomaticallyCheckBox = new System.Windows.Forms.CheckBox();
            this.StartMinimizedCheckBox = new System.Windows.Forms.CheckBox();
            this.ShowMessageMinimizedCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // EnableLoggingCheckBox
            // 
            this.EnableLoggingCheckBox.AutoSize = true;
            this.EnableLoggingCheckBox.Location = new System.Drawing.Point(34, 114);
            this.EnableLoggingCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.EnableLoggingCheckBox.Name = "EnableLoggingCheckBox";
            this.EnableLoggingCheckBox.Size = new System.Drawing.Size(131, 22);
            this.EnableLoggingCheckBox.TabIndex = 0;
            this.EnableLoggingCheckBox.Text = "Enable logging";
            this.EnableLoggingCheckBox.UseVisualStyleBackColor = true;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(23, 159);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(4);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(120, 36);
            this.SaveButton.TabIndex = 1;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CancelButtonSettings
            // 
            this.CancelButtonSettings.Location = new System.Drawing.Point(168, 159);
            this.CancelButtonSettings.Margin = new System.Windows.Forms.Padding(4);
            this.CancelButtonSettings.Name = "CancelButtonSettings";
            this.CancelButtonSettings.Size = new System.Drawing.Size(120, 36);
            this.CancelButtonSettings.TabIndex = 2;
            this.CancelButtonSettings.Text = "Close";
            this.CancelButtonSettings.UseVisualStyleBackColor = true;
            this.CancelButtonSettings.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // StartHotspotAutomaticallyCheckBox
            // 
            this.StartHotspotAutomaticallyCheckBox.AutoSize = true;
            this.StartHotspotAutomaticallyCheckBox.Location = new System.Drawing.Point(34, 84);
            this.StartHotspotAutomaticallyCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.StartHotspotAutomaticallyCheckBox.Name = "StartHotspotAutomaticallyCheckBox";
            this.StartHotspotAutomaticallyCheckBox.Size = new System.Drawing.Size(233, 22);
            this.StartHotspotAutomaticallyCheckBox.TabIndex = 3;
            this.StartHotspotAutomaticallyCheckBox.Text = "Start hotspot on program start";
            this.StartHotspotAutomaticallyCheckBox.UseVisualStyleBackColor = true;
            // 
            // StartMinimizedCheckBox
            // 
            this.StartMinimizedCheckBox.AutoSize = true;
            this.StartMinimizedCheckBox.Location = new System.Drawing.Point(34, 24);
            this.StartMinimizedCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.StartMinimizedCheckBox.Name = "StartMinimizedCheckBox";
            this.StartMinimizedCheckBox.Size = new System.Drawing.Size(118, 22);
            this.StartMinimizedCheckBox.TabIndex = 4;
            this.StartMinimizedCheckBox.Text = "Start minized";
            this.StartMinimizedCheckBox.UseVisualStyleBackColor = true;
            // 
            // ShowMessageMinimizedCheckBox
            // 
            this.ShowMessageMinimizedCheckBox.AutoSize = true;
            this.ShowMessageMinimizedCheckBox.Location = new System.Drawing.Point(34, 54);
            this.ShowMessageMinimizedCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.ShowMessageMinimizedCheckBox.Name = "ShowMessageMinimizedCheckBox";
            this.ShowMessageMinimizedCheckBox.Size = new System.Drawing.Size(250, 22);
            this.ShowMessageMinimizedCheckBox.TabIndex = 5;
            this.ShowMessageMinimizedCheckBox.Text = "Show message when minimized";
            this.ShowMessageMinimizedCheckBox.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 221);
            this.Controls.Add(this.ShowMessageMinimizedCheckBox);
            this.Controls.Add(this.StartMinimizedCheckBox);
            this.Controls.Add(this.StartHotspotAutomaticallyCheckBox);
            this.Controls.Add(this.CancelButtonSettings);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.EnableLoggingCheckBox);
            this.Font = new System.Drawing.Font("Arial", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox EnableLoggingCheckBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button CancelButtonSettings;
        private System.Windows.Forms.CheckBox StartHotspotAutomaticallyCheckBox;
        private System.Windows.Forms.CheckBox StartMinimizedCheckBox;
        private System.Windows.Forms.CheckBox ShowMessageMinimizedCheckBox;
    }
}