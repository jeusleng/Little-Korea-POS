﻿namespace SplashScreenLadera
{
    partial class CashierScreen
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.productGridview = new Guna.UI2.WinForms.Guna2DataGridView();
            this.temptransactionGridview = new Guna.UI2.WinForms.Guna2DataGridView();
            this.productIdLabel = new System.Windows.Forms.Label();
            this.productId = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.productName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.productPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.cashierNameLabel = new System.Windows.Forms.Label();
            this.addButton = new Guna.UI2.WinForms.Guna2Button();
            this.cancelButton = new Guna.UI2.WinForms.Guna2Button();
            this.paymentButton = new Guna.UI2.WinForms.Guna2Button();
            this.addqtyButton = new Guna.UI2.WinForms.Guna2Button();
            this.voidButton = new Guna.UI2.WinForms.Guna2Button();
            this.newtransButton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBox3 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBox4 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBox5 = new Guna.UI2.WinForms.Guna2TextBox();
            this.transIdLabel = new Guna.UI2.WinForms.Guna2TextBox();
            this.totalAmountLabel = new Guna.UI2.WinForms.Guna2TextBox();
            this.amountPaidLabel = new Guna.UI2.WinForms.Guna2TextBox();
            this.changeLabel = new Guna.UI2.WinForms.Guna2TextBox();
            this.productQty = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.productQtyField = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.productGridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.temptransactionGridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productQty)).BeginInit();
            this.SuspendLayout();
            // 
            // productGridview
            // 
            this.productGridview.AllowUserToAddRows = false;
            this.productGridview.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.productGridview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productGridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.productGridview.ColumnHeadersHeight = 4;
            this.productGridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.productGridview.DefaultCellStyle = dataGridViewCellStyle3;
            this.productGridview.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.productGridview.Location = new System.Drawing.Point(12, 252);
            this.productGridview.Name = "productGridview";
            this.productGridview.ReadOnly = true;
            this.productGridview.RowHeadersVisible = false;
            this.productGridview.Size = new System.Drawing.Size(286, 209);
            this.productGridview.TabIndex = 0;
            this.productGridview.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.productGridview.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.productGridview.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.productGridview.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.productGridview.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.productGridview.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.productGridview.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.productGridview.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.productGridview.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.productGridview.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productGridview.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.productGridview.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.productGridview.ThemeStyle.HeaderStyle.Height = 4;
            this.productGridview.ThemeStyle.ReadOnly = true;
            this.productGridview.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.productGridview.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.productGridview.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productGridview.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.productGridview.ThemeStyle.RowsStyle.Height = 22;
            this.productGridview.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.productGridview.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.productGridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productGridview_CellContentClick);
            // 
            // temptransactionGridview
            // 
            this.temptransactionGridview.AllowUserToAddRows = false;
            this.temptransactionGridview.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.temptransactionGridview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.temptransactionGridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.temptransactionGridview.ColumnHeadersHeight = 4;
            this.temptransactionGridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.temptransactionGridview.DefaultCellStyle = dataGridViewCellStyle6;
            this.temptransactionGridview.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.temptransactionGridview.Location = new System.Drawing.Point(328, 12);
            this.temptransactionGridview.Name = "temptransactionGridview";
            this.temptransactionGridview.ReadOnly = true;
            this.temptransactionGridview.RowHeadersVisible = false;
            this.temptransactionGridview.Size = new System.Drawing.Size(286, 151);
            this.temptransactionGridview.TabIndex = 1;
            this.temptransactionGridview.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.temptransactionGridview.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.temptransactionGridview.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.temptransactionGridview.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.temptransactionGridview.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.temptransactionGridview.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.temptransactionGridview.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.temptransactionGridview.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.temptransactionGridview.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.temptransactionGridview.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temptransactionGridview.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.temptransactionGridview.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.temptransactionGridview.ThemeStyle.HeaderStyle.Height = 4;
            this.temptransactionGridview.ThemeStyle.ReadOnly = true;
            this.temptransactionGridview.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.temptransactionGridview.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.temptransactionGridview.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temptransactionGridview.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.temptransactionGridview.ThemeStyle.RowsStyle.Height = 22;
            this.temptransactionGridview.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.temptransactionGridview.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.temptransactionGridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.temptransactionGridview_CellContentClick);
            // 
            // productIdLabel
            // 
            this.productIdLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.productIdLabel.AutoSize = true;
            this.productIdLabel.BackColor = System.Drawing.Color.Transparent;
            this.productIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productIdLabel.ForeColor = System.Drawing.Color.Maroon;
            this.productIdLabel.Location = new System.Drawing.Point(9, 23);
            this.productIdLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.productIdLabel.Name = "productIdLabel";
            this.productIdLabel.Size = new System.Drawing.Size(56, 13);
            this.productIdLabel.TabIndex = 39;
            this.productIdLabel.Text = "Product Id";
            this.productIdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.productIdLabel.Visible = false;
            // 
            // productId
            // 
            this.productId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.productId.BackColor = System.Drawing.Color.Transparent;
            this.productId.BorderColor = System.Drawing.Color.Maroon;
            this.productId.BorderRadius = 10;
            this.productId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.productId.DefaultText = "";
            this.productId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.productId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.productId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.productId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.productId.Enabled = false;
            this.productId.FocusedState.BorderColor = System.Drawing.Color.Maroon;
            this.productId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productId.ForeColor = System.Drawing.Color.Firebrick;
            this.productId.HoverState.BorderColor = System.Drawing.Color.Maroon;
            this.productId.HoverState.FillColor = System.Drawing.Color.AntiqueWhite;
            this.productId.IconLeftOffset = new System.Drawing.Point(7, 0);
            this.productId.IconLeftSize = new System.Drawing.Size(17, 17);
            this.productId.Location = new System.Drawing.Point(70, 12);
            this.productId.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.productId.Name = "productId";
            this.productId.PasswordChar = '\0';
            this.productId.PlaceholderForeColor = System.Drawing.Color.Maroon;
            this.productId.PlaceholderText = "";
            this.productId.SelectedText = "";
            this.productId.Size = new System.Drawing.Size(24, 32);
            this.productId.TabIndex = 38;
            this.productId.Visible = false;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Maroon;
            this.label8.Location = new System.Drawing.Point(31, 65);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 19);
            this.label8.TabIndex = 63;
            this.label8.Text = "Product";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // productName
            // 
            this.productName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.productName.BackColor = System.Drawing.Color.Transparent;
            this.productName.BorderColor = System.Drawing.Color.Maroon;
            this.productName.BorderRadius = 10;
            this.productName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.productName.DefaultText = "";
            this.productName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.productName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.productName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.productName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.productName.FillColor = System.Drawing.Color.LightGray;
            this.productName.FocusedState.BorderColor = System.Drawing.Color.Maroon;
            this.productName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productName.ForeColor = System.Drawing.Color.Firebrick;
            this.productName.HoverState.BorderColor = System.Drawing.Color.Maroon;
            this.productName.HoverState.FillColor = System.Drawing.Color.AntiqueWhite;
            this.productName.IconLeftOffset = new System.Drawing.Point(7, 0);
            this.productName.IconLeftSize = new System.Drawing.Size(17, 17);
            this.productName.Location = new System.Drawing.Point(126, 58);
            this.productName.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.productName.Name = "productName";
            this.productName.PasswordChar = '\0';
            this.productName.PlaceholderForeColor = System.Drawing.Color.Maroon;
            this.productName.PlaceholderText = "";
            this.productName.ReadOnly = true;
            this.productName.SelectedText = "";
            this.productName.Size = new System.Drawing.Size(149, 32);
            this.productName.TabIndex = 62;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(31, 103);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 19);
            this.label2.TabIndex = 61;
            this.label2.Text = "Price";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // productPrice
            // 
            this.productPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.productPrice.BackColor = System.Drawing.Color.Transparent;
            this.productPrice.BorderColor = System.Drawing.Color.Maroon;
            this.productPrice.BorderRadius = 10;
            this.productPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.productPrice.DefaultText = "";
            this.productPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.productPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.productPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.productPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.productPrice.FillColor = System.Drawing.Color.LightGray;
            this.productPrice.FocusedState.BorderColor = System.Drawing.Color.Maroon;
            this.productPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.productPrice.ForeColor = System.Drawing.Color.Firebrick;
            this.productPrice.HoverState.BorderColor = System.Drawing.Color.Maroon;
            this.productPrice.HoverState.FillColor = System.Drawing.Color.AntiqueWhite;
            this.productPrice.IconLeftOffset = new System.Drawing.Point(7, 0);
            this.productPrice.IconLeftSize = new System.Drawing.Size(17, 17);
            this.productPrice.Location = new System.Drawing.Point(126, 96);
            this.productPrice.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.productPrice.Name = "productPrice";
            this.productPrice.PasswordChar = '\0';
            this.productPrice.PlaceholderForeColor = System.Drawing.Color.Maroon;
            this.productPrice.PlaceholderText = "";
            this.productPrice.ReadOnly = true;
            this.productPrice.SelectedText = "";
            this.productPrice.Size = new System.Drawing.Size(149, 32);
            this.productPrice.TabIndex = 60;
            // 
            // cashierNameLabel
            // 
            this.cashierNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cashierNameLabel.AutoSize = true;
            this.cashierNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.cashierNameLabel.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierNameLabel.ForeColor = System.Drawing.Color.Maroon;
            this.cashierNameLabel.Location = new System.Drawing.Point(31, 144);
            this.cashierNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cashierNameLabel.Name = "cashierNameLabel";
            this.cashierNameLabel.Size = new System.Drawing.Size(56, 19);
            this.cashierNameLabel.TabIndex = 59;
            this.cashierNameLabel.Text = "Quantity";
            this.cashierNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.addButton.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.HoverState.FillColor = System.Drawing.Color.IndianRed;
            this.addButton.Location = new System.Drawing.Point(80, 183);
            this.addButton.Margin = new System.Windows.Forms.Padding(2);
            this.addButton.Name = "addButton";
            this.addButton.PressedColor = System.Drawing.Color.Transparent;
            this.addButton.ShadowDecoration.Color = System.Drawing.Color.Transparent;
            this.addButton.ShadowDecoration.Enabled = true;
            this.addButton.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.addButton.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(10);
            this.addButton.Size = new System.Drawing.Size(131, 38);
            this.addButton.TabIndex = 64;
            this.addButton.Text = "Add Item";
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cancelButton.BackColor = System.Drawing.Color.Transparent;
            this.cancelButton.BorderRadius = 10;
            this.cancelButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.cancelButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.cancelButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cancelButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.cancelButton.FillColor = System.Drawing.Color.Maroon;
            this.cancelButton.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.Color.White;
            this.cancelButton.HoverState.FillColor = System.Drawing.Color.IndianRed;
            this.cancelButton.Location = new System.Drawing.Point(328, 414);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.PressedColor = System.Drawing.Color.Transparent;
            this.cancelButton.ShadowDecoration.Color = System.Drawing.Color.Transparent;
            this.cancelButton.ShadowDecoration.Enabled = true;
            this.cancelButton.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.cancelButton.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(10);
            this.cancelButton.Size = new System.Drawing.Size(131, 38);
            this.cancelButton.TabIndex = 65;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // paymentButton
            // 
            this.paymentButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.paymentButton.BackColor = System.Drawing.Color.Transparent;
            this.paymentButton.BorderRadius = 10;
            this.paymentButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.paymentButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.paymentButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.paymentButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.paymentButton.FillColor = System.Drawing.Color.Maroon;
            this.paymentButton.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentButton.ForeColor = System.Drawing.Color.White;
            this.paymentButton.HoverState.FillColor = System.Drawing.Color.IndianRed;
            this.paymentButton.Location = new System.Drawing.Point(400, 330);
            this.paymentButton.Margin = new System.Windows.Forms.Padding(2);
            this.paymentButton.Name = "paymentButton";
            this.paymentButton.PressedColor = System.Drawing.Color.Transparent;
            this.paymentButton.ShadowDecoration.Color = System.Drawing.Color.Transparent;
            this.paymentButton.ShadowDecoration.Enabled = true;
            this.paymentButton.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.paymentButton.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(10);
            this.paymentButton.Size = new System.Drawing.Size(131, 38);
            this.paymentButton.TabIndex = 66;
            this.paymentButton.Text = "Payment";
            this.paymentButton.Click += new System.EventHandler(this.paymentButton_Click);
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
            this.addqtyButton.Location = new System.Drawing.Point(328, 372);
            this.addqtyButton.Margin = new System.Windows.Forms.Padding(2);
            this.addqtyButton.Name = "addqtyButton";
            this.addqtyButton.PressedColor = System.Drawing.Color.Transparent;
            this.addqtyButton.ShadowDecoration.Color = System.Drawing.Color.Transparent;
            this.addqtyButton.ShadowDecoration.Enabled = true;
            this.addqtyButton.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.addqtyButton.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(10);
            this.addqtyButton.Size = new System.Drawing.Size(131, 38);
            this.addqtyButton.TabIndex = 67;
            this.addqtyButton.Text = "Add Quanity";
            this.addqtyButton.Click += new System.EventHandler(this.addqtyButton_Click);
            // 
            // voidButton
            // 
            this.voidButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.voidButton.BackColor = System.Drawing.Color.Transparent;
            this.voidButton.BorderRadius = 10;
            this.voidButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.voidButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.voidButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.voidButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.voidButton.FillColor = System.Drawing.Color.Maroon;
            this.voidButton.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voidButton.ForeColor = System.Drawing.Color.White;
            this.voidButton.HoverState.FillColor = System.Drawing.Color.IndianRed;
            this.voidButton.Location = new System.Drawing.Point(468, 372);
            this.voidButton.Margin = new System.Windows.Forms.Padding(2);
            this.voidButton.Name = "voidButton";
            this.voidButton.PressedColor = System.Drawing.Color.Transparent;
            this.voidButton.ShadowDecoration.Color = System.Drawing.Color.Transparent;
            this.voidButton.ShadowDecoration.Enabled = true;
            this.voidButton.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.voidButton.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(10);
            this.voidButton.Size = new System.Drawing.Size(131, 38);
            this.voidButton.TabIndex = 68;
            this.voidButton.Text = "Void Item";
            this.voidButton.Click += new System.EventHandler(this.voidButton_Click);
            // 
            // newtransButton
            // 
            this.newtransButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.newtransButton.BackColor = System.Drawing.Color.Transparent;
            this.newtransButton.BorderRadius = 10;
            this.newtransButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.newtransButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.newtransButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.newtransButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.newtransButton.Enabled = false;
            this.newtransButton.FillColor = System.Drawing.Color.Maroon;
            this.newtransButton.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newtransButton.ForeColor = System.Drawing.Color.White;
            this.newtransButton.HoverState.FillColor = System.Drawing.Color.IndianRed;
            this.newtransButton.Location = new System.Drawing.Point(468, 414);
            this.newtransButton.Margin = new System.Windows.Forms.Padding(2);
            this.newtransButton.Name = "newtransButton";
            this.newtransButton.PressedColor = System.Drawing.Color.Transparent;
            this.newtransButton.ShadowDecoration.Color = System.Drawing.Color.Transparent;
            this.newtransButton.ShadowDecoration.Enabled = true;
            this.newtransButton.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.newtransButton.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(10);
            this.newtransButton.Size = new System.Drawing.Size(131, 38);
            this.newtransButton.TabIndex = 69;
            this.newtransButton.Text = "New Transaction";
            this.newtransButton.Click += new System.EventHandler(this.newtransButton_Click);
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "Transaction Details";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FillColor = System.Drawing.SystemColors.Control;
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Location = new System.Drawing.Point(328, 169);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(286, 27);
            this.guna2TextBox1.TabIndex = 70;
            this.guna2TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guna2TextBox2
            // 
            this.guna2TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox2.DefaultText = "Transaction ID";
            this.guna2TextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.FillColor = System.Drawing.SystemColors.Control;
            this.guna2TextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox2.Location = new System.Drawing.Point(328, 202);
            this.guna2TextBox2.Name = "guna2TextBox2";
            this.guna2TextBox2.PasswordChar = '\0';
            this.guna2TextBox2.PlaceholderText = "";
            this.guna2TextBox2.SelectedText = "";
            this.guna2TextBox2.Size = new System.Drawing.Size(123, 27);
            this.guna2TextBox2.TabIndex = 71;
            this.guna2TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guna2TextBox3
            // 
            this.guna2TextBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox3.DefaultText = "Total Amount";
            this.guna2TextBox3.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox3.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox3.FillColor = System.Drawing.SystemColors.Control;
            this.guna2TextBox3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox3.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox3.Location = new System.Drawing.Point(328, 235);
            this.guna2TextBox3.Name = "guna2TextBox3";
            this.guna2TextBox3.PasswordChar = '\0';
            this.guna2TextBox3.PlaceholderText = "";
            this.guna2TextBox3.SelectedText = "";
            this.guna2TextBox3.Size = new System.Drawing.Size(123, 27);
            this.guna2TextBox3.TabIndex = 72;
            this.guna2TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guna2TextBox4
            // 
            this.guna2TextBox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox4.DefaultText = "Amount Paid";
            this.guna2TextBox4.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox4.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox4.FillColor = System.Drawing.SystemColors.Control;
            this.guna2TextBox4.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox4.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox4.Location = new System.Drawing.Point(328, 268);
            this.guna2TextBox4.Name = "guna2TextBox4";
            this.guna2TextBox4.PasswordChar = '\0';
            this.guna2TextBox4.PlaceholderText = "";
            this.guna2TextBox4.SelectedText = "";
            this.guna2TextBox4.Size = new System.Drawing.Size(123, 27);
            this.guna2TextBox4.TabIndex = 73;
            this.guna2TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guna2TextBox5
            // 
            this.guna2TextBox5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox5.DefaultText = "Change";
            this.guna2TextBox5.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox5.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox5.FillColor = System.Drawing.SystemColors.Control;
            this.guna2TextBox5.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox5.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox5.Location = new System.Drawing.Point(328, 301);
            this.guna2TextBox5.Name = "guna2TextBox5";
            this.guna2TextBox5.PasswordChar = '\0';
            this.guna2TextBox5.PlaceholderText = "";
            this.guna2TextBox5.SelectedText = "";
            this.guna2TextBox5.Size = new System.Drawing.Size(123, 27);
            this.guna2TextBox5.TabIndex = 74;
            this.guna2TextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // transIdLabel
            // 
            this.transIdLabel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.transIdLabel.DefaultText = "0";
            this.transIdLabel.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.transIdLabel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.transIdLabel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.transIdLabel.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.transIdLabel.FillColor = System.Drawing.SystemColors.Control;
            this.transIdLabel.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.transIdLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.transIdLabel.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.transIdLabel.Location = new System.Drawing.Point(495, 202);
            this.transIdLabel.Name = "transIdLabel";
            this.transIdLabel.PasswordChar = '\0';
            this.transIdLabel.PlaceholderText = "";
            this.transIdLabel.SelectedText = "";
            this.transIdLabel.Size = new System.Drawing.Size(63, 27);
            this.transIdLabel.TabIndex = 75;
            this.transIdLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // totalAmountLabel
            // 
            this.totalAmountLabel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.totalAmountLabel.DefaultText = "0";
            this.totalAmountLabel.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.totalAmountLabel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.totalAmountLabel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.totalAmountLabel.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.totalAmountLabel.FillColor = System.Drawing.SystemColors.Control;
            this.totalAmountLabel.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.totalAmountLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.totalAmountLabel.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.totalAmountLabel.Location = new System.Drawing.Point(495, 235);
            this.totalAmountLabel.Name = "totalAmountLabel";
            this.totalAmountLabel.PasswordChar = '\0';
            this.totalAmountLabel.PlaceholderText = "";
            this.totalAmountLabel.SelectedText = "";
            this.totalAmountLabel.Size = new System.Drawing.Size(63, 27);
            this.totalAmountLabel.TabIndex = 76;
            this.totalAmountLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // amountPaidLabel
            // 
            this.amountPaidLabel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.amountPaidLabel.DefaultText = "0";
            this.amountPaidLabel.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.amountPaidLabel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.amountPaidLabel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.amountPaidLabel.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.amountPaidLabel.FillColor = System.Drawing.SystemColors.Control;
            this.amountPaidLabel.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.amountPaidLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.amountPaidLabel.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.amountPaidLabel.Location = new System.Drawing.Point(495, 268);
            this.amountPaidLabel.Name = "amountPaidLabel";
            this.amountPaidLabel.PasswordChar = '\0';
            this.amountPaidLabel.PlaceholderText = "";
            this.amountPaidLabel.SelectedText = "";
            this.amountPaidLabel.Size = new System.Drawing.Size(63, 27);
            this.amountPaidLabel.TabIndex = 77;
            this.amountPaidLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // changeLabel
            // 
            this.changeLabel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.changeLabel.DefaultText = "0";
            this.changeLabel.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.changeLabel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.changeLabel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.changeLabel.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.changeLabel.FillColor = System.Drawing.SystemColors.Control;
            this.changeLabel.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.changeLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.changeLabel.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.changeLabel.Location = new System.Drawing.Point(495, 301);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.PasswordChar = '\0';
            this.changeLabel.PlaceholderText = "";
            this.changeLabel.SelectedText = "";
            this.changeLabel.Size = new System.Drawing.Size(63, 27);
            this.changeLabel.TabIndex = 78;
            this.changeLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // productQty
            // 
            this.productQty.BackColor = System.Drawing.Color.Transparent;
            this.productQty.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.productQty.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.productQty.Location = new System.Drawing.Point(126, 136);
            this.productQty.Name = "productQty";
            this.productQty.Size = new System.Drawing.Size(149, 36);
            this.productQty.TabIndex = 79;
            // 
            // productQtyField
            // 
            this.productQtyField.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.productQtyField.BackColor = System.Drawing.Color.Transparent;
            this.productQtyField.BorderColor = System.Drawing.Color.Maroon;
            this.productQtyField.BorderRadius = 10;
            this.productQtyField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.productQtyField.DefaultText = "";
            this.productQtyField.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.productQtyField.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.productQtyField.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.productQtyField.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.productQtyField.Enabled = false;
            this.productQtyField.FocusedState.BorderColor = System.Drawing.Color.Maroon;
            this.productQtyField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productQtyField.ForeColor = System.Drawing.Color.Firebrick;
            this.productQtyField.HoverState.BorderColor = System.Drawing.Color.Maroon;
            this.productQtyField.HoverState.FillColor = System.Drawing.Color.AntiqueWhite;
            this.productQtyField.IconLeftOffset = new System.Drawing.Point(7, 0);
            this.productQtyField.IconLeftSize = new System.Drawing.Size(17, 17);
            this.productQtyField.Location = new System.Drawing.Point(100, 12);
            this.productQtyField.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.productQtyField.Name = "productQtyField";
            this.productQtyField.PasswordChar = '\0';
            this.productQtyField.PlaceholderForeColor = System.Drawing.Color.Maroon;
            this.productQtyField.PlaceholderText = "";
            this.productQtyField.SelectedText = "";
            this.productQtyField.Size = new System.Drawing.Size(24, 32);
            this.productQtyField.TabIndex = 80;
            this.productQtyField.Visible = false;
            // 
            // CashierScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 473);
            this.Controls.Add(this.productQtyField);
            this.Controls.Add(this.productQty);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.amountPaidLabel);
            this.Controls.Add(this.totalAmountLabel);
            this.Controls.Add(this.transIdLabel);
            this.Controls.Add(this.guna2TextBox5);
            this.Controls.Add(this.guna2TextBox4);
            this.Controls.Add(this.guna2TextBox3);
            this.Controls.Add(this.guna2TextBox2);
            this.Controls.Add(this.guna2TextBox1);
            this.Controls.Add(this.newtransButton);
            this.Controls.Add(this.voidButton);
            this.Controls.Add(this.addqtyButton);
            this.Controls.Add(this.paymentButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.productName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.productPrice);
            this.Controls.Add(this.cashierNameLabel);
            this.Controls.Add(this.productIdLabel);
            this.Controls.Add(this.productId);
            this.Controls.Add(this.temptransactionGridview);
            this.Controls.Add(this.productGridview);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CashierScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CashierScreen";
            this.Load += new System.EventHandler(this.CashierScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productGridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.temptransactionGridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productQty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView productGridview;
        private Guna.UI2.WinForms.Guna2DataGridView temptransactionGridview;
        private System.Windows.Forms.Label productIdLabel;
        private Guna.UI2.WinForms.Guna2TextBox productId;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox productName;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox productPrice;
        private System.Windows.Forms.Label cashierNameLabel;
        private Guna.UI2.WinForms.Guna2Button addButton;
        private Guna.UI2.WinForms.Guna2Button cancelButton;
        private Guna.UI2.WinForms.Guna2Button paymentButton;
        private Guna.UI2.WinForms.Guna2Button addqtyButton;
        private Guna.UI2.WinForms.Guna2Button voidButton;
        private Guna.UI2.WinForms.Guna2Button newtransButton;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox2;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox3;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox4;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox5;
        private Guna.UI2.WinForms.Guna2TextBox transIdLabel;
        private Guna.UI2.WinForms.Guna2TextBox totalAmountLabel;
        private Guna.UI2.WinForms.Guna2TextBox amountPaidLabel;
        private Guna.UI2.WinForms.Guna2TextBox changeLabel;
        private Guna.UI2.WinForms.Guna2NumericUpDown productQty;
        private Guna.UI2.WinForms.Guna2TextBox productQtyField;
    }
}