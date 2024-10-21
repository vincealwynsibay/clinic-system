namespace ClinicSystem
{
    partial class frmSecretaryDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSecretaryDashboard));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblReport = new Bunifu.UI.WinForms.BunifuLabel();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.pnlAppointment = new Bunifu.UI.WinForms.BunifuPanel();
            this.lblAppointmentPercent = new Guna.UI2.WinForms.Guna2Button();
            this.bunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblAppointmentCount = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblAppoint = new Bunifu.UI.WinForms.BunifuLabel();
            this.pnlEarning = new Bunifu.UI.WinForms.BunifuPanel();
            this.lblEarningPercent = new Guna.UI2.WinForms.Guna2Button();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblEarningsCount = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblEarnings = new Bunifu.UI.WinForms.BunifuLabel();
            this.pnlPatient = new Bunifu.UI.WinForms.BunifuPanel();
            this.lblPatientPercent = new Guna.UI2.WinForms.Guna2Button();
            this.bunifuLabel6 = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblPatientCount = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblPatient = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.grdAppointment = new Guna.UI2.WinForms.Guna2DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnApprove = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlAppointment.SuspendLayout();
            this.pnlEarning.SuspendLayout();
            this.pnlPatient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAppointment)).BeginInit();
            this.SuspendLayout();
            // 
            // lblReport
            // 
            this.lblReport.AllowParentOverrides = false;
            this.lblReport.AutoEllipsis = false;
            this.lblReport.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblReport.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblReport.Font = new System.Drawing.Font("IBM Plex Sans", 24F, System.Drawing.FontStyle.Bold);
            this.lblReport.ForeColor = System.Drawing.Color.Black;
            this.lblReport.Location = new System.Drawing.Point(37, 27);
            this.lblReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblReport.Name = "lblReport";
            this.lblReport.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblReport.Size = new System.Drawing.Size(231, 53);
            this.lblReport.TabIndex = 39;
            this.lblReport.Text = "Daily Report";
            this.lblReport.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblReport.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // btnAdd
            // 
            this.btnAdd.BorderRadius = 5;
            this.btnAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(75)))));
            this.btnAdd.Font = new System.Drawing.Font("IBM Plex Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Image = global::ClinicSystem.Properties.Resources.plus;
            this.btnAdd.ImageOffset = new System.Drawing.Point(-10, 0);
            this.btnAdd.Location = new System.Drawing.Point(756, 27);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(311, 60);
            this.btnAdd.TabIndex = 140;
            this.btnAdd.Text = "Add New Patient";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pnlAppointment
            // 
            this.pnlAppointment.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.pnlAppointment.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlAppointment.BackgroundImage")));
            this.pnlAppointment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlAppointment.BorderColor = System.Drawing.Color.White;
            this.pnlAppointment.BorderRadius = 18;
            this.pnlAppointment.BorderThickness = 1;
            this.pnlAppointment.Controls.Add(this.lblAppointmentPercent);
            this.pnlAppointment.Controls.Add(this.bunifuLabel3);
            this.pnlAppointment.Controls.Add(this.lblAppointmentCount);
            this.pnlAppointment.Controls.Add(this.lblAppoint);
            this.pnlAppointment.Location = new System.Drawing.Point(37, 149);
            this.pnlAppointment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlAppointment.Name = "pnlAppointment";
            this.pnlAppointment.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.pnlAppointment.ShowBorders = true;
            this.pnlAppointment.Size = new System.Drawing.Size(321, 196);
            this.pnlAppointment.TabIndex = 141;
            // 
            // lblAppointmentPercent
            // 
            this.lblAppointmentPercent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.lblAppointmentPercent.BorderRadius = 8;
            this.lblAppointmentPercent.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(210)))), ((int)(((byte)(113)))));
            this.lblAppointmentPercent.DisabledState.ForeColor = System.Drawing.Color.White;
            this.lblAppointmentPercent.Enabled = false;
            this.lblAppointmentPercent.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(210)))), ((int)(((byte)(113)))));
            this.lblAppointmentPercent.Font = new System.Drawing.Font("IBM Plex Sans", 6.75F);
            this.lblAppointmentPercent.ForeColor = System.Drawing.Color.White;
            this.lblAppointmentPercent.ImageSize = new System.Drawing.Size(1, 2);
            this.lblAppointmentPercent.Location = new System.Drawing.Point(39, 159);
            this.lblAppointmentPercent.Margin = new System.Windows.Forms.Padding(0);
            this.lblAppointmentPercent.Name = "lblAppointmentPercent";
            this.lblAppointmentPercent.Size = new System.Drawing.Size(64, 23);
            this.lblAppointmentPercent.TabIndex = 144;
            this.lblAppointmentPercent.Text = "+30%";
            // 
            // bunifuLabel3
            // 
            this.bunifuLabel3.AllowParentOverrides = false;
            this.bunifuLabel3.AutoEllipsis = false;
            this.bunifuLabel3.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel3.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel3.Font = new System.Drawing.Font("IBM Plex Sans", 6.75F);
            this.bunifuLabel3.ForeColor = System.Drawing.Color.Black;
            this.bunifuLabel3.Location = new System.Drawing.Point(108, 164);
            this.bunifuLabel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bunifuLabel3.Name = "bunifuLabel3";
            this.bunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel3.Size = new System.Drawing.Size(98, 14);
            this.bunifuLabel3.TabIndex = 145;
            this.bunifuLabel3.Text = "Increase in 30 Days";
            this.bunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lblAppointmentCount
            // 
            this.lblAppointmentCount.AllowParentOverrides = false;
            this.lblAppointmentCount.AutoEllipsis = false;
            this.lblAppointmentCount.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblAppointmentCount.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblAppointmentCount.Font = new System.Drawing.Font("IBM Plex Sans", 27.75F, System.Drawing.FontStyle.Bold);
            this.lblAppointmentCount.ForeColor = System.Drawing.Color.Black;
            this.lblAppointmentCount.Location = new System.Drawing.Point(40, 71);
            this.lblAppointmentCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblAppointmentCount.Name = "lblAppointmentCount";
            this.lblAppointmentCount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblAppointmentCount.Size = new System.Drawing.Size(205, 60);
            this.lblAppointmentCount.TabIndex = 144;
            this.lblAppointmentCount.Text = "APPOINT";
            this.lblAppointmentCount.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAppointmentCount.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lblAppoint
            // 
            this.lblAppoint.AllowParentOverrides = false;
            this.lblAppoint.AutoEllipsis = false;
            this.lblAppoint.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblAppoint.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblAppoint.Font = new System.Drawing.Font("IBM Plex Sans", 14.25F);
            this.lblAppoint.ForeColor = System.Drawing.Color.Black;
            this.lblAppoint.Location = new System.Drawing.Point(39, 32);
            this.lblAppoint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblAppoint.Name = "lblAppoint";
            this.lblAppoint.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblAppoint.Size = new System.Drawing.Size(213, 33);
            this.lblAppoint.TabIndex = 144;
            this.lblAppoint.Text = "Total Appointments";
            this.lblAppoint.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAppoint.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // pnlEarning
            // 
            this.pnlEarning.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(230)))));
            this.pnlEarning.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlEarning.BackgroundImage")));
            this.pnlEarning.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlEarning.BorderColor = System.Drawing.Color.White;
            this.pnlEarning.BorderRadius = 18;
            this.pnlEarning.BorderThickness = 1;
            this.pnlEarning.Controls.Add(this.lblEarningPercent);
            this.pnlEarning.Controls.Add(this.bunifuLabel2);
            this.pnlEarning.Controls.Add(this.lblEarningsCount);
            this.pnlEarning.Controls.Add(this.lblEarnings);
            this.pnlEarning.Location = new System.Drawing.Point(740, 149);
            this.pnlEarning.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlEarning.Name = "pnlEarning";
            this.pnlEarning.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.pnlEarning.ShowBorders = true;
            this.pnlEarning.Size = new System.Drawing.Size(321, 209);
            this.pnlEarning.TabIndex = 146;
            // 
            // lblEarningPercent
            // 
            this.lblEarningPercent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.lblEarningPercent.BorderRadius = 8;
            this.lblEarningPercent.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(109)))), ((int)(((byte)(92)))));
            this.lblEarningPercent.DisabledState.ForeColor = System.Drawing.Color.White;
            this.lblEarningPercent.Enabled = false;
            this.lblEarningPercent.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(109)))), ((int)(((byte)(92)))));
            this.lblEarningPercent.Font = new System.Drawing.Font("IBM Plex Sans", 6.75F);
            this.lblEarningPercent.ForeColor = System.Drawing.Color.White;
            this.lblEarningPercent.ImageSize = new System.Drawing.Size(1, 2);
            this.lblEarningPercent.Location = new System.Drawing.Point(39, 159);
            this.lblEarningPercent.Margin = new System.Windows.Forms.Padding(0);
            this.lblEarningPercent.Name = "lblEarningPercent";
            this.lblEarningPercent.Size = new System.Drawing.Size(64, 23);
            this.lblEarningPercent.TabIndex = 144;
            this.lblEarningPercent.Text = "+30%";
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.Font = new System.Drawing.Font("IBM Plex Sans", 6.75F);
            this.bunifuLabel2.ForeColor = System.Drawing.Color.Black;
            this.bunifuLabel2.Location = new System.Drawing.Point(108, 164);
            this.bunifuLabel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(98, 14);
            this.bunifuLabel2.TabIndex = 145;
            this.bunifuLabel2.Text = "Increase in 30 Days";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lblEarningsCount
            // 
            this.lblEarningsCount.AllowParentOverrides = false;
            this.lblEarningsCount.AutoEllipsis = false;
            this.lblEarningsCount.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblEarningsCount.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblEarningsCount.Font = new System.Drawing.Font("IBM Plex Sans", 27.75F, System.Drawing.FontStyle.Bold);
            this.lblEarningsCount.ForeColor = System.Drawing.Color.Black;
            this.lblEarningsCount.Location = new System.Drawing.Point(40, 71);
            this.lblEarningsCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblEarningsCount.Name = "lblEarningsCount";
            this.lblEarningsCount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblEarningsCount.Size = new System.Drawing.Size(32, 60);
            this.lblEarningsCount.TabIndex = 144;
            this.lblEarningsCount.Text = "₱";
            this.lblEarningsCount.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEarningsCount.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lblEarnings
            // 
            this.lblEarnings.AllowParentOverrides = false;
            this.lblEarnings.AutoEllipsis = false;
            this.lblEarnings.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblEarnings.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblEarnings.Font = new System.Drawing.Font("IBM Plex Sans", 14.25F);
            this.lblEarnings.ForeColor = System.Drawing.Color.Black;
            this.lblEarnings.Location = new System.Drawing.Point(39, 32);
            this.lblEarnings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblEarnings.Name = "lblEarnings";
            this.lblEarnings.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblEarnings.Size = new System.Drawing.Size(156, 33);
            this.lblEarnings.TabIndex = 144;
            this.lblEarnings.Text = "Total Earnings";
            this.lblEarnings.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEarnings.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // pnlPatient
            // 
            this.pnlPatient.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(251)))), ((int)(((byte)(250)))));
            this.pnlPatient.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlPatient.BackgroundImage")));
            this.pnlPatient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlPatient.BorderColor = System.Drawing.Color.White;
            this.pnlPatient.BorderRadius = 18;
            this.pnlPatient.BorderThickness = 1;
            this.pnlPatient.Controls.Add(this.lblPatientPercent);
            this.pnlPatient.Controls.Add(this.bunifuLabel6);
            this.pnlPatient.Controls.Add(this.lblPatientCount);
            this.pnlPatient.Controls.Add(this.lblPatient);
            this.pnlPatient.Location = new System.Drawing.Point(392, 149);
            this.pnlPatient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlPatient.Name = "pnlPatient";
            this.pnlPatient.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.pnlPatient.ShowBorders = true;
            this.pnlPatient.Size = new System.Drawing.Size(321, 209);
            this.pnlPatient.TabIndex = 147;
            // 
            // lblPatientPercent
            // 
            this.lblPatientPercent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.lblPatientPercent.BorderRadius = 8;
            this.lblPatientPercent.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(210)))), ((int)(((byte)(113)))));
            this.lblPatientPercent.DisabledState.ForeColor = System.Drawing.Color.White;
            this.lblPatientPercent.Enabled = false;
            this.lblPatientPercent.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(210)))), ((int)(((byte)(113)))));
            this.lblPatientPercent.Font = new System.Drawing.Font("IBM Plex Sans", 6.75F);
            this.lblPatientPercent.ForeColor = System.Drawing.Color.White;
            this.lblPatientPercent.ImageSize = new System.Drawing.Size(1, 2);
            this.lblPatientPercent.Location = new System.Drawing.Point(39, 159);
            this.lblPatientPercent.Margin = new System.Windows.Forms.Padding(0);
            this.lblPatientPercent.Name = "lblPatientPercent";
            this.lblPatientPercent.Size = new System.Drawing.Size(64, 23);
            this.lblPatientPercent.TabIndex = 144;
            this.lblPatientPercent.Text = "+30%";
            // 
            // bunifuLabel6
            // 
            this.bunifuLabel6.AllowParentOverrides = false;
            this.bunifuLabel6.AutoEllipsis = false;
            this.bunifuLabel6.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel6.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel6.Font = new System.Drawing.Font("IBM Plex Sans", 6.75F);
            this.bunifuLabel6.ForeColor = System.Drawing.Color.Black;
            this.bunifuLabel6.Location = new System.Drawing.Point(108, 164);
            this.bunifuLabel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bunifuLabel6.Name = "bunifuLabel6";
            this.bunifuLabel6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel6.Size = new System.Drawing.Size(98, 14);
            this.bunifuLabel6.TabIndex = 145;
            this.bunifuLabel6.Text = "Increase in 30 Days";
            this.bunifuLabel6.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuLabel6.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lblPatientCount
            // 
            this.lblPatientCount.AllowParentOverrides = false;
            this.lblPatientCount.AutoEllipsis = false;
            this.lblPatientCount.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblPatientCount.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblPatientCount.Font = new System.Drawing.Font("IBM Plex Sans", 27.75F, System.Drawing.FontStyle.Bold);
            this.lblPatientCount.ForeColor = System.Drawing.Color.Black;
            this.lblPatientCount.Location = new System.Drawing.Point(40, 71);
            this.lblPatientCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblPatientCount.Name = "lblPatientCount";
            this.lblPatientCount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPatientCount.Size = new System.Drawing.Size(197, 60);
            this.lblPatientCount.TabIndex = 144;
            this.lblPatientCount.Text = "PATIENT";
            this.lblPatientCount.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPatientCount.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lblPatient
            // 
            this.lblPatient.AllowParentOverrides = false;
            this.lblPatient.AutoEllipsis = false;
            this.lblPatient.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblPatient.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblPatient.Font = new System.Drawing.Font("IBM Plex Sans", 14.25F);
            this.lblPatient.ForeColor = System.Drawing.Color.Black;
            this.lblPatient.Location = new System.Drawing.Point(39, 32);
            this.lblPatient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblPatient.Name = "lblPatient";
            this.lblPatient.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPatient.Size = new System.Drawing.Size(150, 33);
            this.lblPatient.TabIndex = 144;
            this.lblPatient.Text = "Total Patients";
            this.lblPatient.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPatient.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("IBM Plex Sans", 18F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel1.ForeColor = System.Drawing.Color.Black;
            this.bunifuLabel1.Location = new System.Drawing.Point(37, 426);
            this.bunifuLabel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(200, 39);
            this.bunifuLabel1.TabIndex = 148;
            this.bunifuLabel1.Text = "Appointments";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // grdAppointment
            // 
            this.grdAppointment.AllowUserToAddRows = false;
            this.grdAppointment.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.grdAppointment.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("IBM Plex Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdAppointment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdAppointment.ColumnHeadersHeight = 24;
            this.grdAppointment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.fullname,
            this.mobileno,
            this.gender,
            this.btnApprove});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdAppointment.DefaultCellStyle = dataGridViewCellStyle3;
            this.grdAppointment.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.grdAppointment.Location = new System.Drawing.Point(37, 506);
            this.grdAppointment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grdAppointment.Name = "grdAppointment";
            this.grdAppointment.ReadOnly = true;
            this.grdAppointment.RowHeadersVisible = false;
            this.grdAppointment.RowHeadersWidth = 51;
            this.grdAppointment.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdAppointment.RowTemplate.Height = 40;
            this.grdAppointment.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.grdAppointment.Size = new System.Drawing.Size(1030, 261);
            this.grdAppointment.TabIndex = 151;
            this.grdAppointment.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.WhiteGrid;
            this.grdAppointment.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.grdAppointment.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.grdAppointment.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.grdAppointment.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.grdAppointment.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.grdAppointment.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.grdAppointment.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.grdAppointment.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.White;
            this.grdAppointment.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grdAppointment.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("IBM Plex Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdAppointment.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.grdAppointment.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grdAppointment.ThemeStyle.HeaderStyle.Height = 24;
            this.grdAppointment.ThemeStyle.ReadOnly = true;
            this.grdAppointment.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.grdAppointment.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grdAppointment.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.grdAppointment.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.grdAppointment.ThemeStyle.RowsStyle.Height = 40;
            this.grdAppointment.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.grdAppointment.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // id
            // 
            this.id.FillWeight = 74.18671F;
            this.id.HeaderText = "Patient ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // fullname
            // 
            this.fullname.FillWeight = 74.18671F;
            this.fullname.HeaderText = "Full Name";
            this.fullname.MinimumWidth = 6;
            this.fullname.Name = "fullname";
            this.fullname.ReadOnly = true;
            // 
            // mobileno
            // 
            this.mobileno.FillWeight = 74.18671F;
            this.mobileno.HeaderText = "Phone Number";
            this.mobileno.MinimumWidth = 6;
            this.mobileno.Name = "mobileno";
            this.mobileno.ReadOnly = true;
            // 
            // gender
            // 
            this.gender.FillWeight = 74.18671F;
            this.gender.HeaderText = "Email";
            this.gender.MinimumWidth = 6;
            this.gender.Name = "gender";
            this.gender.ReadOnly = true;
            // 
            // btnApprove
            // 
            this.btnApprove.FillWeight = 74.18671F;
            this.btnApprove.HeaderText = "";
            this.btnApprove.MinimumWidth = 6;
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.ReadOnly = true;
            // 
            // frmSecretaryDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1105, 810);
            this.Controls.Add(this.grdAppointment);
            this.Controls.Add(this.bunifuLabel1);
            this.Controls.Add(this.pnlPatient);
            this.Controls.Add(this.pnlEarning);
            this.Controls.Add(this.pnlAppointment);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblReport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmSecretaryDashboard";
            this.Text = "frmSecretaryDashboard";
            this.Load += new System.EventHandler(this.frmSecretaryDashboard_Load);
            this.pnlAppointment.ResumeLayout(false);
            this.pnlAppointment.PerformLayout();
            this.pnlEarning.ResumeLayout(false);
            this.pnlEarning.PerformLayout();
            this.pnlPatient.ResumeLayout(false);
            this.pnlPatient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAppointment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button lblPatientPercent;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel6;
        private Bunifu.UI.WinForms.BunifuLabel lblPatientCount;
        private Bunifu.UI.WinForms.BunifuLabel lblPatient;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuPanel pnlPatient;
        private Guna.UI2.WinForms.Guna2Button lblEarningPercent;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.UI.WinForms.BunifuLabel lblAppoint;
        private Bunifu.UI.WinForms.BunifuLabel lblEarningsCount;
        private Bunifu.UI.WinForms.BunifuLabel lblEarnings;
        private Guna.UI2.WinForms.Guna2Button lblAppointmentPercent;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel3;
        private Bunifu.UI.WinForms.BunifuLabel lblAppointmentCount;
        private Bunifu.UI.WinForms.BunifuPanel pnlEarning;
        private Bunifu.UI.WinForms.BunifuPanel pnlAppointment;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Bunifu.UI.WinForms.BunifuLabel lblReport;
        private Guna.UI2.WinForms.Guna2DataGridView grdAppointment;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullname;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileno;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn btnApprove;
    }
}