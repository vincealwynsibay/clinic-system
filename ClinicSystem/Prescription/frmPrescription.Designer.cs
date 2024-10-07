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
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.lblPrescription = new Bunifu.UI.WinForms.BunifuLabel();
            this.btnBack = new Guna.UI2.WinForms.Guna2Button();
            this.btnModify = new Guna.UI2.WinForms.Guna2Button();
            this.btnPrint = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdPrescription)).BeginInit();
            this.bunifuPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdPrescription
            // 
            this.grdPrescription.AllowUserToAddRows = false;
            this.grdPrescription.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.grdPrescription.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdPrescription.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdPrescription.ColumnHeadersHeight = 52;
            this.grdPrescription.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.grdPrescription.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column1,
            this.Column3,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(184)))), ((int)(((byte)(169)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdPrescription.DefaultCellStyle = dataGridViewCellStyle3;
            this.grdPrescription.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.grdPrescription.Location = new System.Drawing.Point(65, 112);
            this.grdPrescription.Margin = new System.Windows.Forms.Padding(2);
            this.grdPrescription.Name = "grdPrescription";
            this.grdPrescription.ReadOnly = true;
            this.grdPrescription.RowHeadersVisible = false;
            this.grdPrescription.RowHeadersWidth = 51;
            this.grdPrescription.RowTemplate.Height = 24;
            this.grdPrescription.Size = new System.Drawing.Size(881, 657);
            this.grdPrescription.TabIndex = 8;
            this.grdPrescription.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.White;
            this.grdPrescription.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.grdPrescription.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.grdPrescription.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.grdPrescription.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.grdPrescription.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.grdPrescription.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.grdPrescription.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.grdPrescription.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(75)))));
            this.grdPrescription.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grdPrescription.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.grdPrescription.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.grdPrescription.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.grdPrescription.ThemeStyle.HeaderStyle.Height = 52;
            this.grdPrescription.ThemeStyle.ReadOnly = true;
            this.grdPrescription.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.grdPrescription.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grdPrescription.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.grdPrescription.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.grdPrescription.ThemeStyle.RowsStyle.Height = 24;
            this.grdPrescription.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(184)))), ((int)(((byte)(169)))));
            this.grdPrescription.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
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
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(75)))));
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 3;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.lblPrescription);
            this.bunifuPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(1006, 100);
            this.bunifuPanel1.TabIndex = 96;
            // 
            // lblPrescription
            // 
            this.lblPrescription.AllowParentOverrides = false;
            this.lblPrescription.AutoEllipsis = false;
            this.lblPrescription.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblPrescription.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblPrescription.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblPrescription.ForeColor = System.Drawing.Color.White;
            this.lblPrescription.Location = new System.Drawing.Point(425, 32);
            this.lblPrescription.Margin = new System.Windows.Forms.Padding(2);
            this.lblPrescription.Name = "lblPrescription";
            this.lblPrescription.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPrescription.Size = new System.Drawing.Size(156, 37);
            this.lblPrescription.TabIndex = 39;
            this.lblPrescription.Text = "Prescription";
            this.lblPrescription.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPrescription.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // btnBack
            // 
            this.btnBack.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(75)))));
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(65, 781);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(193, 37);
            this.btnBack.TabIndex = 114;
            this.btnBack.Text = "Go Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnModify
            // 
            this.btnModify.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(75)))));
            this.btnModify.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnModify.ForeColor = System.Drawing.Color.White;
            this.btnModify.Location = new System.Drawing.Point(753, 781);
            this.btnModify.Margin = new System.Windows.Forms.Padding(2);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(193, 37);
            this.btnModify.TabIndex = 115;
            this.btnModify.Text = "Modify";
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(75)))));
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(409, 781);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(193, 37);
            this.btnPrint.TabIndex = 116;
            this.btnPrint.Text = "Print";
            // 
            // frmPrescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1006, 829);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.bunifuPanel1);
            this.Controls.Add(this.grdPrescription);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPrescription";
            this.Text = "frmDoctorPatientPerscription";
            ((System.ComponentModel.ISupportInitialize)(this.grdPrescription)).EndInit();
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView grdPrescription;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private Bunifu.UI.WinForms.BunifuLabel lblPrescription;
        private Guna.UI2.WinForms.Guna2Button btnBack;
        private Guna.UI2.WinForms.Guna2Button btnModify;
        private Guna.UI2.WinForms.Guna2Button btnPrint;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}