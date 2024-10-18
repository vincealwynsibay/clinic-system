using ClinicSystem.Diagnosis;
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
    public partial class frmPatientDetail : Form
    {
        GlobalProcedure g_proc = new GlobalProcedure();

        private frmDoctorMain mainForm;
        private int doctor_id;
        private int patient_id;

        public frmPatientDetail(frmDoctorMain mainForm, int doctor_id, int patient_id)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.doctor_id = doctor_id;
            this.patient_id = patient_id;
            g_proc.fncConnectToDatabase();
            func_LoadPatientData();

            LoadFormIntoPanel(new frmDiagnosis(mainForm, doctor_id, patient_id));   // adds the form into the panel to show the diagnosis
        }

        public void LoadFormIntoPanel(Form form)
        {
            this.pnlDiagnosis.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            this.pnlDiagnosis.Controls.Add(form);
            form.Show();
        }

        private void func_LoadPatientData()
        {
            try
            {
                g_proc.sqlClinicAdapter = new MySqlDataAdapter();
                g_proc.datPatients = new DataTable();

                g_proc.sqlCommand.Parameters.Clear();
                g_proc.sqlCommand.CommandText = "procGetPatientDetails";
                g_proc.sqlCommand.Parameters.AddWithValue("@p_id", patient_id);
                g_proc.sqlCommand.CommandType = CommandType.StoredProcedure;
                g_proc.sqlClinicAdapter.SelectCommand = g_proc.sqlCommand;

                g_proc.datPatients.Clear();
                g_proc.sqlClinicAdapter.Fill(g_proc.datPatients);

                DataRow row = g_proc.datPatients.Rows[0];
                lblName.Text = row["firstname"].ToString() + " " + (string.IsNullOrEmpty(row["middlename"].ToString()) ? "" : row["middlename"].ToString() + " ") + row["lastname"].ToString();
                lblGender.Text = row["gender"].ToString();
                lblBirthdate.Text = Convert.ToDateTime(row["birthdate"].ToString()).ToShortDateString();
                lblEmail.Text = row["email"].ToString();
                lblMobileNo.Text = row["mobileno"].ToString();
                lblEmergencyNo.Text = row["emergencyno"].ToString();
                lblMaritalStat.Text = row["maritalstatus"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            g_proc.sqlClinicAdapter.Dispose();
            g_proc.datPatients.Dispose();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.mainForm.NavigateToForm(new frmDiagnosisAdd(mainForm, doctor_id, patient_id));
            this.Close();
        }
    }
}
