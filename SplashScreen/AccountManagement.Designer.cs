
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountManagement));
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridview = new Guna.UI2.WinForms.Guna2DataGridView();
            this.viewButton = new Guna.UI2.WinForms.Guna2Button();
            this.searchBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.roleField = new Guna.UI2.WinForms.Guna2TextBox();
            this.passwordField = new Guna.UI2.WinForms.Guna2TextBox();
            this.usernameField = new Guna.UI2.WinForms.Guna2TextBox();
            this.idField = new Guna.UI2.WinForms.Guna2TextBox();
            this.updateButton = new Guna.UI2.WinForms.Guna2Button();
            this.usersTable = new SplashScreenLadera.usersTable();
            this.usersTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableTableAdapter = new SplashScreenLadera.usersTableTableAdapters.usersTableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Poppins", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(197, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(490, 70);
            this.label1.TabIndex = 27;
            this.label1.Text = "Account Management";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridview
            // 
            this.dataGridview.AllowUserToAddRows = false;
            this.dataGridview.AllowUserToDeleteRows = false;
            this.dataGridview.AllowUserToOrderColumns = true;
            this.dataGridview.AllowUserToResizeColumns = false;
            this.dataGridview.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(201)))), ((int)(((byte)(197)))));
            this.dataGridview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridview.ColumnHeadersHeight = 19;
            this.dataGridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(219)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(135)))), ((int)(((byte)(125)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridview.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridview.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridview.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(192)))), ((int)(((byte)(188)))));
            this.dataGridview.Location = new System.Drawing.Point(32, 183);
            this.dataGridview.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridview.Name = "dataGridview";
            this.dataGridview.RowHeadersVisible = false;
            this.dataGridview.RowHeadersWidth = 51;
            this.dataGridview.RowTemplate.Height = 24;
            this.dataGridview.Size = new System.Drawing.Size(742, 284);
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
            this.viewButton.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewButton.ForeColor = System.Drawing.Color.White;
            this.viewButton.HoverState.FillColor = System.Drawing.Color.IndianRed;
            this.viewButton.Location = new System.Drawing.Point(56, 389);
            this.viewButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.viewButton.Name = "viewButton";
            this.viewButton.PressedColor = System.Drawing.Color.Transparent;
            this.viewButton.ShadowDecoration.Color = System.Drawing.Color.Transparent;
            this.viewButton.ShadowDecoration.Enabled = true;
            this.viewButton.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.viewButton.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(10);
            this.viewButton.Size = new System.Drawing.Size(175, 47);
            this.viewButton.TabIndex = 35;
            this.viewButton.Text = "View";
            this.viewButton.Visible = false;
            this.viewButton.Click += new System.EventHandler(this.viewButton_Click);
            // 
            // searchBox
            // 
            this.searchBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchBox.BackColor = System.Drawing.Color.Transparent;
            this.searchBox.BorderColor = System.Drawing.Color.Maroon;
            this.searchBox.BorderRadius = 10;
            this.searchBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchBox.DefaultText = "";
            this.searchBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.searchBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.searchBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchBox.FocusedState.BorderColor = System.Drawing.Color.Maroon;
            this.searchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.ForeColor = System.Drawing.Color.Firebrick;
            this.searchBox.HoverState.BorderColor = System.Drawing.Color.Maroon;
            this.searchBox.HoverState.FillColor = System.Drawing.Color.AntiqueWhite;
            this.searchBox.IconLeft = ((System.Drawing.Image)(resources.GetObject("searchBox.IconLeft")));
            this.searchBox.IconLeftOffset = new System.Drawing.Point(7, 0);
            this.searchBox.IconLeftSize = new System.Drawing.Size(17, 17);
            this.searchBox.Location = new System.Drawing.Point(123, 106);
            this.searchBox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.searchBox.Name = "searchBox";
            this.searchBox.PasswordChar = '\0';
            this.searchBox.PlaceholderForeColor = System.Drawing.Color.Maroon;
            this.searchBox.PlaceholderText = "";
            this.searchBox.SelectedText = "";
            this.searchBox.Size = new System.Drawing.Size(291, 39);
            this.searchBox.TabIndex = 37;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(34, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 26);
            this.label5.TabIndex = 38;
            this.label5.Text = "Search";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Click += new System.EventHandler(this.label5_Click);
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
            this.roleField.Location = new System.Drawing.Point(32, 188);
            this.roleField.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.roleField.Name = "roleField";
            this.roleField.PasswordChar = '\0';
            this.roleField.PlaceholderForeColor = System.Drawing.Color.Maroon;
            this.roleField.PlaceholderText = "";
            this.roleField.SelectedText = "";
            this.roleField.Size = new System.Drawing.Size(199, 39);
            this.roleField.TabIndex = 30;
            this.roleField.Visible = false;
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
            this.passwordField.Location = new System.Drawing.Point(56, 500);
            this.passwordField.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.passwordField.Name = "passwordField";
            this.passwordField.PasswordChar = '\0';
            this.passwordField.PlaceholderForeColor = System.Drawing.Color.Maroon;
            this.passwordField.PlaceholderText = "";
            this.passwordField.SelectedText = "";
            this.passwordField.Size = new System.Drawing.Size(199, 39);
            this.passwordField.TabIndex = 28;
            this.passwordField.Visible = false;
            this.passwordField.TextChanged += new System.EventHandler(this.passwordField_TextChanged);
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
            this.usernameField.Location = new System.Drawing.Point(56, 448);
            this.usernameField.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.usernameField.Name = "usernameField";
            this.usernameField.PasswordChar = '\0';
            this.usernameField.PlaceholderForeColor = System.Drawing.Color.Maroon;
            this.usernameField.PlaceholderText = "";
            this.usernameField.SelectedText = "";
            this.usernameField.Size = new System.Drawing.Size(199, 39);
            this.usernameField.TabIndex = 23;
            this.usernameField.Visible = false;
            this.usernameField.TextChanged += new System.EventHandler(this.firstnameField_TextChanged);
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
            this.idField.Location = new System.Drawing.Point(56, 379);
            this.idField.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.idField.Name = "idField";
            this.idField.PasswordChar = '\0';
            this.idField.PlaceholderForeColor = System.Drawing.Color.Maroon;
            this.idField.PlaceholderText = "";
            this.idField.SelectedText = "";
            this.idField.Size = new System.Drawing.Size(40, 31);
            this.idField.TabIndex = 25;
            this.idField.Visible = false;
            this.idField.TextChanged += new System.EventHandler(this.idField_TextChanged);
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
            this.updateButton.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.ForeColor = System.Drawing.Color.White;
            this.updateButton.HoverState.FillColor = System.Drawing.Color.IndianRed;
            this.updateButton.Location = new System.Drawing.Point(323, 483);
            this.updateButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.updateButton.Name = "updateButton";
            this.updateButton.PressedColor = System.Drawing.Color.Transparent;
            this.updateButton.ShadowDecoration.Color = System.Drawing.Color.Transparent;
            this.updateButton.ShadowDecoration.Enabled = true;
            this.updateButton.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.updateButton.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(10);
            this.updateButton.Size = new System.Drawing.Size(175, 47);
            this.updateButton.TabIndex = 39;
            this.updateButton.Text = "Update Status";
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
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
            // AccountManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(835, 582);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.viewButton);
            this.Controls.Add(this.dataGridview);
            this.Controls.Add(this.roleField);
            this.Controls.Add(this.passwordField);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.idField);
            this.Controls.Add(this.usernameField);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AccountManagement";
            this.Text = "AccountManagement";
            this.Load += new System.EventHandler(this.AccountManagement_Load);
            this.Click += new System.EventHandler(this.AccountManagement_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersTableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridview;
        private usersTable usersTable;
        private System.Windows.Forms.BindingSource usersTableBindingSource;
        private usersTableTableAdapters.usersTableTableAdapter usersTableTableAdapter;
        private Guna.UI2.WinForms.Guna2Button viewButton;
        private Guna.UI2.WinForms.Guna2TextBox searchBox;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox roleField;
        private Guna.UI2.WinForms.Guna2TextBox passwordField;
        private Guna.UI2.WinForms.Guna2TextBox usernameField;
        private Guna.UI2.WinForms.Guna2TextBox idField;
        private Guna.UI2.WinForms.Guna2Button updateButton;
    }
}