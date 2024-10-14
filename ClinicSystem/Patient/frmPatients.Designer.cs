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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPatients));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.grdPatients = new Guna.UI2.WinForms.Guna2DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maritalstatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emergencyno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearch = new Bunifu.UI.WinForms.BunifuTextBox();
            this.cboSearch = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cboFilter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblFilter = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.lblTotal = new Bunifu.UI.WinForms.BunifuLabel();
            ((System.ComponentModel.ISupportInitialize)(this.grdPatients)).BeginInit();
            this.bunifuPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdPatients
            // 
            this.grdPatients.AllowUserToAddRows = false;
            this.grdPatients.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.grdPatients.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdPatients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdPatients.ColumnHeadersHeight = 52;
            this.grdPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.grdPatients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.fullname,
            this.birthdate,
            this.gender,
            this.mobileno,
            this.email,
            this.maritalstatus,
            this.emergencyno});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(184)))), ((int)(((byte)(169)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdPatients.DefaultCellStyle = dataGridViewCellStyle3;
            this.grdPatients.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.grdPatients.Location = new System.Drawing.Point(55, 118);
            this.grdPatients.Margin = new System.Windows.Forms.Padding(2);
            this.grdPatients.Name = "grdPatients";
            this.grdPatients.ReadOnly = true;
            this.grdPatients.RowHeadersVisible = false;
            this.grdPatients.RowHeadersWidth = 51;
            this.grdPatients.RowTemplate.Height = 24;
            this.grdPatients.Size = new System.Drawing.Size(881, 604);
            this.grdPatients.TabIndex = 7;
            this.grdPatients.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.White;
            this.grdPatients.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.grdPatients.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.grdPatients.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.grdPatients.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.grdPatients.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.grdPatients.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.grdPatients.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.grdPatients.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(75)))));
            this.grdPatients.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grdPatients.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.grdPatients.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.grdPatients.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.grdPatients.ThemeStyle.HeaderStyle.Height = 52;
            this.grdPatients.ThemeStyle.ReadOnly = true;
            this.grdPatients.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.grdPatients.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grdPatients.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.grdPatients.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.grdPatients.ThemeStyle.RowsStyle.Height = 24;
            this.grdPatients.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(184)))), ((int)(((byte)(169)))));
            this.grdPatients.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
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
            // maritalstatus
            // 
            this.maritalstatus.HeaderText = "Marital Status";
            this.maritalstatus.Name = "maritalstatus";
            this.maritalstatus.ReadOnly = true;
            // 
            // emergencyno
            // 
            this.emergencyno.HeaderText = "Emergency No.";
            this.emergencyno.Name = "emergencyno";
            this.emergencyno.ReadOnly = true;
            // 
            // txtSearch
            // 
            this.txtSearch.AcceptsReturn = false;
            this.txtSearch.AcceptsTab = false;
            this.txtSearch.AnimationSpeed = 200;
            this.txtSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtSearch.AutoSizeHeight = true;
            this.txtSearch.BackColor = System.Drawing.Color.Transparent;
            this.txtSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtSearch.BackgroundImage")));
            this.txtSearch.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtSearch.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtSearch.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtSearch.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtSearch.BorderRadius = 1;
            this.txtSearch.BorderThickness = 1;
            this.txtSearch.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            this.txtSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtSearch.DefaultText = "";
            this.txtSearch.FillColor = System.Drawing.Color.White;
            this.txtSearch.HideSelection = true;
            this.txtSearch.IconLeft = null;
            this.txtSearch.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.IconPadding = 10;
            this.txtSearch.IconRight = null;
            this.txtSearch.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.Lines = new string[0];
            this.txtSearch.Location = new System.Drawing.Point(55, 63);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtSearch.Modified = false;
            this.txtSearch.Multiline = false;
            this.txtSearch.Name = "txtSearch";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtSearch.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtSearch.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtSearch.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtSearch.OnIdleState = stateProperties4;
            this.txtSearch.Padding = new System.Windows.Forms.Padding(3);
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtSearch.PlaceholderText = "Search";
            this.txtSearch.ReadOnly = false;
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.Size = new System.Drawing.Size(419, 39);
            this.txtSearch.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtSearch.TabIndex = 8;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSearch.TextMarginBottom = 0;
            this.txtSearch.TextMarginLeft = 3;
            this.txtSearch.TextMarginTop = 1;
            this.txtSearch.TextPlaceholder = "Search";
            this.txtSearch.UseSystemPasswordChar = false;
            this.txtSearch.WordWrap = true;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // cboSearch
            // 
            this.cboSearch.AllowDrop = true;
            this.cboSearch.BackColor = System.Drawing.Color.Transparent;
            this.cboSearch.BorderColor = System.Drawing.Color.Silver;
            this.cboSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboSearch.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSearch.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboSearch.ItemHeight = 30;
            this.cboSearch.Items.AddRange(new object[] {
            "ID",
            "Name"});
            this.cboSearch.Location = new System.Drawing.Point(480, 64);
            this.cboSearch.Name = "cboSearch";
            this.cboSearch.Size = new System.Drawing.Size(115, 36);
            this.cboSearch.StartIndex = 0;
            this.cboSearch.TabIndex = 9;
            // 
            // cboFilter
            // 
            this.cboFilter.AllowDrop = true;
            this.cboFilter.BackColor = System.Drawing.Color.Transparent;
            this.cboFilter.BorderColor = System.Drawing.Color.Silver;
            this.cboFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFilter.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboFilter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboFilter.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboFilter.ItemHeight = 30;
            this.cboFilter.Items.AddRange(new object[] {
            "(None)",
            "Today",
            "This Week",
            "This Month",
            "This Year"});
            this.cboFilter.Location = new System.Drawing.Point(821, 64);
            this.cboFilter.Name = "cboFilter";
            this.cboFilter.Size = new System.Drawing.Size(115, 36);
            this.cboFilter.StartIndex = 0;
            this.cboFilter.TabIndex = 9;
            this.cboFilter.SelectedIndexChanged += new System.EventHandler(this.cboFilter_SelectedIndexChanged);
            // 
            // lblFilter
            // 
            this.lblFilter.AllowParentOverrides = false;
            this.lblFilter.AutoEllipsis = false;
            this.lblFilter.CursorType = null;
            this.lblFilter.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(75)))));
            this.lblFilter.Location = new System.Drawing.Point(738, 70);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblFilter.Size = new System.Drawing.Size(74, 21);
            this.lblFilter.TabIndex = 10;
            this.lblFilter.Text = "Filter Date:";
            this.lblFilter.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblFilter.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(75)))));
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 3;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.btnAdd);
            this.bunifuPanel1.Controls.Add(this.lblTotal);
            this.bunifuPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bunifuPanel1.Location = new System.Drawing.Point(0, 744);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(990, 46);
            this.bunifuPanel1.TabIndex = 95;
            // 
            // btnAdd
            // 
            this.btnAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(92)))), ((int)(((byte)(126)))));
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Image = global::ClinicSystem.Properties.Resources.icnAddUser;
            this.btnAdd.Location = new System.Drawing.Point(861, 7);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 32);
            this.btnAdd.TabIndex = 121;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AllowParentOverrides = false;
            this.lblTotal.AutoEllipsis = false;
            this.lblTotal.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblTotal.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.White;
            this.lblTotal.Location = new System.Drawing.Point(55, 9);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(2);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTotal.Size = new System.Drawing.Size(126, 25);
            this.lblTotal.TabIndex = 39;
            this.lblTotal.Text = "Total Patients:";
            this.lblTotal.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTotal.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // frmPatients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(990, 790);
            this.Controls.Add(this.bunifuPanel1);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.cboFilter);
            this.Controls.Add(this.cboSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.grdPatients);
            this.Name = "frmPatients";
            this.Text = "frmPatients";
            ((System.ComponentModel.ISupportInitialize)(this.grdPatients)).EndInit();
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView grdPatients;
        private Bunifu.UI.WinForms.BunifuTextBox txtSearch;
        private Guna.UI2.WinForms.Guna2ComboBox cboSearch;
        private Guna.UI2.WinForms.Guna2ComboBox cboFilter;
        private Bunifu.UI.WinForms.BunifuLabel lblFilter;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private Bunifu.UI.WinForms.BunifuLabel lblTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullname;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileno;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn maritalstatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn emergencyno;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
    }
}