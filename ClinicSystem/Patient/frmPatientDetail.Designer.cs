namespace ClinicSystem
{
    partial class frmPatientDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPatientDetail));
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.lblName = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblTitleBirthdate = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblBirthdate = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblGender = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblEmail = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel4 = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblMobileNo = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel6 = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblEmergencyNo = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel8 = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblMaritalStat = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel10 = new Bunifu.UI.WinForms.BunifuLabel();
            this.btnEditPatient = new Guna.UI2.WinForms.Guna2Button();
            this.lblDiagnosis = new Bunifu.UI.WinForms.BunifuLabel();
            this.pnlDiagnosis = new Bunifu.UI.WinForms.BunifuPanel();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.bunifuPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(75)))));
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 3;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.lblName);
            this.bunifuPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(921, 100);
            this.bunifuPanel1.TabIndex = 96;
            // 
            // lblName
            // 
            this.lblName.AllowParentOverrides = false;
            this.lblName.AutoEllipsis = false;
            this.lblName.AutoSize = false;
            this.lblName.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblName.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(0, 0);
            this.lblName.Margin = new System.Windows.Forms.Padding(2);
            this.lblName.Name = "lblName";
            this.lblName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblName.Size = new System.Drawing.Size(921, 100);
            this.lblName.TabIndex = 39;
            this.lblName.Text = "*Patient name*";
            this.lblName.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblName.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lblTitleBirthdate
            // 
            this.lblTitleBirthdate.AllowParentOverrides = false;
            this.lblTitleBirthdate.AutoEllipsis = false;
            this.lblTitleBirthdate.CursorType = null;
            this.lblTitleBirthdate.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblTitleBirthdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(75)))));
            this.lblTitleBirthdate.Location = new System.Drawing.Point(25, 130);
            this.lblTitleBirthdate.Name = "lblTitleBirthdate";
            this.lblTitleBirthdate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTitleBirthdate.Size = new System.Drawing.Size(66, 21);
            this.lblTitleBirthdate.TabIndex = 97;
            this.lblTitleBirthdate.Text = "Birthdate:";
            this.lblTitleBirthdate.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblTitleBirthdate.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lblBirthdate
            // 
            this.lblBirthdate.AllowParentOverrides = false;
            this.lblBirthdate.AutoEllipsis = false;
            this.lblBirthdate.CursorType = null;
            this.lblBirthdate.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirthdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(75)))));
            this.lblBirthdate.Location = new System.Drawing.Point(42, 147);
            this.lblBirthdate.Margin = new System.Windows.Forms.Padding(2);
            this.lblBirthdate.Name = "lblBirthdate";
            this.lblBirthdate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblBirthdate.Size = new System.Drawing.Size(113, 31);
            this.lblBirthdate.TabIndex = 98;
            this.lblBirthdate.Text = "Add Admin";
            this.lblBirthdate.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBirthdate.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lblGender
            // 
            this.lblGender.AllowParentOverrides = false;
            this.lblGender.AutoEllipsis = false;
            this.lblGender.CursorType = null;
            this.lblGender.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(75)))));
            this.lblGender.Location = new System.Drawing.Point(42, 212);
            this.lblGender.Margin = new System.Windows.Forms.Padding(2);
            this.lblGender.Name = "lblGender";
            this.lblGender.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblGender.Size = new System.Drawing.Size(113, 31);
            this.lblGender.TabIndex = 100;
            this.lblGender.Text = "Add Admin";
            this.lblGender.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblGender.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.CursorType = null;
            this.bunifuLabel2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.bunifuLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(75)))));
            this.bunifuLabel2.Location = new System.Drawing.Point(25, 195);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(54, 21);
            this.bunifuLabel2.TabIndex = 99;
            this.bunifuLabel2.Text = "Gender:";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lblEmail
            // 
            this.lblEmail.AllowParentOverrides = false;
            this.lblEmail.AutoEllipsis = false;
            this.lblEmail.CursorType = null;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(75)))));
            this.lblEmail.Location = new System.Drawing.Point(42, 277);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblEmail.Size = new System.Drawing.Size(113, 31);
            this.lblEmail.TabIndex = 102;
            this.lblEmail.Text = "Add Admin";
            this.lblEmail.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEmail.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel4
            // 
            this.bunifuLabel4.AllowParentOverrides = false;
            this.bunifuLabel4.AutoEllipsis = false;
            this.bunifuLabel4.CursorType = null;
            this.bunifuLabel4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.bunifuLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(75)))));
            this.bunifuLabel4.Location = new System.Drawing.Point(25, 260);
            this.bunifuLabel4.Name = "bunifuLabel4";
            this.bunifuLabel4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel4.Size = new System.Drawing.Size(41, 21);
            this.bunifuLabel4.TabIndex = 101;
            this.bunifuLabel4.Text = "Email:";
            this.bunifuLabel4.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel4.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lblMobileNo
            // 
            this.lblMobileNo.AllowParentOverrides = false;
            this.lblMobileNo.AutoEllipsis = false;
            this.lblMobileNo.CursorType = null;
            this.lblMobileNo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMobileNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(75)))));
            this.lblMobileNo.Location = new System.Drawing.Point(42, 342);
            this.lblMobileNo.Margin = new System.Windows.Forms.Padding(2);
            this.lblMobileNo.Name = "lblMobileNo";
            this.lblMobileNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblMobileNo.Size = new System.Drawing.Size(113, 31);
            this.lblMobileNo.TabIndex = 104;
            this.lblMobileNo.Text = "Add Admin";
            this.lblMobileNo.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMobileNo.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel6
            // 
            this.bunifuLabel6.AllowParentOverrides = false;
            this.bunifuLabel6.AutoEllipsis = false;
            this.bunifuLabel6.CursorType = null;
            this.bunifuLabel6.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.bunifuLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(75)))));
            this.bunifuLabel6.Location = new System.Drawing.Point(25, 325);
            this.bunifuLabel6.Name = "bunifuLabel6";
            this.bunifuLabel6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel6.Size = new System.Drawing.Size(113, 21);
            this.bunifuLabel6.TabIndex = 103;
            this.bunifuLabel6.Text = "Mobile Number:";
            this.bunifuLabel6.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel6.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lblEmergencyNo
            // 
            this.lblEmergencyNo.AllowParentOverrides = false;
            this.lblEmergencyNo.AutoEllipsis = false;
            this.lblEmergencyNo.CursorType = null;
            this.lblEmergencyNo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmergencyNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(75)))));
            this.lblEmergencyNo.Location = new System.Drawing.Point(42, 407);
            this.lblEmergencyNo.Margin = new System.Windows.Forms.Padding(2);
            this.lblEmergencyNo.Name = "lblEmergencyNo";
            this.lblEmergencyNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblEmergencyNo.Size = new System.Drawing.Size(113, 31);
            this.lblEmergencyNo.TabIndex = 106;
            this.lblEmergencyNo.Text = "Add Admin";
            this.lblEmergencyNo.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEmergencyNo.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel8
            // 
            this.bunifuLabel8.AllowParentOverrides = false;
            this.bunifuLabel8.AutoEllipsis = false;
            this.bunifuLabel8.CursorType = null;
            this.bunifuLabel8.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.bunifuLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(75)))));
            this.bunifuLabel8.Location = new System.Drawing.Point(25, 390);
            this.bunifuLabel8.Name = "bunifuLabel8";
            this.bunifuLabel8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel8.Size = new System.Drawing.Size(139, 21);
            this.bunifuLabel8.TabIndex = 105;
            this.bunifuLabel8.Text = "Emergency Number";
            this.bunifuLabel8.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel8.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lblMaritalStat
            // 
            this.lblMaritalStat.AllowParentOverrides = false;
            this.lblMaritalStat.AutoEllipsis = false;
            this.lblMaritalStat.CursorType = null;
            this.lblMaritalStat.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaritalStat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(75)))));
            this.lblMaritalStat.Location = new System.Drawing.Point(42, 472);
            this.lblMaritalStat.Margin = new System.Windows.Forms.Padding(2);
            this.lblMaritalStat.Name = "lblMaritalStat";
            this.lblMaritalStat.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblMaritalStat.Size = new System.Drawing.Size(113, 31);
            this.lblMaritalStat.TabIndex = 108;
            this.lblMaritalStat.Text = "Add Admin";
            this.lblMaritalStat.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMaritalStat.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel10
            // 
            this.bunifuLabel10.AllowParentOverrides = false;
            this.bunifuLabel10.AutoEllipsis = false;
            this.bunifuLabel10.CursorType = null;
            this.bunifuLabel10.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.bunifuLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(75)))));
            this.bunifuLabel10.Location = new System.Drawing.Point(25, 455);
            this.bunifuLabel10.Name = "bunifuLabel10";
            this.bunifuLabel10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel10.Size = new System.Drawing.Size(99, 21);
            this.bunifuLabel10.TabIndex = 107;
            this.bunifuLabel10.Text = "Marital Status:";
            this.bunifuLabel10.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel10.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // btnEditPatient
            // 
            this.btnEditPatient.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(75)))));
            this.btnEditPatient.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEditPatient.ForeColor = System.Drawing.Color.White;
            this.btnEditPatient.Location = new System.Drawing.Point(25, 530);
            this.btnEditPatient.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditPatient.Name = "btnEditPatient";
            this.btnEditPatient.Size = new System.Drawing.Size(262, 37);
            this.btnEditPatient.TabIndex = 118;
            this.btnEditPatient.Text = "Edit Details";
            this.btnEditPatient.Click += new System.EventHandler(this.btnEditPatient_Click);
            // 
            // lblDiagnosis
            // 
            this.lblDiagnosis.AllowParentOverrides = false;
            this.lblDiagnosis.AutoEllipsis = false;
            this.lblDiagnosis.CursorType = null;
            this.lblDiagnosis.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiagnosis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(75)))));
            this.lblDiagnosis.Location = new System.Drawing.Point(321, 105);
            this.lblDiagnosis.Margin = new System.Windows.Forms.Padding(2);
            this.lblDiagnosis.Name = "lblDiagnosis";
            this.lblDiagnosis.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDiagnosis.Size = new System.Drawing.Size(234, 37);
            this.lblDiagnosis.TabIndex = 119;
            this.lblDiagnosis.Text = "Diagnosis History:";
            this.lblDiagnosis.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDiagnosis.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // pnlDiagnosis
            // 
            this.pnlDiagnosis.BackgroundColor = System.Drawing.Color.Transparent;
            this.pnlDiagnosis.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlDiagnosis.BackgroundImage")));
            this.pnlDiagnosis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlDiagnosis.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(75)))));
            this.pnlDiagnosis.BorderRadius = 3;
            this.pnlDiagnosis.BorderThickness = 1;
            this.pnlDiagnosis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(75)))));
            this.pnlDiagnosis.Location = new System.Drawing.Point(321, 183);
            this.pnlDiagnosis.Name = "pnlDiagnosis";
            this.pnlDiagnosis.Padding = new System.Windows.Forms.Padding(1);
            this.pnlDiagnosis.ShowBorders = true;
            this.pnlDiagnosis.Size = new System.Drawing.Size(557, 573);
            this.pnlDiagnosis.TabIndex = 120;
            // 
            // btnAdd
            // 
            this.btnAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(75)))));
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(616, 771);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(262, 37);
            this.btnAdd.TabIndex = 118;
            this.btnAdd.Text = "Add Diagnosis";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmPatientDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(921, 695);
            this.Controls.Add(this.pnlDiagnosis);
            this.Controls.Add(this.lblDiagnosis);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEditPatient);
            this.Controls.Add(this.bunifuLabel8);
            this.Controls.Add(this.lblMaritalStat);
            this.Controls.Add(this.bunifuLabel10);
            this.Controls.Add(this.lblEmergencyNo);
            this.Controls.Add(this.lblMobileNo);
            this.Controls.Add(this.bunifuLabel6);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.bunifuLabel4);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.bunifuLabel2);
            this.Controls.Add(this.lblBirthdate);
            this.Controls.Add(this.lblTitleBirthdate);
            this.Controls.Add(this.bunifuPanel1);
            this.Name = "frmPatientDetail";
            this.Text = "frmDoctorPatientDetail";
            this.bunifuPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private Bunifu.UI.WinForms.BunifuLabel lblName;
        private Bunifu.UI.WinForms.BunifuLabel lblTitleBirthdate;
        private Bunifu.UI.WinForms.BunifuLabel lblBirthdate;
        private Bunifu.UI.WinForms.BunifuLabel lblGender;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.UI.WinForms.BunifuLabel lblEmail;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel4;
        private Bunifu.UI.WinForms.BunifuLabel lblMobileNo;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel6;
        private Bunifu.UI.WinForms.BunifuLabel lblEmergencyNo;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel8;
        private Bunifu.UI.WinForms.BunifuLabel lblMaritalStat;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel10;
        private Guna.UI2.WinForms.Guna2Button btnEditPatient;
        private Bunifu.UI.WinForms.BunifuLabel lblDiagnosis;
        private Bunifu.UI.WinForms.BunifuPanel pnlDiagnosis;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
    }
}