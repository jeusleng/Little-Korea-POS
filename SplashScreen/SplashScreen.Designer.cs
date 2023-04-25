
namespace SplashScreen
{
    partial class FrmSplash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSplash));
            this.progressBarTimer = new System.Windows.Forms.Timer(this.components);
            this.guna2ProgressBar1 = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.SuspendLayout();
            // 
            // progressBarTimer
            // 
            this.progressBarTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // guna2ProgressBar1
            // 
            this.guna2ProgressBar1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.guna2ProgressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ProgressBar1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ProgressBar1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.guna2ProgressBar1.BorderColor = System.Drawing.Color.Transparent;
            this.guna2ProgressBar1.BorderRadius = 20;
            this.guna2ProgressBar1.CausesValidation = false;
            this.guna2ProgressBar1.Cursor = System.Windows.Forms.Cursors.Default;
            this.guna2ProgressBar1.CustomizableEdges.BottomLeft = false;
            this.guna2ProgressBar1.CustomizableEdges.BottomRight = false;
            this.guna2ProgressBar1.CustomizableEdges.TopLeft = false;
            this.guna2ProgressBar1.CustomizableEdges.TopRight = false;
            this.guna2ProgressBar1.FillColor = System.Drawing.Color.White;
            this.guna2ProgressBar1.ForeColor = System.Drawing.Color.Transparent;
            this.guna2ProgressBar1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.guna2ProgressBar1.Location = new System.Drawing.Point(397, 326);
            this.guna2ProgressBar1.Maximum = 170;
            this.guna2ProgressBar1.Name = "guna2ProgressBar1";
            this.guna2ProgressBar1.ProgressColor = System.Drawing.Color.Red;
            this.guna2ProgressBar1.ProgressColor2 = System.Drawing.Color.White;
            this.guna2ProgressBar1.ShadowDecoration.BorderRadius = 0;
            this.guna2ProgressBar1.ShadowDecoration.Color = System.Drawing.Color.Transparent;
            this.guna2ProgressBar1.ShadowDecoration.Enabled = true;
            this.guna2ProgressBar1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2ProgressBar1.Size = new System.Drawing.Size(145, 10);
            this.guna2ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.guna2ProgressBar1.TabIndex = 0;
            this.guna2ProgressBar1.Text = "guna2ProgressBar1";
            this.guna2ProgressBar1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.guna2ProgressBar1.ValueChanged += new System.EventHandler(this.guna2ProgressBar1_ValueChanged);
            // 
            // FrmSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(942, 441);
            this.ControlBox = false;
            this.Controls.Add(this.guna2ProgressBar1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmSplash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.SystemColors.Desktop;
            this.Load += new System.EventHandler(this.FrmSplash_Load);
            this.DockChanged += new System.EventHandler(this.FrmSplash_DockChanged);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmSplash_MouseDown);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer progressBarTimer;
        private Guna.UI2.WinForms.Guna2ProgressBar guna2ProgressBar1;
    }
}

