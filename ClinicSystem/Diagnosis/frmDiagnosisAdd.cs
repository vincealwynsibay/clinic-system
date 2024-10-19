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

namespace ClinicSystem.Diagnosis
{
    public partial class frmDiagnosisAdd : Form
    {
        GlobalProcedure g_proc = new GlobalProcedure();

        private frmDoctorMain mainForm;
        private int doctor_id;
        private int patient_id;

        public frmDiagnosisAdd(frmDoctorMain mainForm, int doctor_id, int patient_id)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.doctor_id = doctor_id;
            this.patient_id = patient_id;
            g_proc.fncConnectToDatabase();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                g_proc.sqlCommand.Parameters.Clear();
                g_proc.sqlCommand.CommandText = "procAddDiagnosis";
                g_proc.sqlCommand.CommandType = CommandType.StoredProcedure;

                g_proc.sqlCommand.Parameters.AddWithValue("@p_diagnosis", txtDiagnosis.Text);
                g_proc.sqlCommand.Parameters.AddWithValue("@p_comment", txtComment.Text);
                g_proc.sqlCommand.Parameters.AddWithValue("@p_datecreated", DateTime.Today);
                g_proc.sqlCommand.Parameters.AddWithValue("@p_doctor_id", doctor_id);
                g_proc.sqlCommand.Parameters.AddWithValue("@p_patient_id", patient_id);

                g_proc.sqlCommand.ExecuteNonQuery();

                this.mainForm.NavigateToForm(new frmPatientDetail(mainForm, doctor_id, patient_id));
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.mainForm.NavigateToForm(new frmPatientDetail(mainForm, doctor_id, patient_id));
            this.Close();
        }
    }
}
