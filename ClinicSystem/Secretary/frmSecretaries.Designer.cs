namespace ClinicSystem
{
    partial class frmSecretaries
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grdSecretaries = new Guna.UI2.WinForms.Guna2DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDeleteSecretary = new Guna.UI2.WinForms.Guna2Button();
            this.btnEditSecretary = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddSecretary = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdSecretaries)).BeginInit();
            this.SuspendLayout();
            // 
            // grdSecretaries
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.grdSecretaries.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.grdSecretaries.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdSecretaries.BackgroundColor = System.Drawing.Color.White;
            this.grdSecretaries.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdSecretaries.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grdSecretaries.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdSecretaries.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.grdSecretaries.ColumnHeadersHeight = 52;
            this.grdSecretaries.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.firstname,
            this.lastname,
            this.gender,
            this.birthdate,
            this.email,
            this.mobileno,
            this.address});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(184)))), ((int)(((byte)(169)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdSecretaries.DefaultCellStyle = dataGridViewCellStyle9;
            this.grdSecretaries.EnableHeadersVisualStyles = false;
            this.grdSecretaries.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.grdSecretaries.Location = new System.Drawing.Point(61, 162);
            this.grdSecretaries.Name = "grdSecretaries";
            this.grdSecretaries.RowHeadersVisible = false;
            this.grdSecretaries.RowHeadersWidth = 51;
            this.grdSecretaries.RowTemplate.Height = 24;
            this.grdSecretaries.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdSecretaries.Size = new System.Drawing.Size(1175, 541);
            this.grdSecretaries.TabIndex = 6;
            this.grdSecretaries.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.White;
            this.grdSecretaries.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.grdSecretaries.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.grdSecretaries.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.grdSecretaries.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.grdSecretaries.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.grdSecretaries.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.grdSecretaries.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.grdSecretaries.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(75)))));
            this.grdSecretaries.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grdSecretaries.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.grdSecretaries.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.grdSecretaries.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.grdSecretaries.ThemeStyle.HeaderStyle.Height = 52;
            this.grdSecretaries.ThemeStyle.ReadOnly = false;
            this.grdSecretaries.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.grdSecretaries.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grdSecretaries.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.grdSecretaries.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.grdSecretaries.ThemeStyle.RowsStyle.Height = 24;
            this.grdSecretaries.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(184)))), ((int)(((byte)(169)))));
            this.grdSecretaries.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            // 
            // firstname
            // 
            this.firstname.HeaderText = "First Name";
            this.firstname.MinimumWidth = 6;
            this.firstname.Name = "firstname";
            // 
            // lastname
            // 
            this.lastname.HeaderText = "Last Name";
            this.lastname.MinimumWidth = 6;
            this.lastname.Name = "lastname";
            // 
            // gender
            // 
            this.gender.HeaderText = "Gender";
            this.gender.MinimumWidth = 6;
            this.gender.Name = "gender";
            // 
            // birthdate
            // 
            this.birthdate.HeaderText = "Birthdate";
            this.birthdate.MinimumWidth = 6;
            this.birthdate.Name = "birthdate";
            // 
            // email
            // 
            this.email.HeaderText = "Email";
            this.email.MinimumWidth = 6;
            this.email.Name = "email";
            // 
            // mobileno
            // 
            this.mobileno.HeaderText = "Contact Number";
            this.mobileno.MinimumWidth = 6;
            this.mobileno.Name = "mobileno";
            // 
            // address
            // 
            this.address.HeaderText = "Address";
            this.address.MinimumWidth = 6;
            this.address.Name = "address";
            // 
            // btnDeleteSecretary
            // 
            this.btnDeleteSecretary.CheckedState.Parent = this.btnDeleteSecretary;
            this.btnDeleteSecretary.CustomImages.Parent = this.btnDeleteSecretary;
            this.btnDeleteSecretary.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(22)))), ((int)(((byte)(86)))));
            this.btnDeleteSecretary.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDeleteSecretary.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteSecretary.HoverState.Parent = this.btnDeleteSecretary;
            this.btnDeleteSecretary.Location = new System.Drawing.Point(1086, 759);
            this.btnDeleteSecretary.Name = "btnDeleteSecretary";
            this.btnDeleteSecretary.ShadowDecoration.Parent = this.btnDeleteSecretary;
            this.btnDeleteSecretary.Size = new System.Drawing.Size(150, 45);
            this.btnDeleteSecretary.TabIndex = 7;
            this.btnDeleteSecretary.Text = "DELETE";
            this.btnDeleteSecretary.Click += new System.EventHandler(this.btnDeleteSecretary_Click);
            // 
            // btnEditSecretary
            // 
            this.btnEditSecretary.CheckedState.Parent = this.btnEditSecretary;
            this.btnEditSecretary.CustomImages.Parent = this.btnEditSecretary;
            this.btnEditSecretary.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(184)))), ((int)(((byte)(169)))));
            this.btnEditSecretary.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEditSecretary.ForeColor = System.Drawing.Color.Black;
            this.btnEditSecretary.HoverState.Parent = this.btnEditSecretary;
            this.btnEditSecretary.Location = new System.Drawing.Point(916, 759);
            this.btnEditSecretary.Name = "btnEditSecretary";
            this.btnEditSecretary.ShadowDecoration.Parent = this.btnEditSecretary;
            this.btnEditSecretary.Size = new System.Drawing.Size(150, 45);
            this.btnEditSecretary.TabIndex = 8;
            this.btnEditSecretary.Text = "EDIT";
            this.btnEditSecretary.Click += new System.EventHandler(this.btnEditSecretary_Click);
            // 
            // btnAddSecretary
            // 
            this.btnAddSecretary.CheckedState.Parent = this.btnAddSecretary;
            this.btnAddSecretary.CustomImages.Parent = this.btnAddSecretary;
            this.btnAddSecretary.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(184)))), ((int)(((byte)(169)))));
            this.btnAddSecretary.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddSecretary.ForeColor = System.Drawing.Color.Black;
            this.btnAddSecretary.HoverState.Parent = this.btnAddSecretary;
            this.btnAddSecretary.Location = new System.Drawing.Point(742, 759);
            this.btnAddSecretary.Name = "btnAddSecretary";
            this.btnAddSecretary.ShadowDecoration.Parent = this.btnAddSecretary;
            this.btnAddSecretary.Size = new System.Drawing.Size(150, 45);
            this.btnAddSecretary.TabIndex = 9;
            this.btnAddSecretary.Text = "ADD";
            this.btnAddSecretary.Click += new System.EventHandler(this.btnAddSecretary_Click);
            // 
            // frmSecretaries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1296, 967);
            this.Controls.Add(this.grdSecretaries);
            this.Controls.Add(this.btnDeleteSecretary);
            this.Controls.Add(this.btnEditSecretary);
            this.Controls.Add(this.btnAddSecretary);
            this.Name = "frmSecretaries";
            this.Text = "frmSecretaries";
            this.Load += new System.EventHandler(this.frmSecretaries_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdSecretaries)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView grdSecretaries;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstname;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileno;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private Guna.UI2.WinForms.Guna2Button btnDeleteSecretary;
        private Guna.UI2.WinForms.Guna2Button btnEditSecretary;
        private Guna.UI2.WinForms.Guna2Button btnAddSecretary;
    }
}