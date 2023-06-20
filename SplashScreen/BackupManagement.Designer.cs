namespace SplashScreenLadera
{
    partial class BackupManagement
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
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.pathField = new Guna.UI2.WinForms.Guna2TextBox();
            this.locationButton = new Guna.UI2.WinForms.Guna2Button();
            this.backupButton = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "Destination";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FillColor = System.Drawing.SystemColors.Control;
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Location = new System.Drawing.Point(85, 199);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(88, 36);
            this.guna2TextBox1.TabIndex = 0;
            this.guna2TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pathField
            // 
            this.pathField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pathField.DefaultText = "";
            this.pathField.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.pathField.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.pathField.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.pathField.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.pathField.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.pathField.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.pathField.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.pathField.Location = new System.Drawing.Point(179, 199);
            this.pathField.Name = "pathField";
            this.pathField.PasswordChar = '\0';
            this.pathField.PlaceholderText = "Select a backup file path";
            this.pathField.ReadOnly = true;
            this.pathField.SelectedText = "";
            this.pathField.Size = new System.Drawing.Size(253, 36);
            this.pathField.TabIndex = 1;
            // 
            // locationButton
            // 
            this.locationButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.locationButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.locationButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.locationButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.locationButton.FillColor = System.Drawing.Color.Gray;
            this.locationButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.locationButton.ForeColor = System.Drawing.Color.Black;
            this.locationButton.Location = new System.Drawing.Point(457, 199);
            this.locationButton.Name = "locationButton";
            this.locationButton.Size = new System.Drawing.Size(69, 36);
            this.locationButton.TabIndex = 2;
            this.locationButton.Text = "...";
            this.locationButton.Click += new System.EventHandler(this.locationButton_Click);
            // 
            // backupButton
            // 
            this.backupButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.backupButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.backupButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.backupButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.backupButton.FillColor = System.Drawing.Color.Gray;
            this.backupButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.backupButton.ForeColor = System.Drawing.Color.Black;
            this.backupButton.Location = new System.Drawing.Point(227, 302);
            this.backupButton.Name = "backupButton";
            this.backupButton.Size = new System.Drawing.Size(149, 36);
            this.backupButton.TabIndex = 3;
            this.backupButton.Text = "Backup Database";
            this.backupButton.Click += new System.EventHandler(this.backupButton_Click);
            // 
            // BackupManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 434);
            this.Controls.Add(this.backupButton);
            this.Controls.Add(this.locationButton);
            this.Controls.Add(this.pathField);
            this.Controls.Add(this.guna2TextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BackupManagement";
            this.Text = "BackupManagement";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2TextBox pathField;
        private Guna.UI2.WinForms.Guna2Button locationButton;
        private Guna.UI2.WinForms.Guna2Button backupButton;
    }
}