namespace SplashScreenLadera
{
    partial class CashierPay
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
            this.amountPay = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.addButton = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.amountPay)).BeginInit();
            this.SuspendLayout();
            // 
            // amountPay
            // 
            this.amountPay.BackColor = System.Drawing.Color.Transparent;
            this.amountPay.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.amountPay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.amountPay.Location = new System.Drawing.Point(134, 98);
            this.amountPay.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.amountPay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.amountPay.Name = "amountPay";
            this.amountPay.Size = new System.Drawing.Size(185, 36);
            this.amountPay.TabIndex = 0;
            this.amountPay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "Add Payment";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FillColor = System.Drawing.SystemColors.Control;
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Location = new System.Drawing.Point(119, 27);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(200, 36);
            this.guna2TextBox1.TabIndex = 1;
            this.guna2TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // addButton
            // 
            this.addButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addButton.BackColor = System.Drawing.Color.Transparent;
            this.addButton.BorderRadius = 10;
            this.addButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addButton.FillColor = System.Drawing.Color.Maroon;
            this.addButton.Font = new System.Drawing.Font("Poppins", 7.8F);
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.HoverState.FillColor = System.Drawing.Color.IndianRed;
            this.addButton.Location = new System.Drawing.Point(158, 160);
            this.addButton.Margin = new System.Windows.Forms.Padding(2);
            this.addButton.Name = "addButton";
            this.addButton.PressedColor = System.Drawing.Color.Transparent;
            this.addButton.ShadowDecoration.Color = System.Drawing.Color.Transparent;
            this.addButton.ShadowDecoration.Enabled = true;
            this.addButton.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.addButton.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(10);
            this.addButton.Size = new System.Drawing.Size(131, 38);
            this.addButton.TabIndex = 65;
            this.addButton.Text = "Add Payment";
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // CashierPay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 252);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.guna2TextBox1);
            this.Controls.Add(this.amountPay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CashierPay";
            this.Text = "CashierPay";
            ((System.ComponentModel.ISupportInitialize)(this.amountPay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        public Guna.UI2.WinForms.Guna2NumericUpDown amountPay;
        public Guna.UI2.WinForms.Guna2Button addButton;
    }
}