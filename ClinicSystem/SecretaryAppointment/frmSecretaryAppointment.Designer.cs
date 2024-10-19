namespace ClinicSystem.
partial class frmSecretaryAppointment
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSecretaryAppointment));
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
        this.lblReport = new Bunifu.UI.WinForms.BunifuLabel();
        this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
        this.grdAppointment = new Guna.UI2.WinForms.Guna2DataGridView();
        this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.fullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.mobileno = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.btnEdit = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.btnDelete = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.btnApprove = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
        this.btnFilterApprove = new Guna.UI2.WinForms.Guna2Button();
        this.btnPending = new Guna.UI2.WinForms.Guna2Button();
        this.btnCancelled = new Guna.UI2.WinForms.Guna2Button();
        this.cboFilter = new Guna.UI2.WinForms.Guna2ComboBox();
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
        this.lblReport.Size = new System.Drawing.Size(265, 53);
        this.lblReport.TabIndex = 39;
        this.lblReport.Text = "Appointments";
        this.lblReport.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
        this.lblReport.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
        // 
        // btnAdd
        // 
        this.btnAdd.BorderRadius = 5;
        this.btnAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(75)))));
        this.btnAdd.Font = new System.Drawing.Font("IBM Plex Sans SemiBold", 12F, System.Drawing.FontStyle.Bold);
        this.btnAdd.ForeColor = System.Drawing.Color.White;
        this.btnAdd.Image = global::ClinicSystem.Properties.Resources.plus;
        this.btnAdd.ImageOffset = new System.Drawing.Point(-5, 0);
        this.btnAdd.Location = new System.Drawing.Point(855, 27);
        this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
        this.btnAdd.Name = "btnAdd";
        this.btnAdd.Size = new System.Drawing.Size(341, 60);
        this.btnAdd.TabIndex = 140;
        this.btnAdd.Text = "Add New Appointment";
        this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
        this.btnEdit,
        this.btnDelete,
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
        this.grdAppointment.Location = new System.Drawing.Point(37, 353);
        this.grdAppointment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
        this.grdAppointment.Name = "grdAppointment";
        this.grdAppointment.ReadOnly = true;
        this.grdAppointment.RowHeadersVisible = false;
        this.grdAppointment.RowHeadersWidth = 51;
        this.grdAppointment.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
        this.grdAppointment.RowTemplate.Height = 40;
        this.grdAppointment.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
        this.grdAppointment.Size = new System.Drawing.Size(1159, 475);
        this.grdAppointment.TabIndex = 149;
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
        // btnEdit
        // 
        this.btnEdit.FillWeight = 25F;
        this.btnEdit.HeaderText = "";
        this.btnEdit.MinimumWidth = 6;
        this.btnEdit.Name = "btnEdit";
        this.btnEdit.ReadOnly = true;
        this.btnEdit.Visible = false;
        // 
        // btnDelete
        // 
        this.btnDelete.FillWeight = 25F;
        this.btnDelete.HeaderText = "";
        this.btnDelete.MinimumWidth = 6;
        this.btnDelete.Name = "btnDelete";
        this.btnDelete.ReadOnly = true;
        this.btnDelete.Visible = false;
        // 
        // btnApprove
        // 
        this.btnApprove.FillWeight = 74.18671F;
        this.btnApprove.HeaderText = "";
        this.btnApprove.MinimumWidth = 6;
        this.btnApprove.Name = "btnApprove";
        this.btnApprove.ReadOnly = true;
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
        this.txtSearch.Location = new System.Drawing.Point(37, 138);
        this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
        this.txtSearch.Name = "txtSearch";
        this.txtSearch.PasswordChar = '\0';
        this.txtSearch.PlaceholderText = "Search Appoinments";
        this.txtSearch.SelectedText = "";
        this.txtSearch.Size = new System.Drawing.Size(411, 44);
        this.txtSearch.TabIndex = 150;
        this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
        // 
        // btnFilterApprove
        // 
        this.btnFilterApprove.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
        this.btnFilterApprove.BorderRadius = 15;
        this.btnFilterApprove.BorderThickness = 1;
        this.btnFilterApprove.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
        this.btnFilterApprove.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
        this.btnFilterApprove.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
        this.btnFilterApprove.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
        this.btnFilterApprove.FillColor = System.Drawing.Color.White;
        this.btnFilterApprove.Font = new System.Drawing.Font("IBM Plex Sans", 9F);
        this.btnFilterApprove.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(42)))));
        this.btnFilterApprove.Location = new System.Drawing.Point(37, 229);
        this.btnFilterApprove.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
        this.btnFilterApprove.Name = "btnFilterApprove";
        this.btnFilterApprove.Size = new System.Drawing.Size(145, 41);
        this.btnFilterApprove.TabIndex = 151;
        this.btnFilterApprove.Text = "Approved";
        this.btnFilterApprove.Click += new System.EventHandler(this.btnFilterApprove_Click);
        // 
        // btnPending
        // 
        this.btnPending.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
        this.btnPending.BorderRadius = 15;
        this.btnPending.BorderThickness = 1;
        this.btnPending.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
        this.btnPending.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
        this.btnPending.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
        this.btnPending.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
        this.btnPending.FillColor = System.Drawing.Color.White;
        this.btnPending.Font = new System.Drawing.Font("IBM Plex Sans", 9F);
        this.btnPending.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(42)))));
        this.btnPending.Location = new System.Drawing.Point(203, 229);
        this.btnPending.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
        this.btnPending.Name = "btnPending";
        this.btnPending.Size = new System.Drawing.Size(145, 41);
        this.btnPending.TabIndex = 151;
        this.btnPending.Text = "Pending";
        this.btnPending.Click += new System.EventHandler(this.btnPending_Click);
        // 
        // btnCancelled
        // 
        this.btnCancelled.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
        this.btnCancelled.BorderRadius = 15;
        this.btnCancelled.BorderThickness = 1;
        this.btnCancelled.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
        this.btnCancelled.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
        this.btnCancelled.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
        this.btnCancelled.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
        this.btnCancelled.FillColor = System.Drawing.Color.White;
        this.btnCancelled.Font = new System.Drawing.Font("IBM Plex Sans", 9F);
        this.btnCancelled.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(42)))));
        this.btnCancelled.Location = new System.Drawing.Point(367, 229);
        this.btnCancelled.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
        this.btnCancelled.Name = "btnCancelled";
        this.btnCancelled.Size = new System.Drawing.Size(145, 41);
        this.btnCancelled.TabIndex = 151;
        this.btnCancelled.Text = "Cancelled";
        this.btnCancelled.Click += new System.EventHandler(this.btnCancelled_Click);
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
        "This Year"});
        this.cboFilter.ItemsAppearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.cboFilter.ItemsAppearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(42)))));
        this.cboFilter.Location = new System.Drawing.Point(1004, 209);
        this.cboFilter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
        this.cboFilter.Name = "cboFilter";
        this.cboFilter.Size = new System.Drawing.Size(156, 36);
        this.cboFilter.StartIndex = 1;
        this.cboFilter.TabIndex = 152;
        this.cboFilter.TextOffset = new System.Drawing.Point(10, 2);
        this.cboFilter.SelectedIndexChanged += new System.EventHandler(this.cboFilter_SelectedIndexChanged);
        // 
        // frmSecretaryAppointment
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.AutoScroll = true;
        this.BackColor = System.Drawing.Color.White;
        this.ClientSize = new System.Drawing.Size(1249, 903);
        this.Controls.Add(this.cboFilter);
        this.Controls.Add(this.btnCancelled);
        this.Controls.Add(this.btnPending);
        this.Controls.Add(this.btnFilterApprove);
        this.Controls.Add(this.txtSearch);
        this.Controls.Add(this.grdAppointment);
        this.Controls.Add(this.btnAdd);
        this.Controls.Add(this.lblReport);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
        this.Name = "frmSecretaryAppointment";
        this.Text = "frmDoctorDashboard";
        ((System.ComponentModel.ISupportInitialize)(this.grdAppointment)).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    #endregion
    private Bunifu.UI.WinForms.BunifuLabel lblReport;
    private Guna.UI2.WinForms.Guna2Button btnAdd;
    private Guna.UI2.WinForms.Guna2DataGridView grdAppointment;
    private Guna.UI2.WinForms.Guna2TextBox txtSearch;
    private Guna.UI2.WinForms.Guna2Button btnFilterApprove;
    private Guna.UI2.WinForms.Guna2Button btnPending;
    private Guna.UI2.WinForms.Guna2Button btnCancelled;
    private Guna.UI2.WinForms.Guna2ComboBox cboFilter;
    private System.Windows.Forms.DataGridViewTextBoxColumn id;
    private System.Windows.Forms.DataGridViewTextBoxColumn fullname;
    private System.Windows.Forms.DataGridViewTextBoxColumn mobileno;
    private System.Windows.Forms.DataGridViewTextBoxColumn gender;
    private System.Windows.Forms.DataGridViewTextBoxColumn btnEdit;
    private System.Windows.Forms.DataGridViewTextBoxColumn btnDelete;
    private System.Windows.Forms.DataGridViewTextBoxColumn btnApprove;
}