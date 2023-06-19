namespace SplashScreen
{
    partial class CashierManagement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashierManagement));
            this.label1 = new System.Windows.Forms.Label();
            this.contactNum = new Guna.UI2.WinForms.Guna2TextBox();
            this.insertButton = new Guna.UI2.WinForms.Guna2Button();
            this.dataGridview = new Guna.UI2.WinForms.Guna2DataGridView();
            this.cashierNameLabel = new System.Windows.Forms.Label();
            this.updateButton = new Guna.UI2.WinForms.Guna2Button();
            this.deleteButton = new Guna.UI2.WinForms.Guna2Button();
            this.cashierId = new Guna.UI2.WinForms.Guna2TextBox();
            this.cashierIdLabel = new System.Windows.Forms.Label();
            this.viewDetailsButton = new Guna.UI2.WinForms.Guna2Button();
            this.label5 = new System.Windows.Forms.Label();
            this.searchBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lastName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.salary = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.firstName = new Guna.UI2.WinForms.Guna2TextBox();
            this.dateHired = new Guna.UI2.WinForms.Guna2TextBox();
            this.birthday = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridview)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Poppins", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(167, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(478, 70);
            this.label1.TabIndex = 28;
            this.label1.Text = "Cashier Management";
            // 
            // contactNum
            // 
            this.contactNum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.contactNum.BackColor = System.Drawing.Color.Transparent;
            this.contactNum.BorderColor = System.Drawing.Color.Maroon;
            this.contactNum.BorderRadius = 10;
            this.contactNum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.contactNum.DefaultText = "";
            this.contactNum.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.contactNum.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.contactNum.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.contactNum.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.contactNum.FocusedState.BorderColor = System.Drawing.Color.Maroon;
            this.contactNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactNum.ForeColor = System.Drawing.Color.Firebrick;
            this.contactNum.HoverState.BorderColor = System.Drawing.Color.Maroon;
            this.contactNum.HoverState.FillColor = System.Drawing.Color.AntiqueWhite;
            this.contactNum.IconLeftOffset = new System.Drawing.Point(7, 0);
            this.contactNum.IconLeftSize = new System.Drawing.Size(17, 17);
            this.contactNum.Location = new System.Drawing.Point(163, 239);
            this.contactNum.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.contactNum.Name = "contactNum";
            this.contactNum.PasswordChar = '\0';
            this.contactNum.PlaceholderForeColor = System.Drawing.Color.Maroon;
            this.contactNum.PlaceholderText = "";
            this.contactNum.SelectedText = "";
            this.contactNum.Size = new System.Drawing.Size(199, 39);
            this.contactNum.TabIndex = 29;
            this.contactNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.contactNum_KeyPress);
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
            this.insertButton.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertButton.ForeColor = System.Drawing.Color.White;
            this.insertButton.HoverState.FillColor = System.Drawing.Color.IndianRed;
            this.insertButton.Location = new System.Drawing.Point(21, 453);
            this.insertButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.insertButton.Name = "insertButton";
            this.insertButton.PressedColor = System.Drawing.Color.Transparent;
            this.insertButton.ShadowDecoration.Color = System.Drawing.Color.Transparent;
            this.insertButton.ShadowDecoration.Enabled = true;
            this.insertButton.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.insertButton.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(10);
            this.insertButton.Size = new System.Drawing.Size(175, 47);
            this.insertButton.TabIndex = 34;
            this.insertButton.Text = "Insert";
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // dataGridview
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(201)))), ((int)(((byte)(197)))));
            this.dataGridview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridview.ColumnHeadersHeight = 19;
            this.dataGridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(219)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(135)))), ((int)(((byte)(125)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridview.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridview.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridview.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(192)))), ((int)(((byte)(188)))));
            this.dataGridview.Location = new System.Drawing.Point(381, 198);
            this.dataGridview.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridview.Name = "dataGridview";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridview.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridview.RowHeadersVisible = false;
            this.dataGridview.RowHeadersWidth = 51;
            this.dataGridview.RowTemplate.Height = 24;
            this.dataGridview.Size = new System.Drawing.Size(424, 352);
            this.dataGridview.TabIndex = 35;
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
            // cashierNameLabel
            // 
            this.cashierNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cashierNameLabel.AutoSize = true;
            this.cashierNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.cashierNameLabel.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierNameLabel.ForeColor = System.Drawing.Color.Maroon;
            this.cashierNameLabel.Location = new System.Drawing.Point(36, 247);
            this.cashierNameLabel.Name = "cashierNameLabel";
            this.cashierNameLabel.Size = new System.Drawing.Size(94, 25);
            this.cashierNameLabel.TabIndex = 37;
            this.cashierNameLabel.Text = "Contact No.";
            this.cashierNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.updateButton.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.ForeColor = System.Drawing.Color.White;
            this.updateButton.HoverState.FillColor = System.Drawing.Color.IndianRed;
            this.updateButton.Location = new System.Drawing.Point(201, 452);
            this.updateButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.updateButton.Name = "updateButton";
            this.updateButton.PressedColor = System.Drawing.Color.Transparent;
            this.updateButton.ShadowDecoration.Color = System.Drawing.Color.Transparent;
            this.updateButton.ShadowDecoration.Enabled = true;
            this.updateButton.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.updateButton.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(10);
            this.updateButton.Size = new System.Drawing.Size(175, 47);
            this.updateButton.TabIndex = 39;
            this.updateButton.Text = "Update";
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
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
            this.deleteButton.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.Color.White;
            this.deleteButton.HoverState.FillColor = System.Drawing.Color.IndianRed;
            this.deleteButton.Location = new System.Drawing.Point(201, 503);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.PressedColor = System.Drawing.Color.Transparent;
            this.deleteButton.ShadowDecoration.Color = System.Drawing.Color.Transparent;
            this.deleteButton.ShadowDecoration.Enabled = true;
            this.deleteButton.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.deleteButton.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(10);
            this.deleteButton.Size = new System.Drawing.Size(175, 47);
            this.deleteButton.TabIndex = 40;
            this.deleteButton.Text = "Delete";
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // cashierId
            // 
            this.cashierId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cashierId.BackColor = System.Drawing.Color.Transparent;
            this.cashierId.BorderColor = System.Drawing.Color.Maroon;
            this.cashierId.BorderRadius = 10;
            this.cashierId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cashierId.DefaultText = "";
            this.cashierId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.cashierId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.cashierId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.cashierId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.cashierId.Enabled = false;
            this.cashierId.FocusedState.BorderColor = System.Drawing.Color.Maroon;
            this.cashierId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierId.ForeColor = System.Drawing.Color.Firebrick;
            this.cashierId.HoverState.BorderColor = System.Drawing.Color.Maroon;
            this.cashierId.HoverState.FillColor = System.Drawing.Color.AntiqueWhite;
            this.cashierId.IconLeftOffset = new System.Drawing.Point(7, 0);
            this.cashierId.IconLeftSize = new System.Drawing.Size(17, 17);
            this.cashierId.Location = new System.Drawing.Point(96, 17);
            this.cashierId.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.cashierId.Name = "cashierId";
            this.cashierId.PasswordChar = '\0';
            this.cashierId.PlaceholderForeColor = System.Drawing.Color.Maroon;
            this.cashierId.PlaceholderText = "";
            this.cashierId.SelectedText = "";
            this.cashierId.Size = new System.Drawing.Size(32, 39);
            this.cashierId.TabIndex = 29;
            this.cashierId.Visible = false;
            // 
            // cashierIdLabel
            // 
            this.cashierIdLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cashierIdLabel.AutoSize = true;
            this.cashierIdLabel.BackColor = System.Drawing.Color.Transparent;
            this.cashierIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierIdLabel.ForeColor = System.Drawing.Color.Maroon;
            this.cashierIdLabel.Location = new System.Drawing.Point(15, 31);
            this.cashierIdLabel.Name = "cashierIdLabel";
            this.cashierIdLabel.Size = new System.Drawing.Size(80, 17);
            this.cashierIdLabel.TabIndex = 37;
            this.cashierIdLabel.Text = "Category Id";
            this.cashierIdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cashierIdLabel.Visible = false;
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
            this.viewDetailsButton.Location = new System.Drawing.Point(21, 503);
            this.viewDetailsButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.viewDetailsButton.Name = "viewDetailsButton";
            this.viewDetailsButton.PressedColor = System.Drawing.Color.Transparent;
            this.viewDetailsButton.ShadowDecoration.Color = System.Drawing.Color.Transparent;
            this.viewDetailsButton.ShadowDecoration.Enabled = true;
            this.viewDetailsButton.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.viewDetailsButton.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(10);
            this.viewDetailsButton.Size = new System.Drawing.Size(175, 47);
            this.viewDetailsButton.TabIndex = 43;
            this.viewDetailsButton.Text = "View";
            this.viewDetailsButton.Click += new System.EventHandler(this.viewDetailsButton_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(395, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 26);
            this.label5.TabIndex = 45;
            this.label5.Text = "Search";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.searchBox.Location = new System.Drawing.Point(481, 126);
            this.searchBox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.searchBox.Name = "searchBox";
            this.searchBox.PasswordChar = '\0';
            this.searchBox.PlaceholderForeColor = System.Drawing.Color.Maroon;
            this.searchBox.PlaceholderText = "";
            this.searchBox.SelectedText = "";
            this.searchBox.Size = new System.Drawing.Size(325, 39);
            this.searchBox.TabIndex = 44;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(36, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 25);
            this.label2.TabIndex = 47;
            this.label2.Text = "Last Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lastName
            // 
            this.lastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lastName.BackColor = System.Drawing.Color.Transparent;
            this.lastName.BorderColor = System.Drawing.Color.Maroon;
            this.lastName.BorderRadius = 10;
            this.lastName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lastName.DefaultText = "";
            this.lastName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.lastName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.lastName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.lastName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.lastName.FocusedState.BorderColor = System.Drawing.Color.Maroon;
            this.lastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastName.ForeColor = System.Drawing.Color.Firebrick;
            this.lastName.HoverState.BorderColor = System.Drawing.Color.Maroon;
            this.lastName.HoverState.FillColor = System.Drawing.Color.AntiqueWhite;
            this.lastName.IconLeftOffset = new System.Drawing.Point(7, 0);
            this.lastName.IconLeftSize = new System.Drawing.Size(17, 17);
            this.lastName.Location = new System.Drawing.Point(163, 188);
            this.lastName.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.lastName.Name = "lastName";
            this.lastName.PasswordChar = '\0';
            this.lastName.PlaceholderForeColor = System.Drawing.Color.Maroon;
            this.lastName.PlaceholderText = "";
            this.lastName.SelectedText = "";
            this.lastName.Size = new System.Drawing.Size(199, 39);
            this.lastName.TabIndex = 46;
            this.lastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lastName_KeyPress);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(37, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 25);
            this.label3.TabIndex = 49;
            this.label3.Text = "Birthday";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(36, 347);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 25);
            this.label4.TabIndex = 51;
            this.label4.Text = "Date Hired";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(36, 402);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 25);
            this.label6.TabIndex = 53;
            this.label6.Text = "Salary";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // salary
            // 
            this.salary.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.salary.BackColor = System.Drawing.Color.Transparent;
            this.salary.BorderColor = System.Drawing.Color.Maroon;
            this.salary.BorderRadius = 10;
            this.salary.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.salary.DefaultText = "";
            this.salary.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.salary.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.salary.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.salary.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.salary.FocusedState.BorderColor = System.Drawing.Color.Maroon;
            this.salary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salary.ForeColor = System.Drawing.Color.Firebrick;
            this.salary.HoverState.BorderColor = System.Drawing.Color.Maroon;
            this.salary.HoverState.FillColor = System.Drawing.Color.AntiqueWhite;
            this.salary.IconLeftOffset = new System.Drawing.Point(7, 0);
            this.salary.IconLeftSize = new System.Drawing.Size(17, 17);
            this.salary.Location = new System.Drawing.Point(163, 394);
            this.salary.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.salary.Name = "salary";
            this.salary.PasswordChar = '\0';
            this.salary.PlaceholderForeColor = System.Drawing.Color.Maroon;
            this.salary.PlaceholderText = "";
            this.salary.SelectedText = "";
            this.salary.Size = new System.Drawing.Size(199, 39);
            this.salary.TabIndex = 52;
            this.salary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.salary_KeyPress);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Maroon;
            this.label8.Location = new System.Drawing.Point(36, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 25);
            this.label8.TabIndex = 57;
            this.label8.Text = "First Name";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // firstName
            // 
            this.firstName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.firstName.BackColor = System.Drawing.Color.Transparent;
            this.firstName.BorderColor = System.Drawing.Color.Maroon;
            this.firstName.BorderRadius = 10;
            this.firstName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.firstName.DefaultText = "";
            this.firstName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.firstName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.firstName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.firstName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.firstName.FocusedState.BorderColor = System.Drawing.Color.Maroon;
            this.firstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstName.ForeColor = System.Drawing.Color.Firebrick;
            this.firstName.HoverState.BorderColor = System.Drawing.Color.Maroon;
            this.firstName.HoverState.FillColor = System.Drawing.Color.AntiqueWhite;
            this.firstName.IconLeftOffset = new System.Drawing.Point(7, 0);
            this.firstName.IconLeftSize = new System.Drawing.Size(17, 17);
            this.firstName.Location = new System.Drawing.Point(163, 142);
            this.firstName.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.firstName.Name = "firstName";
            this.firstName.PasswordChar = '\0';
            this.firstName.PlaceholderForeColor = System.Drawing.Color.Maroon;
            this.firstName.PlaceholderText = "";
            this.firstName.SelectedText = "";
            this.firstName.Size = new System.Drawing.Size(199, 39);
            this.firstName.TabIndex = 56;
            this.firstName.TextChanged += new System.EventHandler(this.firstName_TextChanged);
            this.firstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.firstName_KeyPress);
            // 
            // dateHired
            // 
            this.dateHired.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateHired.BackColor = System.Drawing.Color.Transparent;
            this.dateHired.BorderColor = System.Drawing.Color.Maroon;
            this.dateHired.BorderRadius = 10;
            this.dateHired.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.dateHired.DefaultText = "";
            this.dateHired.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.dateHired.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.dateHired.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.dateHired.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.dateHired.FocusedState.BorderColor = System.Drawing.Color.Maroon;
            this.dateHired.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateHired.ForeColor = System.Drawing.Color.Firebrick;
            this.dateHired.HoverState.BorderColor = System.Drawing.Color.Maroon;
            this.dateHired.HoverState.FillColor = System.Drawing.Color.AntiqueWhite;
            this.dateHired.IconLeftOffset = new System.Drawing.Point(7, 0);
            this.dateHired.IconLeftSize = new System.Drawing.Size(17, 17);
            this.dateHired.Location = new System.Drawing.Point(163, 342);
            this.dateHired.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.dateHired.Name = "dateHired";
            this.dateHired.PasswordChar = '\0';
            this.dateHired.PlaceholderForeColor = System.Drawing.Color.Maroon;
            this.dateHired.PlaceholderText = "";
            this.dateHired.SelectedText = "";
            this.dateHired.Size = new System.Drawing.Size(199, 39);
            this.dateHired.TabIndex = 58;
            // 
            // birthday
            // 
            this.birthday.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.birthday.BackColor = System.Drawing.Color.Transparent;
            this.birthday.BorderColor = System.Drawing.Color.Maroon;
            this.birthday.BorderRadius = 10;
            this.birthday.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.birthday.DefaultText = "";
            this.birthday.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.birthday.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.birthday.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.birthday.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.birthday.FocusedState.BorderColor = System.Drawing.Color.Maroon;
            this.birthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthday.ForeColor = System.Drawing.Color.Firebrick;
            this.birthday.HoverState.BorderColor = System.Drawing.Color.Maroon;
            this.birthday.HoverState.FillColor = System.Drawing.Color.AntiqueWhite;
            this.birthday.IconLeftOffset = new System.Drawing.Point(7, 0);
            this.birthday.IconLeftSize = new System.Drawing.Size(17, 17);
            this.birthday.Location = new System.Drawing.Point(163, 291);
            this.birthday.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.birthday.Name = "birthday";
            this.birthday.PasswordChar = '\0';
            this.birthday.PlaceholderForeColor = System.Drawing.Color.Maroon;
            this.birthday.PlaceholderText = "";
            this.birthday.SelectedText = "";
            this.birthday.Size = new System.Drawing.Size(199, 39);
            this.birthday.TabIndex = 59;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Poppins", 4.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(38, 315);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 16);
            this.label7.TabIndex = 60;
            this.label7.Text = "(mm/dd/yyyy)";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Poppins", 4.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Maroon;
            this.label9.Location = new System.Drawing.Point(39, 366);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 16);
            this.label9.TabIndex = 61;
            this.label9.Text = "(mm/dd/yyyy)";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CashierManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(835, 582);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.birthday);
            this.Controls.Add(this.dateHired);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.salary);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.viewDetailsButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.cashierIdLabel);
            this.Controls.Add(this.cashierNameLabel);
            this.Controls.Add(this.dataGridview);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.cashierId);
            this.Controls.Add(this.contactNum);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CashierManagement";
            this.Text = "CategoryManagement";
            this.Load += new System.EventHandler(this.CashierManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox contactNum;
        private Guna.UI2.WinForms.Guna2Button insertButton;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridview;
        private System.Windows.Forms.Label cashierNameLabel;
        private Guna.UI2.WinForms.Guna2Button updateButton;
        private Guna.UI2.WinForms.Guna2Button deleteButton;
        private Guna.UI2.WinForms.Guna2TextBox cashierId;
        private System.Windows.Forms.Label cashierIdLabel;
        private Guna.UI2.WinForms.Guna2Button viewDetailsButton;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox searchBox;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox lastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox salary;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox firstName;
        private Guna.UI2.WinForms.Guna2TextBox dateHired;
        private Guna.UI2.WinForms.Guna2TextBox birthday;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
    }
}