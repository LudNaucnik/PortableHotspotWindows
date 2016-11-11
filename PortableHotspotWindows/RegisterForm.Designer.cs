namespace PortableHotspotWindows
{
    partial class RegisterForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.RegisterTextBox = new System.Windows.Forms.TextBox();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Key";
            // 
            // RegisterTextBox
            // 
            this.RegisterTextBox.Location = new System.Drawing.Point(75, 62);
            this.RegisterTextBox.Name = "RegisterTextBox";
            this.RegisterTextBox.Size = new System.Drawing.Size(320, 26);
            this.RegisterTextBox.TabIndex = 1;
            this.RegisterTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RegisterButton
            // 
            this.RegisterButton.Location = new System.Drawing.Point(413, 59);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(90, 30);
            this.RegisterButton.TabIndex = 2;
            this.RegisterButton.Text = "Register";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Provide Serial Key";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 127);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.RegisterTextBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox RegisterTextBox;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.Label label2;
    }
}