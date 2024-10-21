namespace ClinicSystem.Patient
{
    partial class frmPatientPayments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPatientPayments));
            this.grdBillings = new Guna.UI2.WinForms.Guna2DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountpaid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEdit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblReport = new Bunifu.UI.WinForms.BunifuLabel();
            this.cboFilter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnPaid = new Guna.UI2.WinForms.Guna2Button();
            this.btnAll = new Guna.UI2.WinForms.Guna2Button();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnUnpaid = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdBillings)).BeginInit();
            this.SuspendLayout();
            // 
            // grdBillings
            // 
            this.grdBillings.AllowUserToAddRows = false;
            this.grdBillings.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.grdBillings.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("IBM Plex Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdBillings.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdBillings.ColumnHeadersHeight = 24;
            this.grdBillings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.fullname,
            this.amount,
            this.amountpaid,
            this.doctor,
            this.status1,
            this.btnEdit,
            this.btnPay});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdBillings.DefaultCellStyle = dataGridViewCellStyle3;
            this.grdBillings.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.grdBillings.Location = new System.Drawing.Point(45, 377);
            this.grdBillings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grdBillings.Name = "grdBillings";
            this.grdBillings.ReadOnly = true;
            this.grdBillings.RowHeadersVisible = false;
            this.grdBillings.RowHeadersWidth = 51;
            this.grdBillings.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdBillings.RowTemplate.Height = 40;
            this.grdBillings.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.grdBillings.Size = new System.Drawing.Size(999, 475);
            this.grdBillings.TabIndex = 163;
            this.grdBillings.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.WhiteGrid;
            this.grdBillings.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.grdBillings.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.grdBillings.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.grdBillings.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.grdBillings.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.grdBillings.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.grdBillings.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.grdBillings.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.White;
            this.grdBillings.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grdBillings.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("IBM Plex Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdBillings.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.grdBillings.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grdBillings.ThemeStyle.HeaderStyle.Height = 24;
            this.grdBillings.ThemeStyle.ReadOnly = true;
            this.grdBillings.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.grdBillings.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grdBillings.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.grdBillings.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.grdBillings.ThemeStyle.RowsStyle.Height = 40;
            this.grdBillings.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.grdBillings.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // id
            // 
            this.id.FillWeight = 74.18671F;
            this.id.HeaderText = "ID";
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
            // amount
            // 
            this.amount.FillWeight = 74.18671F;
            this.amount.HeaderText = "Balance";
            this.amount.MinimumWidth = 6;
            this.amount.Name = "amount";
            this.amount.ReadOnly = true;
            // 
            // amountpaid
            // 
            this.amountpaid.FillWeight = 74.18671F;
            this.amountpaid.HeaderText = "Paid Amount";
            this.amountpaid.MinimumWidth = 6;
            this.amountpaid.Name = "amountpaid";
            this.amountpaid.ReadOnly = true;
            // 
            // doctor
            // 
            this.doctor.HeaderText = "Doctor";
            this.doctor.MinimumWidth = 6;
            this.doctor.Name = "doctor";
            this.doctor.ReadOnly = true;
            // 
            // status1
            // 
            this.status1.HeaderText = "Status";
            this.status1.MinimumWidth = 6;
            this.status1.Name = "status1";
            this.status1.ReadOnly = true;
            // 
            // btnEdit
            // 
            this.btnEdit.FillWeight = 25F;
            this.btnEdit.HeaderText = "";
            this.btnEdit.MinimumWidth = 6;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.ReadOnly = true;
            this.btnEdit.Visible = false;
            // 
            // btnPay
            // 
            this.btnPay.FillWeight = 74.18671F;
            this.btnPay.HeaderText = "";
            this.btnPay.MinimumWidth = 6;
            this.btnPay.Name = "btnPay";
            this.btnPay.ReadOnly = true;
            // 
            // lblReport
            // 
            this.lblReport.AllowParentOverrides = false;
            this.lblReport.AutoEllipsis = false;
            this.lblReport.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblReport.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblReport.Font = new System.Drawing.Font("IBM Plex Sans", 24F, System.Drawing.FontStyle.Bold);
            this.lblReport.ForeColor = System.Drawing.Color.Black;
            this.lblReport.Location = new System.Drawing.Point(45, 51);
            this.lblReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblReport.Name = "lblReport";
            this.lblReport.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblReport.Size = new System.Drawing.Size(187, 53);
            this.lblReport.TabIndex = 161;
            this.lblReport.Text = "Payments";
            this.lblReport.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblReport.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // cboFilter
            // 
            this.cboFilter.BackColor = System.Drawing.Color.Transparent;
            this.cboFilter.BorderRadius = 15;
            this.cboFilter.BorderThickness = 0;
            this.cboFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFilter.FillColor = System.Drawing.Color.WhiteSmoke;
            this.cboFilter.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboFilter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboFilter.Font = new System.Drawing.Font("IBM Plex Sans", 9.75F, System.Drawing.FontStyle.Bold);
            this.cboFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(42)))));
            this.cboFilter.ItemHeight = 30;
            this.cboFilter.Items.AddRange(new object[] {
            "(None)",
            "Today",
            "This Week",
            "This Month",
            "This Year",
            "All"});
            this.cboFilter.ItemsAppearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFilter.ItemsAppearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(42)))));
            this.cboFilter.Location = new System.Drawing.Point(888, 231);
            this.cboFilter.Margin = new System.Windows.Forms.Padding(4);
            this.cboFilter.Name = "cboFilter";
            this.cboFilter.Size = new System.Drawing.Size(156, 36);
            this.cboFilter.StartIndex = 1;
            this.cboFilter.TabIndex = 168;
            this.cboFilter.TextOffset = new System.Drawing.Point(10, 2);
            this.cboFilter.SelectedIndexChanged += new System.EventHandler(this.cboFilter_SelectedIndexChanged);
            // 
            // btnPaid
            // 
            this.btnPaid.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.btnPaid.BorderRadius = 15;
            this.btnPaid.BorderThickness = 1;
            this.btnPaid.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPaid.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPaid.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPaid.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPaid.FillColor = System.Drawing.Color.White;
            this.btnPaid.Font = new System.Drawing.Font("IBM Plex Sans", 9F);
            this.btnPaid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(42)))));
            this.btnPaid.Location = new System.Drawing.Point(211, 253);
            this.btnPaid.Margin = new System.Windows.Forms.Padding(4);
            this.btnPaid.Name = "btnPaid";
            this.btnPaid.Size = new System.Drawing.Size(145, 41);
            this.btnPaid.TabIndex = 166;
            this.btnPaid.Text = "Paid";
            this.btnPaid.Click += new System.EventHandler(this.btnPaid_Click);
            // 
            // btnAll
            // 
            this.btnAll.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.btnAll.BorderRadius = 15;
            this.btnAll.BorderThickness = 1;
            this.btnAll.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAll.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAll.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAll.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAll.FillColor = System.Drawing.Color.White;
            this.btnAll.Font = new System.Drawing.Font("IBM Plex Sans", 9F);
            this.btnAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(42)))));
            this.btnAll.Location = new System.Drawing.Point(45, 253);
            this.btnAll.Margin = new System.Windows.Forms.Padding(4);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(145, 41);
            this.btnAll.TabIndex = 167;
            this.btnAll.Text = "All";
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.txtSearch.BorderRadius = 15;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.IconLeft = global::ClinicSystem.Properties.Resources.icnSearch;
            this.txtSearch.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.txtSearch.Location = new System.Drawing.Point(45, 162);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "Search Appoinments";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(411, 44);
            this.txtSearch.TabIndex = 164;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnUnpaid
            // 
            this.btnUnpaid.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.btnUnpaid.BorderRadius = 15;
            this.btnUnpaid.BorderThickness = 1;
            this.btnUnpaid.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUnpaid.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUnpaid.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUnpaid.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUnpaid.FillColor = System.Drawing.Color.White;
            this.btnUnpaid.Font = new System.Drawing.Font("IBM Plex Sans", 9F);
            this.btnUnpaid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(42)))));
            this.btnUnpaid.Location = new System.Drawing.Point(381, 253);
            this.btnUnpaid.Margin = new System.Windows.Forms.Padding(4);
            this.btnUnpaid.Name = "btnUnpaid";
            this.btnUnpaid.Size = new System.Drawing.Size(145, 41);
            this.btnUnpaid.TabIndex = 166;
            this.btnUnpaid.Text = "Unpaid";
            this.btnUnpaid.Click += new System.EventHandler(this.btnUnpaid_Click);
            // 
            // frmPatientPayments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1105, 810);
            this.Controls.Add(this.grdBillings);
            this.Controls.Add(this.lblReport);
            this.Controls.Add(this.cboFilter);
            this.Controls.Add(this.btnUnpaid);
            this.Controls.Add(this.btnPaid);
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.txtSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmPatientPayments";
            this.Text = "frmPatientPayments";
            this.Load += new System.EventHandler(this.frmPatientPayments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdBillings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView grdBillings;
        private Bunifu.UI.WinForms.BunifuLabel lblReport;
        private Guna.UI2.WinForms.Guna2ComboBox cboFilter;
        private Guna.UI2.WinForms.Guna2Button btnPaid;
        private Guna.UI2.WinForms.Guna2Button btnAll;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2Button btnUnpaid;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullname;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountpaid;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctor;
        private System.Windows.Forms.DataGridViewTextBoxColumn status1;
        private System.Windows.Forms.DataGridViewTextBoxColumn btnEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn btnPay;
    }
}