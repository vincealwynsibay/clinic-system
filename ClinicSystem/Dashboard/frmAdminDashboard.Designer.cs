namespace ClinicSystem
{
    partial class frmAdminDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminDashboard));
            this.pnlSecretary = new Bunifu.UI.WinForms.BunifuPanel();
            this.lblSecretaryCount = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblSecretary = new Bunifu.UI.WinForms.BunifuLabel();
            this.pnlPatients = new Bunifu.UI.WinForms.BunifuPanel();
            this.lblPatientsCount = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblPatients = new Bunifu.UI.WinForms.BunifuLabel();
            this.pnlDoctors = new Bunifu.UI.WinForms.BunifuPanel();
            this.lblDoctorCount = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblDoctor = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblReport = new Bunifu.UI.WinForms.BunifuLabel();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.pnlSecretary.SuspendLayout();
            this.pnlPatients.SuspendLayout();
            this.pnlDoctors.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSecretary
            // 
            this.pnlSecretary.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(251)))), ((int)(((byte)(250)))));
            this.pnlSecretary.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlSecretary.BackgroundImage")));
            this.pnlSecretary.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlSecretary.BorderColor = System.Drawing.Color.White;
            this.pnlSecretary.BorderRadius = 18;
            this.pnlSecretary.BorderThickness = 1;
            this.pnlSecretary.Controls.Add(this.lblSecretaryCount);
            this.pnlSecretary.Controls.Add(this.lblSecretary);
            this.pnlSecretary.Location = new System.Drawing.Point(392, 108);
            this.pnlSecretary.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlSecretary.Name = "pnlSecretary";
            this.pnlSecretary.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.pnlSecretary.ShowBorders = true;
            this.pnlSecretary.Size = new System.Drawing.Size(321, 196);
            this.pnlSecretary.TabIndex = 151;
            // 
            // lblSecretaryCount
            // 
            this.lblSecretaryCount.AllowParentOverrides = false;
            this.lblSecretaryCount.AutoEllipsis = false;
            this.lblSecretaryCount.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblSecretaryCount.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblSecretaryCount.Font = new System.Drawing.Font("IBM Plex Sans", 27.75F, System.Drawing.FontStyle.Bold);
            this.lblSecretaryCount.ForeColor = System.Drawing.Color.Black;
            this.lblSecretaryCount.Location = new System.Drawing.Point(40, 71);
            this.lblSecretaryCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblSecretaryCount.Name = "lblSecretaryCount";
            this.lblSecretaryCount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblSecretaryCount.Size = new System.Drawing.Size(266, 60);
            this.lblSecretaryCount.TabIndex = 144;
            this.lblSecretaryCount.Text = "SECRETARY";
            this.lblSecretaryCount.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSecretaryCount.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lblSecretary
            // 
            this.lblSecretary.AllowParentOverrides = false;
            this.lblSecretary.AutoEllipsis = false;
            this.lblSecretary.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblSecretary.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblSecretary.Font = new System.Drawing.Font("IBM Plex Sans", 14.25F);
            this.lblSecretary.ForeColor = System.Drawing.Color.Black;
            this.lblSecretary.Location = new System.Drawing.Point(39, 32);
            this.lblSecretary.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblSecretary.Name = "lblSecretary";
            this.lblSecretary.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblSecretary.Size = new System.Drawing.Size(183, 33);
            this.lblSecretary.TabIndex = 144;
            this.lblSecretary.Text = "Total Secretaries";
            this.lblSecretary.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSecretary.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // pnlPatients
            // 
            this.pnlPatients.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(230)))));
            this.pnlPatients.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlPatients.BackgroundImage")));
            this.pnlPatients.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlPatients.BorderColor = System.Drawing.Color.White;
            this.pnlPatients.BorderRadius = 18;
            this.pnlPatients.BorderThickness = 1;
            this.pnlPatients.Controls.Add(this.lblPatientsCount);
            this.pnlPatients.Controls.Add(this.lblPatients);
            this.pnlPatients.Location = new System.Drawing.Point(754, 108);
            this.pnlPatients.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlPatients.Name = "pnlPatients";
            this.pnlPatients.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.pnlPatients.ShowBorders = true;
            this.pnlPatients.Size = new System.Drawing.Size(321, 196);
            this.pnlPatients.TabIndex = 150;
            // 
            // lblPatientsCount
            // 
            this.lblPatientsCount.AllowParentOverrides = false;
            this.lblPatientsCount.AutoEllipsis = false;
            this.lblPatientsCount.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblPatientsCount.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblPatientsCount.Font = new System.Drawing.Font("IBM Plex Sans", 27.75F, System.Drawing.FontStyle.Bold);
            this.lblPatientsCount.ForeColor = System.Drawing.Color.Black;
            this.lblPatientsCount.Location = new System.Drawing.Point(40, 71);
            this.lblPatientsCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblPatientsCount.Name = "lblPatientsCount";
            this.lblPatientsCount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPatientsCount.Size = new System.Drawing.Size(93, 60);
            this.lblPatientsCount.TabIndex = 144;
            this.lblPatientsCount.Text = "PHP";
            this.lblPatientsCount.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPatientsCount.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lblPatients
            // 
            this.lblPatients.AllowParentOverrides = false;
            this.lblPatients.AutoEllipsis = false;
            this.lblPatients.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblPatients.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblPatients.Font = new System.Drawing.Font("IBM Plex Sans", 14.25F);
            this.lblPatients.ForeColor = System.Drawing.Color.Black;
            this.lblPatients.Location = new System.Drawing.Point(39, 32);
            this.lblPatients.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblPatients.Name = "lblPatients";
            this.lblPatients.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPatients.Size = new System.Drawing.Size(150, 33);
            this.lblPatients.TabIndex = 144;
            this.lblPatients.Text = "Total Patients";
            this.lblPatients.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPatients.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // pnlDoctors
            // 
            this.pnlDoctors.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.pnlDoctors.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlDoctors.BackgroundImage")));
            this.pnlDoctors.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlDoctors.BorderColor = System.Drawing.Color.White;
            this.pnlDoctors.BorderRadius = 18;
            this.pnlDoctors.BorderThickness = 1;
            this.pnlDoctors.Controls.Add(this.lblDoctorCount);
            this.pnlDoctors.Controls.Add(this.lblDoctor);
            this.pnlDoctors.Location = new System.Drawing.Point(30, 108);
            this.pnlDoctors.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlDoctors.Name = "pnlDoctors";
            this.pnlDoctors.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.pnlDoctors.ShowBorders = true;
            this.pnlDoctors.Size = new System.Drawing.Size(321, 196);
            this.pnlDoctors.TabIndex = 149;
            // 
            // lblDoctorCount
            // 
            this.lblDoctorCount.AllowParentOverrides = false;
            this.lblDoctorCount.AutoEllipsis = false;
            this.lblDoctorCount.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblDoctorCount.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblDoctorCount.Font = new System.Drawing.Font("IBM Plex Sans", 27.75F, System.Drawing.FontStyle.Bold);
            this.lblDoctorCount.ForeColor = System.Drawing.Color.Black;
            this.lblDoctorCount.Location = new System.Drawing.Point(40, 71);
            this.lblDoctorCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblDoctorCount.Name = "lblDoctorCount";
            this.lblDoctorCount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDoctorCount.Size = new System.Drawing.Size(186, 60);
            this.lblDoctorCount.TabIndex = 144;
            this.lblDoctorCount.Text = "DOCTOR";
            this.lblDoctorCount.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDoctorCount.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lblDoctor
            // 
            this.lblDoctor.AllowParentOverrides = false;
            this.lblDoctor.AutoEllipsis = false;
            this.lblDoctor.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblDoctor.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblDoctor.Font = new System.Drawing.Font("IBM Plex Sans", 14.25F);
            this.lblDoctor.ForeColor = System.Drawing.Color.Black;
            this.lblDoctor.Location = new System.Drawing.Point(39, 32);
            this.lblDoctor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblDoctor.Name = "lblDoctor";
            this.lblDoctor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDoctor.Size = new System.Drawing.Size(144, 33);
            this.lblDoctor.TabIndex = 144;
            this.lblDoctor.Text = "Total Doctors";
            this.lblDoctor.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDoctor.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lblReport
            // 
            this.lblReport.AllowParentOverrides = false;
            this.lblReport.AutoEllipsis = false;
            this.lblReport.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblReport.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblReport.Font = new System.Drawing.Font("IBM Plex Sans", 24F, System.Drawing.FontStyle.Bold);
            this.lblReport.ForeColor = System.Drawing.Color.Black;
            this.lblReport.Location = new System.Drawing.Point(30, 32);
            this.lblReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblReport.Name = "lblReport";
            this.lblReport.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblReport.Size = new System.Drawing.Size(127, 53);
            this.lblReport.TabIndex = 148;
            this.lblReport.Text = "Report";
            this.lblReport.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblReport.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.AnimateWindow = true;
            this.guna2BorderlessForm1.AnimationInterval = 80;
            this.guna2BorderlessForm1.BorderRadius = 12;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockForm = false;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.DragEndTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.DragForm = false;
            this.guna2BorderlessForm1.HasFormShadow = false;
            this.guna2BorderlessForm1.ResizeForm = false;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // frmAdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1105, 810);
            this.Controls.Add(this.pnlSecretary);
            this.Controls.Add(this.pnlPatients);
            this.Controls.Add(this.pnlDoctors);
            this.Controls.Add(this.lblReport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAdminDashboard";
            this.Text = "frmAdminDashboard";
            this.Load += new System.EventHandler(this.frmAdminDashboard_Load);
            this.pnlSecretary.ResumeLayout(false);
            this.pnlSecretary.PerformLayout();
            this.pnlPatients.ResumeLayout(false);
            this.pnlPatients.PerformLayout();
            this.pnlDoctors.ResumeLayout(false);
            this.pnlDoctors.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel pnlSecretary;
        private Bunifu.UI.WinForms.BunifuLabel lblSecretaryCount;
        private Bunifu.UI.WinForms.BunifuLabel lblSecretary;
        private Bunifu.UI.WinForms.BunifuPanel pnlPatients;
        private Bunifu.UI.WinForms.BunifuLabel lblPatientsCount;
        private Bunifu.UI.WinForms.BunifuLabel lblPatients;
        private Bunifu.UI.WinForms.BunifuPanel pnlDoctors;
        private Bunifu.UI.WinForms.BunifuLabel lblDoctorCount;
        private Bunifu.UI.WinForms.BunifuLabel lblDoctor;
        private Bunifu.UI.WinForms.BunifuLabel lblReport;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
    }
}