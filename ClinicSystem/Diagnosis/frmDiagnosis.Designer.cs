namespace ClinicSystem
{
    partial class frmDiagnosis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDiagnosis));
            this.grpDiagnosis = new Bunifu.UI.WinForms.BunifuGroupBox();
            this.lblDiagnosisData = new Bunifu.UI.WinForms.BunifuLabel();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.btnEdit = new Guna.UI2.WinForms.Guna2Button();
            this.btnPerscription = new Guna.UI2.WinForms.Guna2Button();
            this.lblCommentData = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblComment = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblDiagnosisDate = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.grpDiagnosis.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDiagnosis
            // 
            this.grpDiagnosis.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.grpDiagnosis.BorderRadius = 5;
            this.grpDiagnosis.BorderThickness = 1;
            this.grpDiagnosis.Controls.Add(this.lblDiagnosisData);
            this.grpDiagnosis.Controls.Add(this.btnDelete);
            this.grpDiagnosis.Controls.Add(this.btnEdit);
            this.grpDiagnosis.Controls.Add(this.btnPerscription);
            this.grpDiagnosis.Controls.Add(this.lblCommentData);
            this.grpDiagnosis.Controls.Add(this.lblComment);
            this.grpDiagnosis.Controls.Add(this.lblDiagnosisDate);
            this.grpDiagnosis.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.grpDiagnosis.LabelAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.grpDiagnosis.LabelIndent = 10;
            this.grpDiagnosis.LineStyle = Bunifu.UI.WinForms.BunifuGroupBox.LineStyles.Solid;
            this.grpDiagnosis.Location = new System.Drawing.Point(11, 8);
            this.grpDiagnosis.Name = "grpDiagnosis";
            this.grpDiagnosis.Size = new System.Drawing.Size(518, 205);
            this.grpDiagnosis.TabIndex = 0;
            this.grpDiagnosis.TabStop = false;
            // 
            // lblDiagnosisData
            // 
            this.lblDiagnosisData.AllowParentOverrides = false;
            this.lblDiagnosisData.AutoEllipsis = false;
            this.lblDiagnosisData.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblDiagnosisData.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblDiagnosisData.Font = new System.Drawing.Font("IBM Plex Sans", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblDiagnosisData.ForeColor = System.Drawing.Color.Black;
            this.lblDiagnosisData.Location = new System.Drawing.Point(21, 12);
            this.lblDiagnosisData.Margin = new System.Windows.Forms.Padding(2);
            this.lblDiagnosisData.Name = "lblDiagnosisData";
            this.lblDiagnosisData.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDiagnosisData.Size = new System.Drawing.Size(170, 37);
            this.lblDiagnosisData.TabIndex = 122;
            this.lblDiagnosisData.Text = "Uruha Rushia";
            this.lblDiagnosisData.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDiagnosisData.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // btnDelete
            // 
            this.btnDelete.FillColor = System.Drawing.Color.White;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = global::ClinicSystem.Properties.Resources.icnColoredDelete;
            this.btnDelete.Location = new System.Drawing.Point(465, 22);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(20, 20);
            this.btnDelete.TabIndex = 120;
            // 
            // btnEdit
            // 
            this.btnEdit.FillColor = System.Drawing.Color.White;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Image = global::ClinicSystem.Properties.Resources.icnColoredEdit;
            this.btnEdit.Location = new System.Drawing.Point(431, 22);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(20, 20);
            this.btnEdit.TabIndex = 120;
            // 
            // btnPerscription
            // 
            this.btnPerscription.BorderRadius = 5;
            this.btnPerscription.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(75)))));
            this.btnPerscription.Font = new System.Drawing.Font("IBM Plex Sans", 9F);
            this.btnPerscription.ForeColor = System.Drawing.Color.White;
            this.btnPerscription.Location = new System.Drawing.Point(338, 153);
            this.btnPerscription.Margin = new System.Windows.Forms.Padding(2);
            this.btnPerscription.Name = "btnPerscription";
            this.btnPerscription.Size = new System.Drawing.Size(157, 29);
            this.btnPerscription.TabIndex = 119;
            this.btnPerscription.Text = "See Perscription";
            // 
            // lblCommentData
            // 
            this.lblCommentData.AllowParentOverrides = false;
            this.lblCommentData.AutoEllipsis = false;
            this.lblCommentData.AutoSize = false;
            this.lblCommentData.CursorType = null;
            this.lblCommentData.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblCommentData.ForeColor = System.Drawing.Color.Black;
            this.lblCommentData.Location = new System.Drawing.Point(21, 103);
            this.lblCommentData.Name = "lblCommentData";
            this.lblCommentData.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblCommentData.Size = new System.Drawing.Size(474, 24);
            this.lblCommentData.TabIndex = 99;
            this.lblCommentData.Text = resources.GetString("lblCommentData.Text");
            this.lblCommentData.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblCommentData.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lblComment
            // 
            this.lblComment.AllowParentOverrides = false;
            this.lblComment.AutoEllipsis = false;
            this.lblComment.CursorType = null;
            this.lblComment.Font = new System.Drawing.Font("IBM Plex Sans", 12F);
            this.lblComment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(142)))), ((int)(((byte)(163)))));
            this.lblComment.Location = new System.Drawing.Point(21, 77);
            this.lblComment.Name = "lblComment";
            this.lblComment.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblComment.Size = new System.Drawing.Size(133, 20);
            this.lblComment.TabIndex = 99;
            this.lblComment.Text = "Recommendation:";
            this.lblComment.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblComment.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lblDiagnosisDate
            // 
            this.lblDiagnosisDate.AllowParentOverrides = false;
            this.lblDiagnosisDate.AutoEllipsis = false;
            this.lblDiagnosisDate.CursorType = null;
            this.lblDiagnosisDate.Font = new System.Drawing.Font("IBM Plex Sans", 9.75F);
            this.lblDiagnosisDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(75)))));
            this.lblDiagnosisDate.Location = new System.Drawing.Point(21, 159);
            this.lblDiagnosisDate.Name = "lblDiagnosisDate";
            this.lblDiagnosisDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDiagnosisDate.Size = new System.Drawing.Size(155, 17);
            this.lblDiagnosisDate.TabIndex = 98;
            this.lblDiagnosisDate.Text = "Diagnosed on 10/16/2003";
            this.lblDiagnosisDate.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblDiagnosisDate.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(75)))));
            this.bunifuPanel1.BorderRadius = 3;
            this.bunifuPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.Padding = new System.Windows.Forms.Padding(1);
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(564, 303);
            this.bunifuPanel1.TabIndex = 1;
            // 
            // frmDiagnosis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(564, 303);
            this.Controls.Add(this.grpDiagnosis);
            this.Controls.Add(this.bunifuPanel1);
            this.Name = "frmDiagnosis";
            this.Text = "frmDoctorPatientDiagnosis";
            this.grpDiagnosis.ResumeLayout(false);
            this.grpDiagnosis.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuGroupBox grpDiagnosis;
        private Bunifu.UI.WinForms.BunifuLabel lblComment;
        private Bunifu.UI.WinForms.BunifuLabel lblDiagnosisDate;
        private Bunifu.UI.WinForms.BunifuLabel lblCommentData;
        private Guna.UI2.WinForms.Guna2Button btnPerscription;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private Guna.UI2.WinForms.Guna2Button btnEdit;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Bunifu.UI.WinForms.BunifuLabel lblDiagnosisData;
    }
}