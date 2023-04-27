
namespace SplashScreenLadera
{
    partial class AccountManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountManagement));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label8 = new System.Windows.Forms.Label();
            this.idField = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.usernameField = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.passwordField = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.roleField = new Guna.UI2.WinForms.Guna2TextBox();
            this.dataGridview = new Guna.UI2.WinForms.Guna2DataGridView();
            this.usersTable = new SplashScreenLadera.usersTable();
            this.usersTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableTableAdapter = new SplashScreenLadera.usersTableTableAdapters.usersTableTableAdapter();
            this.insertButton = new Guna.UI2.WinForms.Guna2Button();
            this.updateButton = new Guna.UI2.WinForms.Guna2Button();
            this.viewButton = new Guna.UI2.WinForms.Guna2Button();
            this.deleteButton = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Maroon;
            this.label8.Location = new System.Drawing.Point(4, 12);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "ID";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label8.Visible = false;
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // idField
            // 
            this.idField.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.idField.BackColor = System.Drawing.Color.Transparent;
            this.idField.BorderColor = System.Drawing.Color.Maroon;
            this.idField.BorderRadius = 10;
            this.idField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.idField.DefaultText = "";
            this.idField.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.idField.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.idField.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.idField.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.idField.FocusedState.BorderColor = System.Drawing.Color.Maroon;
            this.idField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idField.ForeColor = System.Drawing.Color.Firebrick;
            this.idField.HoverState.BorderColor = System.Drawing.Color.Maroon;
            this.idField.HoverState.FillColor = System.Drawing.Color.AntiqueWhite;
            this.idField.IconLeft = ((System.Drawing.Image)(resources.GetObject("idField.IconLeft")));
            this.idField.IconLeftOffset = new System.Drawing.Point(7, 0);
            this.idField.IconLeftSize = new System.Drawing.Size(17, 17);
            this.idField.Location = new System.Drawing.Point(24, 12);
            this.idField.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.idField.Name = "idField";
            this.idField.PasswordChar = '\0';
            this.idField.PlaceholderForeColor = System.Drawing.Color.Maroon;
            this.idField.PlaceholderText = "";
            this.idField.SelectedText = "";
            this.idField.Size = new System.Drawing.Size(30, 25);
            this.idField.TabIndex = 25;
            this.idField.Visible = false;
            this.idField.TextChanged += new System.EventHandler(this.idField_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(40, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Username";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // usernameField
            // 
            this.usernameField.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.usernameField.BackColor = System.Drawing.Color.Transparent;
            this.usernameField.BorderColor = System.Drawing.Color.Maroon;
            this.usernameField.BorderRadius = 10;
            this.usernameField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usernameField.DefaultText = "";
            this.usernameField.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.usernameField.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.usernameField.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usernameField.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usernameField.FocusedState.BorderColor = System.Drawing.Color.Maroon;
            this.usernameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameField.ForeColor = System.Drawing.Color.Firebrick;
            this.usernameField.HoverState.BorderColor = System.Drawing.Color.Maroon;
            this.usernameField.HoverState.FillColor = System.Drawing.Color.AntiqueWhite;
            this.usernameField.IconLeft = ((System.Drawing.Image)(resources.GetObject("usernameField.IconLeft")));
            this.usernameField.IconLeftOffset = new System.Drawing.Point(7, 0);
            this.usernameField.IconLeftSize = new System.Drawing.Size(17, 17);
            this.usernameField.Location = new System.Drawing.Point(105, 89);
            this.usernameField.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.usernameField.Name = "usernameField";
            this.usernameField.PasswordChar = '\0';
            this.usernameField.PlaceholderForeColor = System.Drawing.Color.Maroon;
            this.usernameField.PlaceholderText = "";
            this.usernameField.SelectedText = "";
            this.usernameField.Size = new System.Drawing.Size(149, 32);
            this.usernameField.TabIndex = 23;
            this.usernameField.TextChanged += new System.EventHandler(this.firstnameField_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(192, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 26);
            this.label1.TabIndex = 27;
            this.label1.Text = "Account Management";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(42, 138);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Password";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // passwordField
            // 
            this.passwordField.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordField.BackColor = System.Drawing.Color.Transparent;
            this.passwordField.BorderColor = System.Drawing.Color.Maroon;
            this.passwordField.BorderRadius = 10;
            this.passwordField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordField.DefaultText = "";
            this.passwordField.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.passwordField.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.passwordField.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordField.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordField.FocusedState.BorderColor = System.Drawing.Color.Maroon;
            this.passwordField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordField.ForeColor = System.Drawing.Color.Firebrick;
            this.passwordField.HoverState.BorderColor = System.Drawing.Color.Maroon;
            this.passwordField.HoverState.FillColor = System.Drawing.Color.AntiqueWhite;
            this.passwordField.IconLeft = ((System.Drawing.Image)(resources.GetObject("passwordField.IconLeft")));
            this.passwordField.IconLeftOffset = new System.Drawing.Point(7, 0);
            this.passwordField.IconLeftSize = new System.Drawing.Size(17, 17);
            this.passwordField.Location = new System.Drawing.Point(105, 132);
            this.passwordField.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.passwordField.Name = "passwordField";
            this.passwordField.PasswordChar = '\0';
            this.passwordField.PlaceholderForeColor = System.Drawing.Color.Maroon;
            this.passwordField.PlaceholderText = "";
            this.passwordField.SelectedText = "";
            this.passwordField.Size = new System.Drawing.Size(149, 32);
            this.passwordField.TabIndex = 28;
            this.passwordField.TextChanged += new System.EventHandler(this.passwordField_TextChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(55, 184);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Role";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // roleField
            // 
            this.roleField.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.roleField.BackColor = System.Drawing.Color.Transparent;
            this.roleField.BorderColor = System.Drawing.Color.Maroon;
            this.roleField.BorderRadius = 10;
            this.roleField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.roleField.DefaultText = "";
            this.roleField.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.roleField.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.roleField.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.roleField.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.roleField.FocusedState.BorderColor = System.Drawing.Color.Maroon;
            this.roleField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleField.ForeColor = System.Drawing.Color.Firebrick;
            this.roleField.HoverState.BorderColor = System.Drawing.Color.Maroon;
            this.roleField.HoverState.FillColor = System.Drawing.Color.AntiqueWhite;
            this.roleField.IconLeft = ((System.Drawing.Image)(resources.GetObject("roleField.IconLeft")));
            this.roleField.IconLeftOffset = new System.Drawing.Point(7, 0);
            this.roleField.IconLeftSize = new System.Drawing.Size(17, 17);
            this.roleField.Location = new System.Drawing.Point(105, 174);
            this.roleField.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.roleField.Name = "roleField";
            this.roleField.PasswordChar = '\0';
            this.roleField.PlaceholderForeColor = System.Drawing.Color.Maroon;
            this.roleField.PlaceholderText = "";
            this.roleField.SelectedText = "";
            this.roleField.Size = new System.Drawing.Size(149, 32);
            this.roleField.TabIndex = 30;
            // 
            // dataGridview
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(201)))), ((int)(((byte)(197)))));
            this.dataGridview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridview.ColumnHeadersHeight = 19;
            this.dataGridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(219)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(135)))), ((int)(((byte)(125)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridview.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridview.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(192)))), ((int)(((byte)(188)))));
            this.dataGridview.Location = new System.Drawing.Point(296, 89);
            this.dataGridview.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridview.Name = "dataGridview";
            this.dataGridview.RowHeadersVisible = false;
            this.dataGridview.RowHeadersWidth = 51;
            this.dataGridview.RowTemplate.Height = 24;
            this.dataGridview.Size = new System.Drawing.Size(286, 358);
            this.dataGridview.TabIndex = 32;
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
            // usersTable
            // 
            this.usersTable.DataSetName = "usersTable";
            this.usersTable.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersTableBindingSource
            // 
            this.usersTableBindingSource.DataMember = "usersTable";
            this.usersTableBindingSource.DataSource = this.usersTable;
            // 
            // usersTableTableAdapter
            // 
            this.usersTableTableAdapter.ClearBeforeFill = true;
            // 
            // insertButton
            // 
            this.insertButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.insertButton.BackColor = System.Drawing.Color.Transparent;
            this.insertButton.BorderRadius = 10;
            this.insertButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.insertButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.insertButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.insertButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.insertButton.FillColor = System.Drawing.Color.Maroon;
            this.insertButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertButton.ForeColor = System.Drawing.Color.White;
            this.insertButton.HoverState.FillColor = System.Drawing.Color.IndianRed;
            this.insertButton.Location = new System.Drawing.Point(112, 233);
            this.insertButton.Margin = new System.Windows.Forms.Padding(2);
            this.insertButton.Name = "insertButton";
            this.insertButton.PressedColor = System.Drawing.Color.Transparent;
            this.insertButton.ShadowDecoration.Color = System.Drawing.Color.Transparent;
            this.insertButton.ShadowDecoration.Enabled = true;
            this.insertButton.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.insertButton.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(10);
            this.insertButton.Size = new System.Drawing.Size(131, 38);
            this.insertButton.TabIndex = 33;
            this.insertButton.Text = "Insert/Register";
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.updateButton.BackColor = System.Drawing.Color.Transparent;
            this.updateButton.BorderRadius = 10;
            this.updateButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.updateButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.updateButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.updateButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.updateButton.FillColor = System.Drawing.Color.Maroon;
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.ForeColor = System.Drawing.Color.White;
            this.updateButton.HoverState.FillColor = System.Drawing.Color.IndianRed;
            this.updateButton.Location = new System.Drawing.Point(112, 345);
            this.updateButton.Margin = new System.Windows.Forms.Padding(2);
            this.updateButton.Name = "updateButton";
            this.updateButton.PressedColor = System.Drawing.Color.Transparent;
            this.updateButton.ShadowDecoration.Color = System.Drawing.Color.Transparent;
            this.updateButton.ShadowDecoration.Enabled = true;
            this.updateButton.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.updateButton.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(10);
            this.updateButton.Size = new System.Drawing.Size(131, 38);
            this.updateButton.TabIndex = 34;
            this.updateButton.Text = "Update";
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click_1);
            // 
            // viewButton
            // 
            this.viewButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.viewButton.BackColor = System.Drawing.Color.Transparent;
            this.viewButton.BorderRadius = 10;
            this.viewButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.viewButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.viewButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.viewButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.viewButton.FillColor = System.Drawing.Color.Maroon;
            this.viewButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewButton.ForeColor = System.Drawing.Color.White;
            this.viewButton.HoverState.FillColor = System.Drawing.Color.IndianRed;
            this.viewButton.Location = new System.Drawing.Point(112, 288);
            this.viewButton.Margin = new System.Windows.Forms.Padding(2);
            this.viewButton.Name = "viewButton";
            this.viewButton.PressedColor = System.Drawing.Color.Transparent;
            this.viewButton.ShadowDecoration.Color = System.Drawing.Color.Transparent;
            this.viewButton.ShadowDecoration.Enabled = true;
            this.viewButton.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.viewButton.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(10);
            this.viewButton.Size = new System.Drawing.Size(131, 38);
            this.viewButton.TabIndex = 35;
            this.viewButton.Text = "View";
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deleteButton.BackColor = System.Drawing.Color.Transparent;
            this.deleteButton.BorderRadius = 10;
            this.deleteButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.deleteButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.deleteButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.deleteButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.deleteButton.FillColor = System.Drawing.Color.Maroon;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.Color.White;
            this.deleteButton.HoverState.FillColor = System.Drawing.Color.IndianRed;
            this.deleteButton.Location = new System.Drawing.Point(112, 398);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(2);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.PressedColor = System.Drawing.Color.Transparent;
            this.deleteButton.ShadowDecoration.Color = System.Drawing.Color.Transparent;
            this.deleteButton.ShadowDecoration.Enabled = true;
            this.deleteButton.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.deleteButton.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(10);
            this.deleteButton.Size = new System.Drawing.Size(131, 38);
            this.deleteButton.TabIndex = 36;
            this.deleteButton.Text = "Delete";
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // AccountManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(626, 473);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.viewButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.dataGridview);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.roleField);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.passwordField);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.idField);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.usernameField);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AccountManagement";
            this.Text = "AccountManagement";
            this.Load += new System.EventHandler(this.AccountManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersTableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox idField;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox usernameField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox passwordField;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox roleField;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridview;
        private usersTable usersTable;
        private System.Windows.Forms.BindingSource usersTableBindingSource;
        private usersTableTableAdapters.usersTableTableAdapter usersTableTableAdapter;
        private Guna.UI2.WinForms.Guna2Button insertButton;
        private Guna.UI2.WinForms.Guna2Button updateButton;
        private Guna.UI2.WinForms.Guna2Button viewButton;
        private Guna.UI2.WinForms.Guna2Button deleteButton;
    }
}