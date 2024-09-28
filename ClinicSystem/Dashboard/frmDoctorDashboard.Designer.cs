namespace ClinicSystem
{
    partial class frmDoctorDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDoctorDashboard));
            this.lblDoctorName = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblWelcome = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.picProfile = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDoctorName
            // 
            this.lblDoctorName.AllowParentOverrides = false;
            this.lblDoctorName.AutoEllipsis = false;
            this.lblDoctorName.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblDoctorName.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblDoctorName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblDoctorName.ForeColor = System.Drawing.Color.White;
            this.lblDoctorName.Location = new System.Drawing.Point(18, 42);
            this.lblDoctorName.Margin = new System.Windows.Forms.Padding(2);
            this.lblDoctorName.Name = "lblDoctorName";
            this.lblDoctorName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDoctorName.Size = new System.Drawing.Size(291, 37);
            this.lblDoctorName.TabIndex = 39;
            this.lblDoctorName.Text = "Dr. Harvey Solida, PhD";
            this.lblDoctorName.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDoctorName.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AllowParentOverrides = false;
            this.lblWelcome.AutoEllipsis = false;
            this.lblWelcome.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblWelcome.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.Location = new System.Drawing.Point(18, 22);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(2);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblWelcome.Size = new System.Drawing.Size(83, 21);
            this.lblWelcome.TabIndex = 40;
            this.lblWelcome.Text = "WELCOME,";
            this.lblWelcome.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblWelcome.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(75)))));
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 3;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.picProfile);
            this.bunifuPanel1.Controls.Add(this.lblDoctorName);
            this.bunifuPanel1.Controls.Add(this.lblWelcome);
            this.bunifuPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(1006, 100);
            this.bunifuPanel1.TabIndex = 42;
            // 
            // picProfile
            // 
            this.picProfile.AllowFocused = false;
            this.picProfile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picProfile.AutoSizeHeight = true;
            this.picProfile.BorderRadius = 36;
            this.picProfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picProfile.Image = ((System.Drawing.Image)(resources.GetObject("picProfile.Image")));
            this.picProfile.IsCircle = true;
            this.picProfile.Location = new System.Drawing.Point(918, 12);
            this.picProfile.Margin = new System.Windows.Forms.Padding(2);
            this.picProfile.Name = "picProfile";
            this.picProfile.Size = new System.Drawing.Size(73, 73);
            this.picProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picProfile.TabIndex = 55;
            this.picProfile.TabStop = false;
            this.picProfile.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Hand;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(75)))));
            this.bunifuLabel1.Location = new System.Drawing.Point(11, 105);
            this.bunifuLabel1.Margin = new System.Windows.Forms.Padding(2);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(352, 45);
            this.bunifuLabel1.TabIndex = 43;
            this.bunifuLabel1.Text = "Appointments Today: 3";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // frmDoctorDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1006, 829);
            this.Controls.Add(this.bunifuLabel1);
            this.Controls.Add(this.bunifuPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmDoctorDashboard";
            this.Text = "frmDoctorDashboard";
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuLabel lblDoctorName;
        private Bunifu.UI.WinForms.BunifuLabel lblWelcome;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private Bunifu.UI.WinForms.BunifuPictureBox picProfile;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
    }
}