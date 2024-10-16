namespace ClinicSystem.Dashboard
{
    partial class frmDashboardAppointment
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
            this.grdAppointment = new Guna.UI2.WinForms.Guna2DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnApprove = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdAppointment)).BeginInit();
            this.SuspendLayout();
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
            this.grdAppointment.Location = new System.Drawing.Point(0, 0);
            this.grdAppointment.Margin = new System.Windows.Forms.Padding(2);
            this.grdAppointment.Name = "grdAppointment";
            this.grdAppointment.ReadOnly = true;
            this.grdAppointment.RowHeadersVisible = false;
            this.grdAppointment.RowHeadersWidth = 51;
            this.grdAppointment.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdAppointment.RowTemplate.Height = 40;
            this.grdAppointment.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.grdAppointment.Size = new System.Drawing.Size(869, 296);
            this.grdAppointment.TabIndex = 150;
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
            this.mobileno.Name = "mobileno";
            this.mobileno.ReadOnly = true;
            // 
            // gender
            // 
            this.gender.FillWeight = 74.18671F;
            this.gender.HeaderText = "Gender";
            this.gender.Name = "gender";
            this.gender.ReadOnly = true;
            // 
            // btnApprove
            // 
            this.btnApprove.FillWeight = 74.18671F;
            this.btnApprove.HeaderText = "";
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.ReadOnly = true;
            // 
            // frmDashboardAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(869, 296);
            this.Controls.Add(this.grdAppointment);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDashboardAppointment";
            this.Text = "frmDashboardAppointment";
            ((System.ComponentModel.ISupportInitialize)(this.grdAppointment)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView grdAppointment;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullname;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileno;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn btnApprove;
    }
}