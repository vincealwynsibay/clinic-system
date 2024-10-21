namespace ClinicSystem.CrystalReport
{
    partial class frmReceiptPrescription
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
            this.csrReceiptPrescriptionView = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.csrReceiptPrescription1 = new ClinicSystem.CrystalReport.csrReceiptPrescription();
            this.SuspendLayout();
            // 
            // csrReceiptPrescriptionView
            // 
            this.csrReceiptPrescriptionView.ActiveViewIndex = 0;
            this.csrReceiptPrescriptionView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.csrReceiptPrescriptionView.Cursor = System.Windows.Forms.Cursors.Default;
            this.csrReceiptPrescriptionView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.csrReceiptPrescriptionView.Location = new System.Drawing.Point(0, 0);
            this.csrReceiptPrescriptionView.Name = "csrReceiptPrescriptionView";
            this.csrReceiptPrescriptionView.ReportSource = this.csrReceiptPrescription1;
            this.csrReceiptPrescriptionView.Size = new System.Drawing.Size(800, 450);
            this.csrReceiptPrescriptionView.TabIndex = 0;
            // 
            // frmReceiptPrescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.csrReceiptPrescriptionView);
            this.Name = "frmReceiptPrescription";
            this.Text = "frmReceiptPrescription";
            this.ResumeLayout(false);

        }

        #endregion
        private csrReceiptPrescription csrReceiptPrescription1;
        public CrystalDecisions.Windows.Forms.CrystalReportViewer csrReceiptPrescriptionView;
    }
}