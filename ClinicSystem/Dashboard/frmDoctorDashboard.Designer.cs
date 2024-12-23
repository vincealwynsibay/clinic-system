﻿namespace ClinicSystem
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
            this.pnlAppointmentTable = new Bunifu.UI.WinForms.BunifuPanel();
            this.pnlAppointment.SuspendLayout();
            this.pnlEarning.SuspendLayout();
            this.pnlPatient.SuspendLayout();
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
            this.lblReport.Location = new System.Drawing.Point(28, 22);
            this.lblReport.Margin = new System.Windows.Forms.Padding(2);
            this.lblReport.Name = "lblReport";
            this.lblReport.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblReport.Size = new System.Drawing.Size(186, 43);
            this.lblReport.Size = new System.Drawing.Size(186, 43);
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
            this.btnAdd.Location = new System.Drawing.Point(563, 22);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(233, 49);
            this.btnAdd.Size = new System.Drawing.Size(233, 49);
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
            this.pnlAppointment.Location = new System.Drawing.Point(28, 121);
            this.pnlAppointment.Margin = new System.Windows.Forms.Padding(2);
            this.pnlAppointment.Name = "pnlAppointment";
            this.pnlAppointment.Padding = new System.Windows.Forms.Padding(8);
            this.pnlAppointment.ShowBorders = true;
            this.pnlAppointment.Size = new System.Drawing.Size(241, 159);
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
            this.lblAppointmentPercent.Font = new System.Drawing.Font("IBM Plex Sans", 6F);
            this.lblAppointmentPercent.ForeColor = System.Drawing.Color.White;
            this.lblAppointmentPercent.ImageSize = new System.Drawing.Size(1, 2);
            this.lblAppointmentPercent.Location = new System.Drawing.Point(29, 129);
            this.lblAppointmentPercent.Location = new System.Drawing.Point(29, 129);
            this.lblAppointmentPercent.Margin = new System.Windows.Forms.Padding(0);
            this.lblAppointmentPercent.Name = "lblAppointmentPercent";
            this.lblAppointmentPercent.Size = new System.Drawing.Size(56, 19);
            this.lblAppointmentPercent.Size = new System.Drawing.Size(56, 19);
            this.lblAppointmentPercent.TabIndex = 144;
            this.lblAppointmentPercent.Text = "+0%";
            // 
            // bunifuLabel3
            // 
            this.bunifuLabel3.AllowParentOverrides = false;
            this.bunifuLabel3.AutoEllipsis = false;
            this.bunifuLabel3.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel3.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel3.Font = new System.Drawing.Font("IBM Plex Sans", 6.75F);
            this.bunifuLabel3.ForeColor = System.Drawing.Color.Black;
            this.bunifuLabel3.Location = new System.Drawing.Point(88, 133);
            this.bunifuLabel3.Margin = new System.Windows.Forms.Padding(2);
            this.bunifuLabel3.Name = "bunifuLabel3";
            this.bunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel3.Size = new System.Drawing.Size(78, 11);
            this.bunifuLabel3.Size = new System.Drawing.Size(78, 11);
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
            this.lblAppointmentCount.Location = new System.Drawing.Point(30, 58);
            this.lblAppointmentCount.Margin = new System.Windows.Forms.Padding(2);
            this.lblAppointmentCount.Name = "lblAppointmentCount";
            this.lblAppointmentCount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblAppointmentCount.Size = new System.Drawing.Size(164, 49);
            this.lblAppointmentCount.Size = new System.Drawing.Size(164, 49);
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
            this.lblAppoint.Location = new System.Drawing.Point(29, 26);
            this.lblAppoint.Margin = new System.Windows.Forms.Padding(2);
            this.lblAppoint.Name = "lblAppoint";
            this.lblAppoint.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblAppoint.Size = new System.Drawing.Size(170, 25);
            this.lblAppoint.Size = new System.Drawing.Size(170, 25);
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
            this.pnlEarning.Location = new System.Drawing.Point(556, 121);
            this.pnlEarning.Margin = new System.Windows.Forms.Padding(2);
            this.pnlEarning.Name = "pnlEarning";
            this.pnlEarning.Padding = new System.Windows.Forms.Padding(8);
            this.pnlEarning.ShowBorders = true;
            this.pnlEarning.Size = new System.Drawing.Size(241, 170);
            this.pnlEarning.TabIndex = 146;
            // 
            // lblEarningPercent
            // 
            this.lblEarningPercent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(230)))));
            this.lblEarningPercent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(230)))));
            this.lblEarningPercent.BorderRadius = 8;
            this.lblEarningPercent.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(109)))), ((int)(((byte)(92)))));
            this.lblEarningPercent.DisabledState.ForeColor = System.Drawing.Color.White;
            this.lblEarningPercent.Enabled = false;
            this.lblEarningPercent.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(109)))), ((int)(((byte)(92)))));
            this.lblEarningPercent.Font = new System.Drawing.Font("IBM Plex Sans", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEarningPercent.ForeColor = System.Drawing.Color.White;
            this.lblEarningPercent.ImageSize = new System.Drawing.Size(1, 2);
            this.lblEarningPercent.Location = new System.Drawing.Point(29, 129);
            this.lblEarningPercent.Location = new System.Drawing.Point(29, 129);
            this.lblEarningPercent.Margin = new System.Windows.Forms.Padding(0);
            this.lblEarningPercent.Name = "lblEarningPercent";
            this.lblEarningPercent.Size = new System.Drawing.Size(56, 19);
            this.lblEarningPercent.Size = new System.Drawing.Size(56, 19);
            this.lblEarningPercent.TabIndex = 144;
            this.lblEarningPercent.Text = "+0%";
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.Font = new System.Drawing.Font("IBM Plex Sans", 6.75F);
            this.bunifuLabel2.ForeColor = System.Drawing.Color.Black;
            this.bunifuLabel2.Location = new System.Drawing.Point(88, 133);
            this.bunifuLabel2.Margin = new System.Windows.Forms.Padding(2);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(78, 11);
            this.bunifuLabel2.Size = new System.Drawing.Size(78, 11);
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
            this.lblEarningsCount.Location = new System.Drawing.Point(30, 58);
            this.lblEarningsCount.Margin = new System.Windows.Forms.Padding(2);
            this.lblEarningsCount.Name = "lblEarningsCount";
            this.lblEarningsCount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblEarningsCount.Size = new System.Drawing.Size(26, 49);
            this.lblEarningsCount.Size = new System.Drawing.Size(26, 49);
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
            this.lblEarnings.Location = new System.Drawing.Point(29, 26);
            this.lblEarnings.Margin = new System.Windows.Forms.Padding(2);
            this.lblEarnings.Name = "lblEarnings";
            this.lblEarnings.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblEarnings.Size = new System.Drawing.Size(122, 25);
            this.lblEarnings.Size = new System.Drawing.Size(122, 25);
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
            this.pnlPatient.Location = new System.Drawing.Point(292, 121);
            this.pnlPatient.Margin = new System.Windows.Forms.Padding(2);
            this.pnlPatient.Name = "pnlPatient";
            this.pnlPatient.Padding = new System.Windows.Forms.Padding(8);
            this.pnlPatient.ShowBorders = true;
            this.pnlPatient.Size = new System.Drawing.Size(241, 170);
            this.pnlPatient.TabIndex = 147;
            // 
            // lblPatientPercent
            // 
            this.lblPatientPercent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(251)))), ((int)(((byte)(250)))));
            this.lblPatientPercent.BorderRadius = 8;
            this.lblPatientPercent.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(210)))), ((int)(((byte)(113)))));
            this.lblPatientPercent.DisabledState.ForeColor = System.Drawing.Color.White;
            this.lblPatientPercent.Enabled = false;
            this.lblPatientPercent.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(210)))), ((int)(((byte)(113)))));
            this.lblPatientPercent.Font = new System.Drawing.Font("IBM Plex Sans", 6F);
            this.lblPatientPercent.ForeColor = System.Drawing.Color.White;
            this.lblPatientPercent.ImageSize = new System.Drawing.Size(1, 2);
            this.lblPatientPercent.Location = new System.Drawing.Point(29, 129);
            this.lblPatientPercent.Location = new System.Drawing.Point(29, 129);
            this.lblPatientPercent.Margin = new System.Windows.Forms.Padding(0);
            this.lblPatientPercent.Name = "lblPatientPercent";
            this.lblPatientPercent.Size = new System.Drawing.Size(56, 19);
            this.lblPatientPercent.Size = new System.Drawing.Size(56, 19);
            this.lblPatientPercent.TabIndex = 144;
            this.lblPatientPercent.Text = "+0%";
            // 
            // bunifuLabel6
            // 
            this.bunifuLabel6.AllowParentOverrides = false;
            this.bunifuLabel6.AutoEllipsis = false;
            this.bunifuLabel6.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel6.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel6.Font = new System.Drawing.Font("IBM Plex Sans", 6.75F);
            this.bunifuLabel6.ForeColor = System.Drawing.Color.Black;
            this.bunifuLabel6.Location = new System.Drawing.Point(88, 133);
            this.bunifuLabel6.Margin = new System.Windows.Forms.Padding(2);
            this.bunifuLabel6.Name = "bunifuLabel6";
            this.bunifuLabel6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel6.Size = new System.Drawing.Size(78, 11);
            this.bunifuLabel6.Size = new System.Drawing.Size(78, 11);
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
            this.lblPatientCount.Location = new System.Drawing.Point(30, 58);
            this.lblPatientCount.Margin = new System.Windows.Forms.Padding(2);
            this.lblPatientCount.Name = "lblPatientCount";
            this.lblPatientCount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPatientCount.Size = new System.Drawing.Size(158, 49);
            this.lblPatientCount.Size = new System.Drawing.Size(158, 49);
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
            this.lblPatient.Location = new System.Drawing.Point(29, 26);
            this.lblPatient.Margin = new System.Windows.Forms.Padding(2);
            this.lblPatient.Name = "lblPatient";
            this.lblPatient.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPatient.Size = new System.Drawing.Size(119, 25);
            this.lblPatient.Size = new System.Drawing.Size(119, 25);
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
            this.bunifuLabel1.Location = new System.Drawing.Point(28, 346);
            this.bunifuLabel1.Margin = new System.Windows.Forms.Padding(2);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(159, 33);
            this.bunifuLabel1.Size = new System.Drawing.Size(159, 33);
            this.bunifuLabel1.TabIndex = 148;
            this.bunifuLabel1.Text = "Appointments";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // pnlAppointmentTable
            // 
            this.pnlAppointmentTable.BackgroundColor = System.Drawing.Color.White;
            this.pnlAppointmentTable.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlAppointmentTable.BackgroundImage")));
            this.pnlAppointmentTable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlAppointmentTable.BorderColor = System.Drawing.Color.Transparent;
            this.pnlAppointmentTable.BorderRadius = 3;
            this.pnlAppointmentTable.BorderThickness = 1;
            this.pnlAppointmentTable.Location = new System.Drawing.Point(28, 386);
            this.pnlAppointmentTable.Location = new System.Drawing.Point(28, 386);
            this.pnlAppointmentTable.Name = "pnlAppointmentTable";
            this.pnlAppointmentTable.ShowBorders = false;
            this.pnlAppointmentTable.Size = new System.Drawing.Size(769, 296);
            this.pnlAppointmentTable.TabIndex = 150;
            // 
            // frmDoctorDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(855, 743);
            this.Controls.Add(this.pnlAppointmentTable);
            this.Controls.Add(this.bunifuLabel1);
            this.Controls.Add(this.pnlPatient);
            this.Controls.Add(this.pnlEarning);
            this.Controls.Add(this.pnlAppointment);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblReport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmDoctorDashboard";
            this.Text = "frmDoctorDashboard";
            this.pnlAppointment.ResumeLayout(false);
            this.pnlAppointment.PerformLayout();
            this.pnlEarning.ResumeLayout(false);
            this.pnlEarning.PerformLayout();
            this.pnlPatient.ResumeLayout(false);
            this.pnlPatient.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuLabel lblReport;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Bunifu.UI.WinForms.BunifuPanel pnlAppointment;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel3;
        private Bunifu.UI.WinForms.BunifuLabel lblAppointmentCount;
        private Bunifu.UI.WinForms.BunifuLabel lblAppoint;
        private Guna.UI2.WinForms.Guna2Button lblAppointmentPercent;
        private Bunifu.UI.WinForms.BunifuPanel pnlEarning;
        private Guna.UI2.WinForms.Guna2Button lblEarningPercent;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.UI.WinForms.BunifuLabel lblEarningsCount;
        private Bunifu.UI.WinForms.BunifuLabel lblEarnings;
        private Bunifu.UI.WinForms.BunifuPanel pnlPatient;
        private Guna.UI2.WinForms.Guna2Button lblPatientPercent;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel6;
        private Bunifu.UI.WinForms.BunifuLabel lblPatientCount;
        private Bunifu.UI.WinForms.BunifuLabel lblPatient;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuPanel pnlAppointmentTable;
    }
}