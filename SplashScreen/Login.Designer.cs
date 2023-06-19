
namespace SplashScreen
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pageTitle = new System.Windows.Forms.Label();
            this.usernameField = new Guna.UI2.WinForms.Guna2TextBox();
            this.passwordField = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.maximizeButton = new Guna.UI2.WinForms.Guna2ControlBox();
            this.minimizeButton = new Guna.UI2.WinForms.Guna2ControlBox();
            this.closeButton = new Guna.UI2.WinForms.Guna2ControlBox();
            this.login = new Guna.UI2.WinForms.Guna2Button();
            this.sampleDatabaseDataSet = new SplashScreenLadera.sampleDatabaseDataSet();
            this.sampleDatabaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idField = new Guna.UI2.WinForms.Guna2TextBox();
            this.gridView = new System.Windows.Forms.DataGridView();
            this.searchBox = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sampleDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sampleDatabaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(984, 654);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pageTitle
            // 
            this.pageTitle.AutoSize = true;
            this.pageTitle.BackColor = System.Drawing.Color.Transparent;
            this.pageTitle.Font = new System.Drawing.Font("Poppins Black", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageTitle.ForeColor = System.Drawing.Color.Firebrick;
            this.pageTitle.Location = new System.Drawing.Point(149, 23);
            this.pageTitle.Name = "pageTitle";
            this.pageTitle.Size = new System.Drawing.Size(0, 58);
            this.pageTitle.TabIndex = 1;
            this.pageTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.usernameField.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameField.ForeColor = System.Drawing.Color.Firebrick;
            this.usernameField.HoverState.BorderColor = System.Drawing.Color.Maroon;
            this.usernameField.HoverState.FillColor = System.Drawing.Color.AntiqueWhite;
            this.usernameField.IconLeft = ((System.Drawing.Image)(resources.GetObject("usernameField.IconLeft")));
            this.usernameField.IconLeftOffset = new System.Drawing.Point(7, 0);
            this.usernameField.IconLeftSize = new System.Drawing.Size(17, 17);
            this.usernameField.Location = new System.Drawing.Point(83, 264);
            this.usernameField.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.usernameField.Name = "usernameField";
            this.usernameField.PasswordChar = '\0';
            this.usernameField.PlaceholderForeColor = System.Drawing.Color.Maroon;
            this.usernameField.PlaceholderText = "";
            this.usernameField.SelectedText = "";
            this.usernameField.Size = new System.Drawing.Size(329, 63);
            this.usernameField.TabIndex = 3;
            this.usernameField.TextChanged += new System.EventHandler(this.usernameField_TextChanged);
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
            this.passwordField.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordField.ForeColor = System.Drawing.Color.Firebrick;
            this.passwordField.HoverState.BorderColor = System.Drawing.Color.Maroon;
            this.passwordField.HoverState.FillColor = System.Drawing.Color.AntiqueWhite;
            this.passwordField.IconLeft = ((System.Drawing.Image)(resources.GetObject("passwordField.IconLeft")));
            this.passwordField.IconLeftOffset = new System.Drawing.Point(7, 0);
            this.passwordField.IconLeftSize = new System.Drawing.Size(19, 17);
            this.passwordField.Location = new System.Drawing.Point(83, 373);
            this.passwordField.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.passwordField.Name = "passwordField";
            this.passwordField.PasswordChar = '\0';
            this.passwordField.PlaceholderForeColor = System.Drawing.Color.Maroon;
            this.passwordField.PlaceholderText = "";
            this.passwordField.SelectedText = "";
            this.passwordField.Size = new System.Drawing.Size(329, 63);
            this.passwordField.TabIndex = 4;
            this.passwordField.TextChanged += new System.EventHandler(this.passwordField_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(89, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Username";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(89, 344);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // maximizeButton
            // 
            this.maximizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximizeButton.BackColor = System.Drawing.Color.Transparent;
            this.maximizeButton.BorderColor = System.Drawing.Color.Transparent;
            this.maximizeButton.BorderRadius = 2;
            this.maximizeButton.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.maximizeButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.maximizeButton.CustomIconSize = 8F;
            this.maximizeButton.FillColor = System.Drawing.Color.Transparent;
            this.maximizeButton.HoverState.FillColor = System.Drawing.Color.White;
            this.maximizeButton.HoverState.IconColor = System.Drawing.Color.Red;
            this.maximizeButton.IconColor = System.Drawing.Color.Maroon;
            this.maximizeButton.Location = new System.Drawing.Point(927, 8);
            this.maximizeButton.Name = "maximizeButton";
            this.maximizeButton.PressedColor = System.Drawing.Color.Red;
            this.maximizeButton.Size = new System.Drawing.Size(21, 17);
            this.maximizeButton.TabIndex = 10;
            this.maximizeButton.Click += new System.EventHandler(this.maximizeButton_Click);
            // 
            // minimizeButton
            // 
            this.minimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeButton.BackColor = System.Drawing.Color.Transparent;
            this.minimizeButton.BorderColor = System.Drawing.Color.Transparent;
            this.minimizeButton.BorderRadius = 2;
            this.minimizeButton.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.minimizeButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.minimizeButton.CustomIconSize = 8F;
            this.minimizeButton.FillColor = System.Drawing.Color.Transparent;
            this.minimizeButton.HoverState.FillColor = System.Drawing.Color.White;
            this.minimizeButton.HoverState.IconColor = System.Drawing.Color.Red;
            this.minimizeButton.IconColor = System.Drawing.Color.Maroon;
            this.minimizeButton.Location = new System.Drawing.Point(899, 8);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.PressedColor = System.Drawing.Color.Red;
            this.minimizeButton.Size = new System.Drawing.Size(21, 17);
            this.minimizeButton.TabIndex = 9;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.BackColor = System.Drawing.Color.Transparent;
            this.closeButton.BorderColor = System.Drawing.Color.Transparent;
            this.closeButton.BorderRadius = 2;
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.closeButton.CustomIconSize = 8F;
            this.closeButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.closeButton.HoverState.FillColor = System.Drawing.Color.White;
            this.closeButton.HoverState.IconColor = System.Drawing.Color.Red;
            this.closeButton.IconColor = System.Drawing.Color.White;
            this.closeButton.Location = new System.Drawing.Point(953, 8);
            this.closeButton.Name = "closeButton";
            this.closeButton.PressedColor = System.Drawing.Color.Red;
            this.closeButton.Size = new System.Drawing.Size(21, 17);
            this.closeButton.TabIndex = 8;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // login
            // 
            this.login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.login.BackColor = System.Drawing.Color.Transparent;
            this.login.BorderRadius = 10;
            this.login.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.login.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.login.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.login.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.login.FillColor = System.Drawing.Color.Maroon;
            this.login.Font = new System.Drawing.Font("Poppins", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.ForeColor = System.Drawing.Color.White;
            this.login.HoverState.FillColor = System.Drawing.Color.IndianRed;
            this.login.Location = new System.Drawing.Point(169, 466);
            this.login.Name = "login";
            this.login.ShadowDecoration.Enabled = true;
            this.login.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.login.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(10);
            this.login.Size = new System.Drawing.Size(154, 45);
            this.login.TabIndex = 14;
            this.login.Text = "LOGIN";
            this.login.Click += new System.EventHandler(this.guna2Button1_Click_1);
            // 
            // sampleDatabaseDataSet
            // 
            this.sampleDatabaseDataSet.DataSetName = "sampleDatabaseDataSet";
            this.sampleDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sampleDatabaseDataSetBindingSource
            // 
            this.sampleDatabaseDataSetBindingSource.DataSource = this.sampleDatabaseDataSet;
            this.sampleDatabaseDataSetBindingSource.Position = 0;
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
            this.idField.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idField.ForeColor = System.Drawing.Color.Firebrick;
            this.idField.HoverState.BorderColor = System.Drawing.Color.Maroon;
            this.idField.HoverState.FillColor = System.Drawing.Color.AntiqueWhite;
            this.idField.IconLeft = ((System.Drawing.Image)(resources.GetObject("idField.IconLeft")));
            this.idField.IconLeftOffset = new System.Drawing.Point(7, 0);
            this.idField.IconLeftSize = new System.Drawing.Size(17, 17);
            this.idField.Location = new System.Drawing.Point(445, 18);
            this.idField.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.idField.Name = "idField";
            this.idField.PasswordChar = '\0';
            this.idField.PlaceholderForeColor = System.Drawing.Color.Maroon;
            this.idField.PlaceholderText = "";
            this.idField.SelectedText = "";
            this.idField.Size = new System.Drawing.Size(93, 63);
            this.idField.TabIndex = 15;
            this.idField.Visible = false;
            // 
            // gridView
            // 
            this.gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridView.Location = new System.Drawing.Point(734, 492);
            this.gridView.Name = "gridView";
            this.gridView.RowHeadersWidth = 51;
            this.gridView.RowTemplate.Height = 24;
            this.gridView.Size = new System.Drawing.Size(240, 150);
            this.gridView.TabIndex = 16;
            this.gridView.Visible = false;
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
            this.searchBox.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.ForeColor = System.Drawing.Color.Firebrick;
            this.searchBox.HoverState.BorderColor = System.Drawing.Color.Maroon;
            this.searchBox.HoverState.FillColor = System.Drawing.Color.AntiqueWhite;
            this.searchBox.IconLeft = ((System.Drawing.Image)(resources.GetObject("searchBox.IconLeft")));
            this.searchBox.IconLeftOffset = new System.Drawing.Point(7, 0);
            this.searchBox.IconLeftSize = new System.Drawing.Size(17, 17);
            this.searchBox.Location = new System.Drawing.Point(445, 93);
            this.searchBox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.searchBox.Name = "searchBox";
            this.searchBox.PasswordChar = '\0';
            this.searchBox.PlaceholderForeColor = System.Drawing.Color.Maroon;
            this.searchBox.PlaceholderText = "";
            this.searchBox.SelectedText = "";
            this.searchBox.Size = new System.Drawing.Size(93, 63);
            this.searchBox.TabIndex = 17;
            this.searchBox.Visible = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 654);
            this.ControlBox = false;
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.gridView);
            this.Controls.Add(this.idField);
            this.Controls.Add(this.login);
            this.Controls.Add(this.maximizeButton);
            this.Controls.Add(this.minimizeButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordField);
            this.Controls.Add(this.usernameField);
            this.Controls.Add(this.pageTitle);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sampleDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sampleDatabaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label pageTitle;
        private Guna.UI2.WinForms.Guna2TextBox usernameField;
        private Guna.UI2.WinForms.Guna2TextBox passwordField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ControlBox maximizeButton;
        private Guna.UI2.WinForms.Guna2ControlBox minimizeButton;
        private Guna.UI2.WinForms.Guna2ControlBox closeButton;
        private Guna.UI2.WinForms.Guna2Button login;
        private System.Windows.Forms.BindingSource sampleDatabaseDataSetBindingSource;
        private SplashScreenLadera.sampleDatabaseDataSet sampleDatabaseDataSet;
        private Guna.UI2.WinForms.Guna2TextBox idField;
        private System.Windows.Forms.DataGridView gridView;
        private Guna.UI2.WinForms.Guna2TextBox searchBox;
    }
}