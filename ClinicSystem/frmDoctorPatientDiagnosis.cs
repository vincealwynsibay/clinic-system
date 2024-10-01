using Bunifu.UI.WinForms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicSystem
{
    public partial class frmDoctorPatientDiagnosis : Form
    {
        GlobalProcedure g_proc = new GlobalProcedure();

        private frmDoctorMain mainForm;
        private int key_index;
        private int patient_id;

        private int row;
        public frmDoctorPatientDiagnosis(frmDoctorMain mainForm, int key_index, int patient_id)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.key_index = key_index;
            this.patient_id = patient_id;
            g_proc.fncConnectToDatabase();
            func_LoadPatientData();
        }

        private void func_LoadPatientData()
        {
            try
            {
                g_proc.sqlClinicAdapter = new MySqlDataAdapter();
                g_proc.datPatients = new DataTable();

                g_proc.sqlCommand.Parameters.Clear();
                g_proc.sqlCommand.CommandText = "procGetPatientDiagnosis";

                g_proc.sqlCommand.Parameters.AddWithValue("@p_doctor_id", key_index);
                g_proc.sqlCommand.Parameters.AddWithValue("@p_patient_id", patient_id);

                g_proc.sqlCommand.CommandType = CommandType.StoredProcedure;
                g_proc.sqlClinicAdapter.SelectCommand = g_proc.sqlCommand;
                g_proc.datPatients.Clear();
                g_proc.sqlClinicAdapter.Fill(g_proc.datPatients);
                func_DynamicGroupBoxes(g_proc.datPatients);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Search Error: " + ex.Message);
            }
        }

        private void func_OpenPerscription(string v_diagnosisId)
        {

        }

        private void func_OpenEdit(string v_diagnosisId)
        {

        }

        private void func_DynamicGroupBoxes(DataTable datDiagnosis)
        {
            // Initial Y position where the first group box will be placed
            int startY = 10;
            int spacing = 150;
            this.Controls.Clear();

            foreach (DataRow row in datDiagnosis.Rows)
            {
                Bunifu.UI.WinForms.BunifuGroupBox newGroupBox = new Bunifu.UI.WinForms.BunifuGroupBox();
                newGroupBox.BorderColor = System.Drawing.Color.Black;
                newGroupBox.BorderRadius = 1;
                newGroupBox.BorderThickness = 1;
                newGroupBox.Font = new System.Drawing.Font("Segoe UI", 9F);
                newGroupBox.LabelAlign = System.Windows.Forms.HorizontalAlignment.Left;
                newGroupBox.LabelIndent = 10;
                newGroupBox.LineStyle = Bunifu.UI.WinForms.BunifuGroupBox.LineStyles.Solid;
                newGroupBox.Location = new System.Drawing.Point(10, startY);
                newGroupBox.Size = new System.Drawing.Size(518, 132);

                Bunifu.UI.WinForms.BunifuLabel lblDiagnosisDate = new Bunifu.UI.WinForms.BunifuLabel();
                lblDiagnosisDate.Text = "Diagnosed on " + Convert.ToDateTime(row["createddate"]).ToString("MM/dd/yyyy");
                lblDiagnosisDate.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
                lblDiagnosisDate.ForeColor = System.Drawing.Color.FromArgb(0, 55, 75);
                lblDiagnosisDate.Location = new System.Drawing.Point(4, 2);
                lblDiagnosisDate.Size = new System.Drawing.Size(185, 21);
                newGroupBox.Controls.Add(lblDiagnosisDate);

                Bunifu.UI.WinForms.BunifuLabel lblDiagnosis = new Bunifu.UI.WinForms.BunifuLabel();
                lblDiagnosis.Text = "Diagnosis:";
                lblDiagnosis.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
                lblDiagnosis.ForeColor = System.Drawing.Color.FromArgb(0, 55, 75);
                lblDiagnosis.Location = new System.Drawing.Point(21, 29);
                lblDiagnosis.Size = new System.Drawing.Size(67, 42);
                newGroupBox.Controls.Add(lblDiagnosis);

                Bunifu.UI.WinForms.BunifuLabel lblDiagnosisData = new Bunifu.UI.WinForms.BunifuLabel();
                lblDiagnosisData.Text = row["diagnosis"].ToString();
                lblDiagnosisData.Font = new System.Drawing.Font("Segoe UI", 10F);
                lblDiagnosisData.ForeColor = System.Drawing.Color.FromArgb(0, 55, 75);
                lblDiagnosisData.Location = new System.Drawing.Point(100, 29);
                lblDiagnosisData.Size = new System.Drawing.Size(238, 42);
                newGroupBox.Controls.Add(lblDiagnosisData);

                Bunifu.UI.WinForms.BunifuLabel lblComment = new Bunifu.UI.WinForms.BunifuLabel();
                lblComment.Text = "Comment:";
                lblComment.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
                lblComment.ForeColor = System.Drawing.Color.FromArgb(0, 55, 75);
                lblComment.Location = new System.Drawing.Point(21, 79);
                lblComment.Size = new System.Drawing.Size(73, 42);
                newGroupBox.Controls.Add(lblComment);

                Bunifu.UI.WinForms.BunifuLabel lblCommentData = new Bunifu.UI.WinForms.BunifuLabel();
                lblCommentData.Text = row["comment"].ToString();
                lblCommentData.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
                lblCommentData.ForeColor = System.Drawing.Color.FromArgb(0, 55, 75);
                lblCommentData.Location = new System.Drawing.Point(100, 79);
                lblCommentData.Size = new System.Drawing.Size(238, 42);
                newGroupBox.Controls.Add(lblCommentData);

                Guna.UI2.WinForms.Guna2Button btnEdit = new Guna.UI2.WinForms.Guna2Button();
                btnEdit.Text = "Edit Details";
                btnEdit.FillColor = System.Drawing.Color.FromArgb(0, 55, 75);
                btnEdit.Font = new System.Drawing.Font("Segoe UI", 9F);
                btnEdit.ForeColor = System.Drawing.Color.White;
                btnEdit.Location = new System.Drawing.Point(352, 29);
                btnEdit.Size = new System.Drawing.Size(157, 37);
                btnEdit.Click += (s, e) => func_OpenEdit(row["id"].ToString());
                newGroupBox.Controls.Add(btnEdit);

                Guna.UI2.WinForms.Guna2Button btnPrescription = new Guna.UI2.WinForms.Guna2Button();
                btnPrescription.Text = "Prescription";
                btnPrescription.FillColor = System.Drawing.Color.FromArgb(0, 55, 75);
                btnPrescription.Font = new System.Drawing.Font("Segoe UI", 9F);
                btnPrescription.ForeColor = System.Drawing.Color.White;
                btnPrescription.Location = new System.Drawing.Point(352, 79);
                btnPrescription.Size = new System.Drawing.Size(157, 37);
                btnPrescription.Click += (s, e) => func_OpenPerscription(row["id"].ToString());
                newGroupBox.Controls.Add(btnPrescription);

                // Add the new group box to the form (or panel)
                this.Controls.Add(newGroupBox);

                // Move the Y-coordinate down for the next group box
                startY += spacing;
            }
        }
    }
}
