using Bunifu.UI.WinForms;
using ClinicSystem.Patient;
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
    public partial class frmDiagnosis : Form
    {
        GlobalProcedure g_proc = new GlobalProcedure();

        private frmDoctorMain mainForm;
        private int doctor_id;
        private int patient_id;
        private int prescription_id;
        public frmDiagnosis(frmDoctorMain mainForm, int doctor_id, int patient_id)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.doctor_id = doctor_id;
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

                g_proc.sqlCommand.Parameters.AddWithValue("@p_doctor_id", doctor_id);
                g_proc.sqlCommand.Parameters.AddWithValue("@p_patient_id", patient_id);

                g_proc.sqlCommand.CommandType = CommandType.StoredProcedure;
                g_proc.sqlClinicAdapter.SelectCommand = g_proc.sqlCommand;
                g_proc.datPatients.Clear();
                g_proc.sqlClinicAdapter.Fill(g_proc.datPatients);
                func_DynamicGroupBoxes(g_proc.datPatients);

                g_proc.sqlClinicAdapter.Dispose();
                g_proc.datPatients.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void func_OpenPrescription(string v_diagnosisId)
        {
            try
            {
                g_proc.sqlClinicAdapter = new MySqlDataAdapter();
                g_proc.datPrescription = new DataTable();

                g_proc.sqlCommand.Parameters.Clear();
                g_proc.sqlCommand.CommandText = "procGetPrescriptionId";
                g_proc.sqlCommand.Parameters.AddWithValue("@p_doctor_id", doctor_id);
                g_proc.sqlCommand.Parameters.AddWithValue("@p_diagnosis_id", v_diagnosisId);
                g_proc.sqlCommand.Parameters.Add("@p_prescription_id", MySqlDbType.Int32).Direction = ParameterDirection.Output;

                g_proc.sqlCommand.CommandType = CommandType.StoredProcedure;
                g_proc.sqlClinicAdapter.SelectCommand = g_proc.sqlCommand;
                g_proc.sqlClinicAdapter.Fill(g_proc.datPrescription);

                prescription_id = Convert.ToInt32(g_proc.sqlCommand.Parameters["@p_prescription_id"].Value); // Getting the value of the output parameter

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            this.mainForm.NavigateToForm(new frmPrescription(mainForm, doctor_id, patient_id, prescription_id));
            this.Close();
        }

        private void func_OpenEdit(string v_diagnosisId)
        {
            g_proc.displayFormAsModal(mainForm, new frmDiagnosisEdit(mainForm, doctor_id, patient_id, Convert.ToInt32(v_diagnosisId)));
        }

        private void func_DeleteDiagnosis(string v_diagnosisId)
        {
            DialogResult dialogConfirmDelete = MessageBox.Show("Are you sure you want to delete this diagnosis permanently?",
                                                        "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialogConfirmDelete == DialogResult.No)
            {
                return;
            }

            try
            {
                g_proc.sqlClinicAdapter = new MySqlDataAdapter();
                g_proc.datPatients = new DataTable();

                g_proc.sqlCommand.Parameters.Clear();
                g_proc.sqlCommand.CommandText = "procDeletePatientDiagnosis";

                g_proc.sqlCommand.Parameters.AddWithValue("@p_id", v_diagnosisId);

                g_proc.sqlCommand.CommandType = CommandType.StoredProcedure;
                g_proc.sqlClinicAdapter.SelectCommand = g_proc.sqlCommand;
                g_proc.datPatients.Clear();
                g_proc.sqlClinicAdapter.Fill(g_proc.datPatients);
                func_LoadPatientData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void func_DynamicGroupBoxes(DataTable datDiagnosis)
        {
            // Initial Y position where the first group box will be placed
            int startY = 10;
            int spacing = 210; // Adjusted for new group box height
            this.Controls.Clear();

            foreach (DataRow row in datDiagnosis.Rows)
            {
                // Create new group box
                Bunifu.UI.WinForms.BunifuGroupBox newGroupBox = new Bunifu.UI.WinForms.BunifuGroupBox();
                newGroupBox.BorderColor = System.Drawing.Color.FromArgb(233, 233, 233);
                newGroupBox.BorderRadius = 5;
                newGroupBox.BorderThickness = 1;
                newGroupBox.Font = new System.Drawing.Font("Segoe UI", 9F);
                newGroupBox.LabelAlign = System.Windows.Forms.HorizontalAlignment.Left;
                newGroupBox.LabelIndent = 10;
                newGroupBox.LineStyle = Bunifu.UI.WinForms.BunifuGroupBox.LineStyles.Solid;
                newGroupBox.Location = new System.Drawing.Point(11, startY);
                newGroupBox.Size = new System.Drawing.Size(518, 205);

                // Create lblDiagnosisData
                Bunifu.UI.WinForms.BunifuLabel lblDiagnosisData = new Bunifu.UI.WinForms.BunifuLabel();
                lblDiagnosisData.Text = row["diagnosis"].ToString();
                lblDiagnosisData.Font = new System.Drawing.Font("IBM Plex Sans", 20.25F, System.Drawing.FontStyle.Bold);
                lblDiagnosisData.ForeColor = System.Drawing.Color.Black;
                lblDiagnosisData.Location = new System.Drawing.Point(21, 12);
                lblDiagnosisData.Size = new System.Drawing.Size(170, 37);
                lblDiagnosisData.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
                newGroupBox.Controls.Add(lblDiagnosisData);

                // Create btnDelete
                Guna.UI2.WinForms.Guna2Button btnDelete = new Guna.UI2.WinForms.Guna2Button();
                btnDelete.FillColor = System.Drawing.Color.White;
                btnDelete.Image = global::ClinicSystem.Properties.Resources.icnColoredDelete;
                btnDelete.Location = new System.Drawing.Point(465, 22);
                btnDelete.Size = new System.Drawing.Size(20, 20);
                btnDelete.Click += (s, e) => func_DeleteDiagnosis(row["id"].ToString());
                newGroupBox.Controls.Add(btnDelete);

                // Create btnEdit
                Guna.UI2.WinForms.Guna2Button btnEdit = new Guna.UI2.WinForms.Guna2Button();
                btnEdit.FillColor = System.Drawing.Color.White;
                btnEdit.Image = global::ClinicSystem.Properties.Resources.icnColoredEdit;
                btnEdit.Location = new System.Drawing.Point(431, 22);
                btnEdit.Size = new System.Drawing.Size(20, 20);
                btnEdit.Click += (s, e) => func_OpenEdit(row["id"].ToString());
                newGroupBox.Controls.Add(btnEdit);

                // Create btnPrescription
                Guna.UI2.WinForms.Guna2Button btnPrescription = new Guna.UI2.WinForms.Guna2Button();
                btnPrescription.Text = "See Prescription";
                btnPrescription.FillColor = System.Drawing.Color.FromArgb(0, 55, 75);
                btnPrescription.Font = new System.Drawing.Font("IBM Plex Sans", 9F);
                btnPrescription.ForeColor = System.Drawing.Color.White;
                btnPrescription.Location = new System.Drawing.Point(338, 153);
                btnPrescription.Size = new System.Drawing.Size(157, 29);
                btnPrescription.BorderRadius = 5;
                btnPrescription.Click += (s, e) => func_OpenPrescription(row["id"].ToString());
                newGroupBox.Controls.Add(btnPrescription);

                // Create lblComment
                Bunifu.UI.WinForms.BunifuLabel lblComment = new Bunifu.UI.WinForms.BunifuLabel();
                lblComment.Text = "Recommendation:";
                lblComment.Font = new System.Drawing.Font("IBM Plex Sans", 12F);
                lblComment.ForeColor = System.Drawing.Color.FromArgb(136, 142, 163);
                lblComment.Location = new System.Drawing.Point(21, 77);
                lblComment.Size = new System.Drawing.Size(133, 20);
                newGroupBox.Controls.Add(lblComment);

                // Create lblCommentData
                Bunifu.UI.WinForms.BunifuLabel lblCommentData = new Bunifu.UI.WinForms.BunifuLabel();
                lblCommentData.Text = row["comment"].ToString();
                lblCommentData.Font = new System.Drawing.Font("Segoe UI", 12F);
                lblCommentData.ForeColor = System.Drawing.Color.Black;
                lblCommentData.Location = new System.Drawing.Point(21, 103);
                lblCommentData.Size = new System.Drawing.Size(474, 24);
                newGroupBox.Controls.Add(lblCommentData);

                // Create lblDiagnosisDate
                Bunifu.UI.WinForms.BunifuLabel lblDiagnosisDate = new Bunifu.UI.WinForms.BunifuLabel();
                lblDiagnosisDate.Text = "Diagnosed on " + Convert.ToDateTime(row["createddate"]).ToString("MM/dd/yyyy");
                lblDiagnosisDate.Font = new System.Drawing.Font("IBM Plex Sans", 9.75F);
                lblDiagnosisDate.ForeColor = System.Drawing.Color.FromArgb(0, 55, 75);
                lblDiagnosisDate.Location = new System.Drawing.Point(21, 159);
                lblDiagnosisDate.Size = new System.Drawing.Size(155, 17);
                newGroupBox.Controls.Add(lblDiagnosisDate);

                // Add the new group box to the form (or panel)
                this.Controls.Add(newGroupBox);

                // Move the Y-coordinate down for the next group box
                startY += spacing;
            }
        }
    }
}
