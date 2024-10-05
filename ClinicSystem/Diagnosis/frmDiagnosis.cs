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

        private void func_OpenPerscription(string v_diagnosisId)
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
            this.mainForm.NavigateToForm(new frmDiagnosisEdit(mainForm, doctor_id, patient_id, Convert.ToInt32(v_diagnosisId)));
            this.Close();
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
                btnEdit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(92)))), ((int)(((byte)(126)))));
                btnEdit.Font = new System.Drawing.Font("Segoe UI", 9F);
                btnEdit.ForeColor = System.Drawing.Color.White;
                btnEdit.Image = global::ClinicSystem.Properties.Resources.icnEdit;
                btnEdit.Location = new System.Drawing.Point(352, 29);
                btnEdit.Margin = new System.Windows.Forms.Padding(2);
                btnEdit.Name = "btnEdit";
                btnEdit.Size = new System.Drawing.Size(75, 37);
                btnEdit.TabIndex = 120;
                btnEdit.Text = "Edit";
                btnEdit.Click += (s, e) => func_OpenEdit(row["id"].ToString());
                newGroupBox.Controls.Add(btnEdit);

                Guna.UI2.WinForms.Guna2Button btnDelete = new Guna.UI2.WinForms.Guna2Button();
                btnDelete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(1)))), ((int)(((byte)(28)))));
                btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
                btnDelete.ForeColor = System.Drawing.Color.White;
                btnDelete.Image = global::ClinicSystem.Properties.Resources.icnDelete;
                btnDelete.Location = new System.Drawing.Point(434, 29);
                btnDelete.Margin = new System.Windows.Forms.Padding(2);
                btnDelete.Name = "btnDelete";
                btnDelete.Size = new System.Drawing.Size(75, 37);
                btnDelete.TabIndex = 120;
                btnDelete.Text = "Delete";
                btnDelete.Click += (s, e) => func_DeleteDiagnosis(row["id"].ToString());
                newGroupBox.Controls.Add(btnDelete);

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
