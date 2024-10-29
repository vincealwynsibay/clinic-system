namespace ClinicSystem
{
    partial class frmPrescription
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrescription));
            this.grdPrescription = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEdit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.btnPrint = new Guna.UI2.WinForms.Guna2Button();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.lblPatient = new Bunifu.UI.WinForms.BunifuLabel();
            ((System.ComponentModel.ISupportInitialize)(this.grdPrescription)).BeginInit();
            this.SuspendLayout();
            // 
            // grdPrescription
            // 
            this.grdPrescription.AllowUserToAddRows = false;
            this.grdPrescription.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.grdPrescription.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("IBM Plex Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdPrescription.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdPrescription.ColumnHeadersHeight = 24;
            this.grdPrescription.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column1,
            this.Column3,
            this.Column4,
            this.Column5,
            this.btnEdit,
            this.btnDelete,
            this.id});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdPrescription.DefaultCellStyle = dataGridViewCellStyle3;
            this.grdPrescription.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.grdPrescription.Location = new System.Drawing.Point(28, 151);
            this.grdPrescription.Margin = new System.Windows.Forms.Padding(2);
            this.grdPrescription.Name = "grdPrescription";
            this.grdPrescription.ReadOnly = true;
            this.grdPrescription.RowHeadersVisible = false;
            this.grdPrescription.RowHeadersWidth = 51;
            this.grdPrescription.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdPrescription.RowTemplate.Height = 40;
            this.grdPrescription.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.grdPrescription.Size = new System.Drawing.Size(810, 484);
            this.grdPrescription.TabIndex = 150;
            this.grdPrescription.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.WhiteGrid;
            this.grdPrescription.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.grdPrescription.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.grdPrescription.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.grdPrescription.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.grdPrescription.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.grdPrescription.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.grdPrescription.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.grdPrescription.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.White;
            this.grdPrescription.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grdPrescription.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("IBM Plex Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdPrescription.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.grdPrescription.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grdPrescription.ThemeStyle.HeaderStyle.Height = 24;
            this.grdPrescription.ThemeStyle.ReadOnly = true;
            this.grdPrescription.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.grdPrescription.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grdPrescription.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.grdPrescription.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.grdPrescription.ThemeStyle.RowsStyle.Height = 40;
            this.grdPrescription.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.grdPrescription.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 30F;
            this.Column2.HeaderText = "Qty.";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Medicine";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Dosage";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Frequency";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Comment";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
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
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(75)))));
            this.btnCancel.BorderRadius = 6;
            this.btnCancel.BorderThickness = 2;
            this.btnCancel.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(75)))));
            this.btnCancel.FillColor = System.Drawing.Color.White;
            this.btnCancel.Font = new System.Drawing.Font("IBM Plex Sans", 9F);
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(75)))));
            this.btnCancel.Location = new System.Drawing.Point(126, 659);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 81);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(274, 37);
            this.btnCancel.TabIndex = 163;
            this.btnCancel.Text = "Go Back";
            this.btnCancel.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BorderRadius = 6;
            this.btnPrint.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(75)))));
            this.btnPrint.Font = new System.Drawing.Font("IBM Plex Sans", 9F);
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Image = global::ClinicSystem.Properties.Resources.icn_print;
            this.btnPrint.Location = new System.Drawing.Point(458, 659);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(2, 2, 2, 81);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(274, 37);
            this.btnPrint.TabIndex = 162;
            this.btnPrint.Text = "Print";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BorderRadius = 5;
            this.btnAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(75)))));
            this.btnAdd.Font = new System.Drawing.Font("IBM Plex Sans", 12F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Image = global::ClinicSystem.Properties.Resources.plus;
            this.btnAdd.ImageOffset = new System.Drawing.Point(-5, 0);
            this.btnAdd.Location = new System.Drawing.Point(582, 22);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(256, 49);
            this.btnAdd.TabIndex = 165;
            this.btnAdd.Text = "Add New Prescription";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            this.lblPatient.Size = new System.Drawing.Size(184, 43);
            this.lblPatient.TabIndex = 164;
            this.lblPatient.Text = "Prescription";
            this.lblPatient.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPatient.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // frmPrescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(855, 743);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblPatient);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.grdPrescription);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPrescription";
            this.Text = "frmDoctorPatientPerscription";
            ((System.ComponentModel.ISupportInitialize)(this.grdPrescription)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView grdPrescription;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2Button btnPrint;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn btnEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Bunifu.UI.WinForms.BunifuLabel lblPatient;
    }
}