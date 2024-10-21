namespace ClinicSystem.CrystalReport
{
    partial class frmMonthlyReports
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
            this.csrMonthlyReportsView = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.csrMonthlyReports1 = new ClinicSystem.CrystalReport.csrMonthlyReports();
            this.SuspendLayout();
            // 
            // csrMonthlyReportsView
            // 
            this.csrMonthlyReportsView.ActiveViewIndex = 0;
            this.csrMonthlyReportsView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.csrMonthlyReportsView.Cursor = System.Windows.Forms.Cursors.Default;
            this.csrMonthlyReportsView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.csrMonthlyReportsView.Location = new System.Drawing.Point(0, 0);
            this.csrMonthlyReportsView.Name = "csrMonthlyReportsView";
            this.csrMonthlyReportsView.ReportSource = this.csrMonthlyReports1;
            this.csrMonthlyReportsView.Size = new System.Drawing.Size(800, 450);
            this.csrMonthlyReportsView.TabIndex = 0;
            this.csrMonthlyReportsView.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.ParameterPanel;
            // 
            // frmMonthlyReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.csrMonthlyReportsView);
            this.Name = "frmMonthlyReports";
            this.Text = "frmMonthlyReports";
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer csrMonthlyReportsView;
        private csrMonthlyReports csrMonthlyReports1;
    }
}