namespace SplashScreenLadera
{
    partial class CashierAddQty
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
            this.productQtyField = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.addqtyButton = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.productQtyField)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "Add Qty";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FillColor = System.Drawing.SystemColors.Control;
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Location = new System.Drawing.Point(144, 44);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(200, 36);
            this.guna2TextBox1.TabIndex = 0;
            this.guna2TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // productQtyField
            // 
            this.productQtyField.BackColor = System.Drawing.Color.Transparent;
            this.productQtyField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.productQtyField.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.productQtyField.Location = new System.Drawing.Point(160, 145);
            this.productQtyField.Name = "productQtyField";
            this.productQtyField.Size = new System.Drawing.Size(184, 36);
            this.productQtyField.TabIndex = 1;
            // 
            // addqtyButton
            // 
            this.addqtyButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addqtyButton.BackColor = System.Drawing.Color.Transparent;
            this.addqtyButton.BorderRadius = 10;
            this.addqtyButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addqtyButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addqtyButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addqtyButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addqtyButton.FillColor = System.Drawing.Color.Maroon;
            this.addqtyButton.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addqtyButton.ForeColor = System.Drawing.Color.White;
            this.addqtyButton.HoverState.FillColor = System.Drawing.Color.IndianRed;
            this.addqtyButton.Location = new System.Drawing.Point(183, 208);
            this.addqtyButton.Margin = new System.Windows.Forms.Padding(2);
            this.addqtyButton.Name = "addqtyButton";
            this.addqtyButton.PressedColor = System.Drawing.Color.Transparent;
            this.addqtyButton.ShadowDecoration.Color = System.Drawing.Color.Transparent;
            this.addqtyButton.ShadowDecoration.Enabled = true;
            this.addqtyButton.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.addqtyButton.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(10);
            this.addqtyButton.Size = new System.Drawing.Size(131, 38);
            this.addqtyButton.TabIndex = 65;
            this.addqtyButton.Text = "Enter";
            this.addqtyButton.Click += new System.EventHandler(this.addqtyButton_Click);
            // 
            // CashierAddQty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 291);
            this.Controls.Add(this.addqtyButton);
            this.Controls.Add(this.productQtyField);
            this.Controls.Add(this.guna2TextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CashierAddQty";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CashierAddQty";
            this.Load += new System.EventHandler(this.CashierAddQty_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productQtyField)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2NumericUpDown productQtyField;
        private Guna.UI2.WinForms.Guna2Button addqtyButton;
    }
}