namespace SplashScreenLadera
{
    partial class OrderManagement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridview = new Guna.UI2.WinForms.Guna2DataGridView();
            this.transactionId = new Guna.UI2.WinForms.Guna2TextBox();
            this.cashierName = new Guna.UI2.WinForms.Guna2TextBox();
            this.transactionDate = new Guna.UI2.WinForms.Guna2TextBox();
            this.viewDetailsButton = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridview)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridview
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(201)))), ((int)(((byte)(197)))));
            this.dataGridview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridview.ColumnHeadersHeight = 19;
            this.dataGridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(219)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(135)))), ((int)(((byte)(125)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridview.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridview.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridview.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(192)))), ((int)(((byte)(188)))));
            this.dataGridview.Location = new System.Drawing.Point(53, 55);
            this.dataGridview.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridview.Name = "dataGridview";
            this.dataGridview.RowHeadersVisible = false;
            this.dataGridview.RowHeadersWidth = 51;
            this.dataGridview.RowTemplate.Height = 24;
            this.dataGridview.Size = new System.Drawing.Size(499, 286);
            this.dataGridview.TabIndex = 36;
            this.dataGridview.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Alizarin;
            this.dataGridview.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(201)))), ((int)(((byte)(197)))));
            this.dataGridview.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridview.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridview.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridview.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridview.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridview.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(192)))), ((int)(((byte)(188)))));
            this.dataGridview.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.dataGridview.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridview.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridview.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridview.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridview.ThemeStyle.HeaderStyle.Height = 19;
            this.dataGridview.ThemeStyle.ReadOnly = false;
            this.dataGridview.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(219)))), ((int)(((byte)(216)))));
            this.dataGridview.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridview.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridview.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridview.ThemeStyle.RowsStyle.Height = 24;
            this.dataGridview.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(135)))), ((int)(((byte)(125)))));
            this.dataGridview.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridview_CellContentClick);
            // 
            // transactionId
            // 
            this.transactionId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.transactionId.BackColor = System.Drawing.Color.Transparent;
            this.transactionId.BorderColor = System.Drawing.Color.Maroon;
            this.transactionId.BorderRadius = 10;
            this.transactionId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.transactionId.DefaultText = "";
            this.transactionId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.transactionId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.transactionId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.transactionId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.transactionId.Enabled = false;
            this.transactionId.FocusedState.BorderColor = System.Drawing.Color.Maroon;
            this.transactionId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionId.ForeColor = System.Drawing.Color.Firebrick;
            this.transactionId.HoverState.BorderColor = System.Drawing.Color.Maroon;
            this.transactionId.HoverState.FillColor = System.Drawing.Color.AntiqueWhite;
            this.transactionId.IconLeftOffset = new System.Drawing.Point(7, 0);
            this.transactionId.IconLeftSize = new System.Drawing.Size(17, 17);
            this.transactionId.Location = new System.Drawing.Point(12, 5);
            this.transactionId.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.transactionId.Name = "transactionId";
            this.transactionId.PasswordChar = '\0';
            this.transactionId.PlaceholderForeColor = System.Drawing.Color.Maroon;
            this.transactionId.PlaceholderText = "";
            this.transactionId.SelectedText = "";
            this.transactionId.Size = new System.Drawing.Size(24, 32);
            this.transactionId.TabIndex = 37;
            this.transactionId.Visible = false;
            // 
            // cashierName
            // 
            this.cashierName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cashierName.BackColor = System.Drawing.Color.Transparent;
            this.cashierName.BorderColor = System.Drawing.Color.Maroon;
            this.cashierName.BorderRadius = 10;
            this.cashierName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cashierName.DefaultText = "";
            this.cashierName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.cashierName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.cashierName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.cashierName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.cashierName.Enabled = false;
            this.cashierName.FocusedState.BorderColor = System.Drawing.Color.Maroon;
            this.cashierName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierName.ForeColor = System.Drawing.Color.Firebrick;
            this.cashierName.HoverState.BorderColor = System.Drawing.Color.Maroon;
            this.cashierName.HoverState.FillColor = System.Drawing.Color.AntiqueWhite;
            this.cashierName.IconLeftOffset = new System.Drawing.Point(7, 0);
            this.cashierName.IconLeftSize = new System.Drawing.Size(17, 17);
            this.cashierName.Location = new System.Drawing.Point(42, 5);
            this.cashierName.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cashierName.Name = "cashierName";
            this.cashierName.PasswordChar = '\0';
            this.cashierName.PlaceholderForeColor = System.Drawing.Color.Maroon;
            this.cashierName.PlaceholderText = "";
            this.cashierName.SelectedText = "";
            this.cashierName.Size = new System.Drawing.Size(24, 32);
            this.cashierName.TabIndex = 38;
            this.cashierName.Visible = false;
            // 
            // transactionDate
            // 
            this.transactionDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.transactionDate.BackColor = System.Drawing.Color.Transparent;
            this.transactionDate.BorderColor = System.Drawing.Color.Maroon;
            this.transactionDate.BorderRadius = 10;
            this.transactionDate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.transactionDate.DefaultText = "";
            this.transactionDate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.transactionDate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.transactionDate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.transactionDate.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.transactionDate.Enabled = false;
            this.transactionDate.FocusedState.BorderColor = System.Drawing.Color.Maroon;
            this.transactionDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionDate.ForeColor = System.Drawing.Color.Firebrick;
            this.transactionDate.HoverState.BorderColor = System.Drawing.Color.Maroon;
            this.transactionDate.HoverState.FillColor = System.Drawing.Color.AntiqueWhite;
            this.transactionDate.IconLeftOffset = new System.Drawing.Point(7, 0);
            this.transactionDate.IconLeftSize = new System.Drawing.Size(17, 17);
            this.transactionDate.Location = new System.Drawing.Point(72, 5);
            this.transactionDate.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.transactionDate.Name = "transactionDate";
            this.transactionDate.PasswordChar = '\0';
            this.transactionDate.PlaceholderForeColor = System.Drawing.Color.Maroon;
            this.transactionDate.PlaceholderText = "";
            this.transactionDate.SelectedText = "";
            this.transactionDate.Size = new System.Drawing.Size(24, 32);
            this.transactionDate.TabIndex = 39;
            this.transactionDate.Visible = false;
            // 
            // viewDetailsButton
            // 
            this.viewDetailsButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.viewDetailsButton.BackColor = System.Drawing.Color.Transparent;
            this.viewDetailsButton.BorderRadius = 10;
            this.viewDetailsButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.viewDetailsButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.viewDetailsButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.viewDetailsButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.viewDetailsButton.FillColor = System.Drawing.Color.Maroon;
            this.viewDetailsButton.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewDetailsButton.ForeColor = System.Drawing.Color.White;
            this.viewDetailsButton.HoverState.FillColor = System.Drawing.Color.IndianRed;
            this.viewDetailsButton.Location = new System.Drawing.Point(234, 361);
            this.viewDetailsButton.Margin = new System.Windows.Forms.Padding(2);
            this.viewDetailsButton.Name = "viewDetailsButton";
            this.viewDetailsButton.PressedColor = System.Drawing.Color.Transparent;
            this.viewDetailsButton.ShadowDecoration.Color = System.Drawing.Color.Transparent;
            this.viewDetailsButton.ShadowDecoration.Enabled = true;
            this.viewDetailsButton.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.viewDetailsButton.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(10);
            this.viewDetailsButton.Size = new System.Drawing.Size(131, 38);
            this.viewDetailsButton.TabIndex = 44;
            this.viewDetailsButton.Text = "View";
            this.viewDetailsButton.Click += new System.EventHandler(this.viewDetailsButton_Click);
            // 
            // OrderManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 434);
            this.Controls.Add(this.viewDetailsButton);
            this.Controls.Add(this.transactionDate);
            this.Controls.Add(this.cashierName);
            this.Controls.Add(this.transactionId);
            this.Controls.Add(this.dataGridview);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrderManagement";
            this.Text = "OrderManagement";
            this.Load += new System.EventHandler(this.OrderManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dataGridview;
        private Guna.UI2.WinForms.Guna2TextBox transactionId;
        private Guna.UI2.WinForms.Guna2TextBox cashierName;
        private Guna.UI2.WinForms.Guna2TextBox transactionDate;
        private Guna.UI2.WinForms.Guna2Button viewDetailsButton;
    }
}