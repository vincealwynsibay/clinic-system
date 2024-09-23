namespace ClinicSystem
{
    partial class frmDoctors
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
            this.grdDoctors = new Guna.UI2.WinForms.Guna2DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddDoctor = new Guna.UI2.WinForms.Guna2Button();
            this.btnEditDoctor = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteDoctor = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdDoctors)).BeginInit();
            this.SuspendLayout();
            // 
            // grdDoctors
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.grdDoctors.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grdDoctors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdDoctors.BackgroundColor = System.Drawing.Color.White;
            this.grdDoctors.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdDoctors.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grdDoctors.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdDoctors.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdDoctors.ColumnHeadersHeight = 52;
            this.grdDoctors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.firstname,
            this.lastname,
            this.gender,
            this.birthdate,
            this.email,
            this.mobileno,
            this.address});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(184)))), ((int)(((byte)(169)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdDoctors.DefaultCellStyle = dataGridViewCellStyle3;
            this.grdDoctors.EnableHeadersVisualStyles = false;
            this.grdDoctors.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.grdDoctors.Location = new System.Drawing.Point(49, 165);
            this.grdDoctors.Name = "grdDoctors";
            this.grdDoctors.RowHeadersVisible = false;
            this.grdDoctors.RowHeadersWidth = 51;
            this.grdDoctors.RowTemplate.Height = 24;
            this.grdDoctors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdDoctors.Size = new System.Drawing.Size(1175, 541);
            this.grdDoctors.TabIndex = 4;
            this.grdDoctors.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.White;
            this.grdDoctors.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.grdDoctors.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.grdDoctors.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.grdDoctors.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.grdDoctors.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.grdDoctors.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.grdDoctors.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.grdDoctors.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(75)))));
            this.grdDoctors.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grdDoctors.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.grdDoctors.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.grdDoctors.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.grdDoctors.ThemeStyle.HeaderStyle.Height = 52;
            this.grdDoctors.ThemeStyle.ReadOnly = false;
            this.grdDoctors.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.grdDoctors.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grdDoctors.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.grdDoctors.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.grdDoctors.ThemeStyle.RowsStyle.Height = 24;
            this.grdDoctors.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(184)))), ((int)(((byte)(169)))));
            this.grdDoctors.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
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
            // btnAddDoctor
            // 
            this.btnAddDoctor.CheckedState.Parent = this.btnAddDoctor;
            this.btnAddDoctor.CustomImages.Parent = this.btnAddDoctor;
            this.btnAddDoctor.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(184)))), ((int)(((byte)(169)))));
            this.btnAddDoctor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddDoctor.ForeColor = System.Drawing.Color.Black;
            this.btnAddDoctor.HoverState.Parent = this.btnAddDoctor;
            this.btnAddDoctor.Location = new System.Drawing.Point(730, 762);
            this.btnAddDoctor.Name = "btnAddDoctor";
            this.btnAddDoctor.ShadowDecoration.Parent = this.btnAddDoctor;
            this.btnAddDoctor.Size = new System.Drawing.Size(150, 45);
            this.btnAddDoctor.TabIndex = 5;
            this.btnAddDoctor.Text = "ADD";
            this.btnAddDoctor.Click += new System.EventHandler(this.btnAddDoctor_Click);
            // 
            // btnEditDoctor
            // 
            this.btnEditDoctor.CheckedState.Parent = this.btnEditDoctor;
            this.btnEditDoctor.CustomImages.Parent = this.btnEditDoctor;
            this.btnEditDoctor.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(184)))), ((int)(((byte)(169)))));
            this.btnEditDoctor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEditDoctor.ForeColor = System.Drawing.Color.Black;
            this.btnEditDoctor.HoverState.Parent = this.btnEditDoctor;
            this.btnEditDoctor.Location = new System.Drawing.Point(904, 762);
            this.btnEditDoctor.Name = "btnEditDoctor";
            this.btnEditDoctor.ShadowDecoration.Parent = this.btnEditDoctor;
            this.btnEditDoctor.Size = new System.Drawing.Size(150, 45);
            this.btnEditDoctor.TabIndex = 5;
            this.btnEditDoctor.Text = "EDIT";
            this.btnEditDoctor.Click += new System.EventHandler(this.btnEditDoctor_Click);
            // 
            // btnDeleteDoctor
            // 
            this.btnDeleteDoctor.CheckedState.Parent = this.btnDeleteDoctor;
            this.btnDeleteDoctor.CustomImages.Parent = this.btnDeleteDoctor;
            this.btnDeleteDoctor.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(22)))), ((int)(((byte)(86)))));
            this.btnDeleteDoctor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDeleteDoctor.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteDoctor.HoverState.Parent = this.btnDeleteDoctor;
            this.btnDeleteDoctor.Location = new System.Drawing.Point(1074, 762);
            this.btnDeleteDoctor.Name = "btnDeleteDoctor";
            this.btnDeleteDoctor.ShadowDecoration.Parent = this.btnDeleteDoctor;
            this.btnDeleteDoctor.Size = new System.Drawing.Size(150, 45);
            this.btnDeleteDoctor.TabIndex = 5;
            this.btnDeleteDoctor.Text = "DELETE";
            this.btnDeleteDoctor.Click += new System.EventHandler(this.btnDeleteDoctor_Click);
            // 
            // frmDoctors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1296, 967);
            this.Controls.Add(this.btnDeleteDoctor);
            this.Controls.Add(this.btnEditDoctor);
            this.Controls.Add(this.btnAddDoctor);
            this.Controls.Add(this.grdDoctors);
            this.Name = "frmDoctors";
            this.Text = "s";
            this.Load += new System.EventHandler(this.frmDoctors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdDoctors)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2DataGridView grdDoctors;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstname;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileno;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private Guna.UI2.WinForms.Guna2Button btnAddDoctor;
        private Guna.UI2.WinForms.Guna2Button btnEditDoctor;
        private Guna.UI2.WinForms.Guna2Button btnDeleteDoctor;
    }
}