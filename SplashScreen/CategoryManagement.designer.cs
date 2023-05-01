namespace SplashScreen
{
    partial class CategoryManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoryManagement));
            this.label1 = new System.Windows.Forms.Label();
            this.categoryName = new Guna.UI2.WinForms.Guna2TextBox();
            this.insertButton = new Guna.UI2.WinForms.Guna2Button();
            this.dataGridview = new Guna.UI2.WinForms.Guna2DataGridView();
            this.categoryNameLabel = new System.Windows.Forms.Label();
            this.updateButton = new Guna.UI2.WinForms.Guna2Button();
            this.deleteButton = new Guna.UI2.WinForms.Guna2Button();
            this.categoryId = new Guna.UI2.WinForms.Guna2TextBox();
            this.productIdLabel = new System.Windows.Forms.Label();
            this.viewButton = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridview)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Poppins", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(167, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(510, 70);
            this.label1.TabIndex = 28;
            this.label1.Text = "Category Management";
            // 
            // categoryName
            // 
            this.categoryName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.categoryName.BackColor = System.Drawing.Color.Transparent;
            this.categoryName.BorderColor = System.Drawing.Color.Maroon;
            this.categoryName.BorderRadius = 10;
            this.categoryName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.categoryName.DefaultText = "";
            this.categoryName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.categoryName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.categoryName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.categoryName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.categoryName.FocusedState.BorderColor = System.Drawing.Color.Maroon;
            this.categoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryName.ForeColor = System.Drawing.Color.Firebrick;
            this.categoryName.HoverState.BorderColor = System.Drawing.Color.Maroon;
            this.categoryName.HoverState.FillColor = System.Drawing.Color.AntiqueWhite;
            this.categoryName.IconLeftOffset = new System.Drawing.Point(7, 0);
            this.categoryName.IconLeftSize = new System.Drawing.Size(17, 17);
            this.categoryName.Location = new System.Drawing.Point(160, 173);
            this.categoryName.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.categoryName.Name = "categoryName";
            this.categoryName.PasswordChar = '\0';
            this.categoryName.PlaceholderForeColor = System.Drawing.Color.Maroon;
            this.categoryName.PlaceholderText = "";
            this.categoryName.SelectedText = "";
            this.categoryName.Size = new System.Drawing.Size(199, 39);
            this.categoryName.TabIndex = 29;
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
            this.insertButton.Location = new System.Drawing.Point(172, 240);
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(219)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(135)))), ((int)(((byte)(125)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridview.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridview.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridview.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(192)))), ((int)(((byte)(188)))));
            this.dataGridview.Location = new System.Drawing.Point(395, 103);
            this.dataGridview.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridview.Name = "dataGridview";
            this.dataGridview.RowHeadersVisible = false;
            this.dataGridview.RowHeadersWidth = 51;
            this.dataGridview.RowTemplate.Height = 24;
            this.dataGridview.Size = new System.Drawing.Size(411, 447);
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
            // categoryNameLabel
            // 
            this.categoryNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.categoryNameLabel.AutoSize = true;
            this.categoryNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.categoryNameLabel.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryNameLabel.ForeColor = System.Drawing.Color.Maroon;
            this.categoryNameLabel.Location = new System.Drawing.Point(33, 182);
            this.categoryNameLabel.Name = "categoryNameLabel";
            this.categoryNameLabel.Size = new System.Drawing.Size(123, 25);
            this.categoryNameLabel.TabIndex = 37;
            this.categoryNameLabel.Text = "Category Name";
            this.categoryNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.updateButton.Location = new System.Drawing.Point(172, 342);
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
            this.deleteButton.Location = new System.Drawing.Point(172, 394);
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
            // categoryId
            // 
            this.categoryId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.categoryId.BackColor = System.Drawing.Color.Transparent;
            this.categoryId.BorderColor = System.Drawing.Color.Maroon;
            this.categoryId.BorderRadius = 10;
            this.categoryId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.categoryId.DefaultText = "";
            this.categoryId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.categoryId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.categoryId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.categoryId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.categoryId.Enabled = false;
            this.categoryId.FocusedState.BorderColor = System.Drawing.Color.Maroon;
            this.categoryId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryId.ForeColor = System.Drawing.Color.Firebrick;
            this.categoryId.HoverState.BorderColor = System.Drawing.Color.Maroon;
            this.categoryId.HoverState.FillColor = System.Drawing.Color.AntiqueWhite;
            this.categoryId.IconLeftOffset = new System.Drawing.Point(7, 0);
            this.categoryId.IconLeftSize = new System.Drawing.Size(17, 17);
            this.categoryId.Location = new System.Drawing.Point(96, 17);
            this.categoryId.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.categoryId.Name = "categoryId";
            this.categoryId.PasswordChar = '\0';
            this.categoryId.PlaceholderForeColor = System.Drawing.Color.Maroon;
            this.categoryId.PlaceholderText = "";
            this.categoryId.SelectedText = "";
            this.categoryId.Size = new System.Drawing.Size(32, 39);
            this.categoryId.TabIndex = 29;
            this.categoryId.Visible = false;
            // 
            // productIdLabel
            // 
            this.productIdLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.productIdLabel.AutoSize = true;
            this.productIdLabel.BackColor = System.Drawing.Color.Transparent;
            this.productIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productIdLabel.ForeColor = System.Drawing.Color.Maroon;
            this.productIdLabel.Location = new System.Drawing.Point(15, 31);
            this.productIdLabel.Name = "productIdLabel";
            this.productIdLabel.Size = new System.Drawing.Size(80, 17);
            this.productIdLabel.TabIndex = 37;
            this.productIdLabel.Text = "Category Id";
            this.productIdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.productIdLabel.Visible = false;
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
            this.viewButton.Location = new System.Drawing.Point(172, 291);
            this.viewButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.viewButton.Name = "viewButton";
            this.viewButton.PressedColor = System.Drawing.Color.Transparent;
            this.viewButton.ShadowDecoration.Color = System.Drawing.Color.Transparent;
            this.viewButton.ShadowDecoration.Enabled = true;
            this.viewButton.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.viewButton.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(10);
            this.viewButton.Size = new System.Drawing.Size(175, 47);
            this.viewButton.TabIndex = 43;
            this.viewButton.Text = "View";
            // 
            // CategoryManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(835, 582);
            this.Controls.Add(this.viewButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.productIdLabel);
            this.Controls.Add(this.categoryNameLabel);
            this.Controls.Add(this.dataGridview);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.categoryId);
            this.Controls.Add(this.categoryName);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CategoryManagement";
            this.Text = "CategoryManagement";
            this.Load += new System.EventHandler(this.CategoryManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox categoryName;
        private Guna.UI2.WinForms.Guna2Button insertButton;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridview;
        private System.Windows.Forms.Label categoryNameLabel;
        private Guna.UI2.WinForms.Guna2Button updateButton;
        private Guna.UI2.WinForms.Guna2Button deleteButton;
        private Guna.UI2.WinForms.Guna2TextBox categoryId;
        private System.Windows.Forms.Label productIdLabel;
        private Guna.UI2.WinForms.Guna2Button viewButton;
    }
}