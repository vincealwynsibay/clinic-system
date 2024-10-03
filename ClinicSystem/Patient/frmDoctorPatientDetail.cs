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
    public partial class frmDoctorPatientDetail : Form
    {
        GlobalProcedure g_proc = new GlobalProcedure();

        private frmDoctorMain mainForm;
        private int key_index;
        private int patient_id;

        public frmDoctorPatientDetail(frmDoctorMain mainForm, int key_index, int patient_id)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.key_index = key_index;
            this.patient_id = patient_id;
            g_proc.fncConnectToDatabase();
            func_LoadPatientData();
            LoadFormIntoPanel(new frmDoctorPatientDiagnosis(mainForm, key_index, patient_id));
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

        private void btnEditPatient_Click(object sender, EventArgs e)
        {
            this.mainForm.NavigateToForm(new frmDoctorPatientEdit(mainForm, key_index, patient_id));
            this.Close();
        }
    }
}
