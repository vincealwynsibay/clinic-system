namespace ClinicSystem.DoctorMain
{
    partial class frmPatients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPatients));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cboFilter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblFilter = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblPatient = new Bunifu.UI.WinForms.BunifuLabel();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.grdPatients = new Guna.UI2.WinForms.Guna2DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEdit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdPatients)).BeginInit();
            this.SuspendLayout();
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
            this.cboFilter.Font = new System.Drawing.Font("IBM Plex Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(42)))));
            this.cboFilter.ItemHeight = 30;
            this.cboFilter.Items.AddRange(new object[] {
            "(None)",
            "Today",
            "This Week",
            "This Month",
            "This Year"});
            this.cboFilter.ItemsAppearance.Font = new System.Drawing.Font("IBM Plex Sans Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFilter.ItemsAppearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(42)))));
            this.cboFilter.Location = new System.Drawing.Point(761, 125);
            this.cboFilter.Name = "cboFilter";
            this.cboFilter.Size = new System.Drawing.Size(115, 36);
            this.cboFilter.StartIndex = 0;
            this.cboFilter.TabIndex = 9;
            this.cboFilter.TextOffset = new System.Drawing.Point(10, 2);
            this.cboFilter.Visible = false;
            this.cboFilter.SelectedIndexChanged += new System.EventHandler(this.cboFilter_SelectedIndexChanged);
            // 
            // lblFilter
            // 
            this.lblFilter.AllowParentOverrides = false;
            this.lblFilter.AutoEllipsis = false;
            this.lblFilter.CursorType = null;
            this.lblFilter.Font = new System.Drawing.Font("IBM Plex Sans SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.lblFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(75)))));
            this.lblFilter.Location = new System.Drawing.Point(671, 133);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblFilter.Size = new System.Drawing.Size(83, 20);
            this.lblFilter.TabIndex = 10;
            this.lblFilter.Text = "Filter Date:";
            this.lblFilter.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblFilter.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.lblFilter.Visible = false;
            // 
            // lblPatient
            // 
            this.lblPatient.AllowParentOverrides = false;
            this.lblPatient.AutoEllipsis = false;
            this.lblPatient.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblPatient.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblPatient.Font = new System.Drawing.Font("IBM Plex Sans", 24F, System.Drawing.FontStyle.Bold);
            this.lblPatient.ForeColor = System.Drawing.Color.Black;
            this.lblPatient.Location = new System.Drawing.Point(28, 22);
            this.lblPatient.Margin = new System.Windows.Forms.Padding(2);
            this.lblPatient.Name = "lblPatient";
            this.lblPatient.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPatient.Size = new System.Drawing.Size(125, 43);
            this.lblPatient.TabIndex = 96;
            this.lblPatient.Text = "Patients";
            this.lblPatient.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPatient.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // btnAdd
            // 
            this.btnAdd.BorderRadius = 5;
            this.btnAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(75)))));
            this.btnAdd.Font = new System.Drawing.Font("IBM Plex Sans SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Image = global::ClinicSystem.Properties.Resources.plus;
            this.btnAdd.ImageOffset = new System.Drawing.Point(-5, 0);
            this.btnAdd.Location = new System.Drawing.Point(641, 22);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(256, 49);
            this.btnAdd.TabIndex = 141;
            this.btnAdd.Text = "Add New Patient";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            this.txtSearch.Location = new System.Drawing.Point(28, 125);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "Search Patient";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(299, 36);
            this.txtSearch.TabIndex = 151;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // grdPatients
            // 
            this.grdPatients.AllowUserToAddRows = false;
            this.grdPatients.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.grdPatients.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("IBM Plex Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdPatients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grdPatients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.fullname,
            this.birthdate,
            this.gender,
            this.mobileno,
            this.email,
            this.btnEdit,
            this.btnDelete});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("IBM Plex Sans", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdPatients.DefaultCellStyle = dataGridViewCellStyle3;
            this.grdPatients.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.grdPatients.Location = new System.Drawing.Point(28, 180);
            this.grdPatients.Margin = new System.Windows.Forms.Padding(2);
            this.grdPatients.Name = "grdPatients";
            this.grdPatients.ReadOnly = true;
            this.grdPatients.RowHeadersVisible = false;
            this.grdPatients.RowHeadersWidth = 51;
            this.grdPatients.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdPatients.RowTemplate.Height = 40;
            this.grdPatients.Size = new System.Drawing.Size(869, 520);
            this.grdPatients.TabIndex = 152;
            this.grdPatients.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.WhiteGrid;
            this.grdPatients.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.grdPatients.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.grdPatients.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.grdPatients.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.White;
            this.grdPatients.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grdPatients.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("IBM Plex Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdPatients.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.grdPatients.ThemeStyle.HeaderStyle.Height = 24;
            this.grdPatients.ThemeStyle.ReadOnly = true;
            this.grdPatients.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.grdPatients.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grdPatients.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("IBM Plex Sans", 10.5F);
            this.grdPatients.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.grdPatients.ThemeStyle.RowsStyle.Height = 40;
            this.grdPatients.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.grdPatients.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.grdPatients.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdPatients_CellContentDoubleClick);
            // 
            // id
            // 
            this.id.HeaderText = "Patient ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // fullname
            // 
            this.fullname.HeaderText = "Full Name";
            this.fullname.MinimumWidth = 6;
            this.fullname.Name = "fullname";
            this.fullname.ReadOnly = true;
            // 
            // birthdate
            // 
            this.birthdate.HeaderText = "Birthdate";
            this.birthdate.MinimumWidth = 6;
            this.birthdate.Name = "birthdate";
            this.birthdate.ReadOnly = true;
            // 
            // gender
            // 
            this.gender.HeaderText = "Gender";
            this.gender.Name = "gender";
            this.gender.ReadOnly = true;
            // 
            // mobileno
            // 
            this.mobileno.HeaderText = "Mobile No.";
            this.mobileno.Name = "mobileno";
            this.mobileno.ReadOnly = true;
            // 
            // email
            // 
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // btnEdit
            // 
            this.btnEdit.FillWeight = 25F;
            this.btnEdit.HeaderText = "";
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.ReadOnly = true;
            // 
            // btnDelete
            // 
            this.btnDelete.FillWeight = 25F;
            this.btnDelete.HeaderText = "";
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ReadOnly = true;
            // 
            // frmPatients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(937, 734);
            this.Controls.Add(this.grdPatients);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblPatient);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.cboFilter);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPatients";
            this.Text = "frmPatients";
            ((System.ComponentModel.ISupportInitialize)(this.grdPatients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ComboBox cboFilter;
        private Bunifu.UI.WinForms.BunifuLabel lblFilter;
        private Bunifu.UI.WinForms.BunifuLabel lblPatient;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2DataGridView grdPatients;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullname;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileno;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn btnEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn btnDelete;
    }
}