using ClinicSystem.DoctorMain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicSystem.Patient
{
    public partial class frmPatientAdd : Form
    {
        GlobalProcedure g_proc = new GlobalProcedure();

        private frmDoctorMain mainForm;
        private int doctor_id;

        public frmPatientAdd(frmDoctorMain mainForm, int doctor_id)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.doctor_id = doctor_id;
            g_proc.fncConnectToDatabase();
        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            if (g_proc.CheckIfEmpty(txtDiagnosis.Text.ToString()) || g_proc.CheckIfEmpty(txtFirstName.Text.ToString()) || g_proc.CheckIfEmpty(txtLastName.Text.ToString()) ||
                g_proc.CheckIfEmpty(txtMobileNo.Text.ToString()) || g_proc.CheckIfEmpty(txtEmail.Text.ToString()) || g_proc.CheckIfEmpty(txtEmergency.Text.ToString()))
            {
                MessageBox.Show("Required Field is Empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                g_proc.sqlCommand.Parameters.Clear();
                g_proc.sqlCommand.CommandText = "procAddPatient";
                g_proc.sqlCommand.CommandType = CommandType.StoredProcedure;

                g_proc.sqlCommand.Parameters.AddWithValue("@p_firstname", txtFirstName.Text);
                g_proc.sqlCommand.Parameters.AddWithValue("@p_lastname", txtLastName.Text);
                g_proc.sqlCommand.Parameters.AddWithValue("@p_birthdate", dtBirthdate.Value);
                g_proc.sqlCommand.Parameters.AddWithValue("@p_gender", func_GetSelectedGender());
                g_proc.sqlCommand.Parameters.AddWithValue("@p_mobile", txtMobileNo.Text);
                g_proc.sqlCommand.Parameters.AddWithValue("@p_email", txtEmail.Text);
                g_proc.sqlCommand.Parameters.AddWithValue("@p_maritalstatus", cboMarital.Text);
                g_proc.sqlCommand.Parameters.AddWithValue("@p_emergency", txtEmergency.Text);
                g_proc.sqlCommand.Parameters.AddWithValue("@p_diagnosis", txtDiagnosis.Text);
                g_proc.sqlCommand.Parameters.AddWithValue("@p_comment", txtComment.Text);
                g_proc.sqlCommand.Parameters.AddWithValue("@p_datecreated", DateTime.Today);
                g_proc.sqlCommand.Parameters.AddWithValue("@p_doctor_id", doctor_id);

                g_proc.sqlCommand.ExecuteNonQuery();

                MessageBox.Show("Record added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.mainForm.NavigateToForm(new frmPatients(mainForm, doctor_id));
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string func_GetSelectedGender()
        {
            if (rdoGender1.Checked)
            {
                return "Male";
            }
            else
            {
                return "Female";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
