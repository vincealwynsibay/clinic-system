using MySql.Data.MySqlClient;
using System;
using System.CodeDom;
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
    public partial class frmPatientEdit : Form
    {
        GlobalProcedure g_proc = new GlobalProcedure();

        private frmDoctorMain mainForm;
        private int doctor_id;
        private int patient_id;

        private string originalEmail;
        private string originalMobileNo;
        private string originalEmergencyNo;
        private string originalMaritalStatus;

        public frmPatientEdit(frmDoctorMain mainForm, int doctor_id, int patient_id)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.doctor_id = doctor_id;
            this.patient_id = patient_id;
            g_proc.fncConnectToDatabase();

            func_NavigationKeys();
            func_LoadPatientData();
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
                txtFirstName.Text = row["firstname"].ToString();
                txtLastName.Text = row["lastname"].ToString();
                func_SetGenderRadioButton(row["gender"].ToString());
                dtBirthdate.Value = Convert.ToDateTime(row["birthdate"]);
                txtEmail.Text = row["email"].ToString();
                txtMobileNo.Text = row["mobileno"].ToString();
                txtEmergency.Text = row["emergencyno"].ToString();
                txtMarital.Text = row["maritalstatus"].ToString();

                originalEmail = row["email"].ToString();
                originalMobileNo = row["mobileno"].ToString();
                originalEmergencyNo = row["emergencyno"].ToString();
                originalMaritalStatus = row["maritalstatus"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            g_proc.sqlClinicAdapter.Dispose();
            g_proc.datPatients.Dispose();
        }

        private void func_SetGenderRadioButton(string gender)
        {
            if (gender == "Male")
            {
                rdoGender1.Checked = true;
            }
            else if (gender == "Female")
            {
                rdoGender2.Checked = true;
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

        private void btnSaveEditPatient_Click(object sender, EventArgs e)
        {
            try
            {
                if (!func_HasDataChanged())
                {
                    MessageBox.Show("No changes detected. Record not updated.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                g_proc.sqlCommand.Parameters.Clear();
                g_proc.sqlCommand.CommandText = "procSaveEditPatientDetail";
                g_proc.sqlCommand.CommandType = CommandType.StoredProcedure;

                g_proc.sqlCommand.Parameters.AddWithValue("@p_id", patient_id);
                g_proc.sqlCommand.Parameters.AddWithValue("@p_firstname", txtFirstName.Text);
                g_proc.sqlCommand.Parameters.AddWithValue("@p_lastname", txtLastName.Text);
                g_proc.sqlCommand.Parameters.AddWithValue("@p_birthdate", dtBirthdate.Value);
                g_proc.sqlCommand.Parameters.AddWithValue("@p_gender", func_GetSelectedGender());
                g_proc.sqlCommand.Parameters.AddWithValue("@p_mobile", txtMobileNo.Text);
                g_proc.sqlCommand.Parameters.AddWithValue("@p_email", txtEmail.Text);
                g_proc.sqlCommand.Parameters.AddWithValue("@p_marital", txtMarital.Text);
                g_proc.sqlCommand.Parameters.AddWithValue("@p_emergency", txtEmergency.Text);

                g_proc.sqlCommand.ExecuteNonQuery();

                MessageBox.Show("Record updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.mainForm.NavigateToForm(new frmPatientDetail(mainForm, doctor_id, patient_id));
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool func_HasDataChanged()
        {
            return txtEmail.Text != originalEmail ||
                   txtMobileNo.Text != originalMobileNo ||
                   txtEmergency.Text != originalEmergencyNo ||
                   txtMarital.Text != originalMaritalStatus;
        }


        private void func_NavigationKeys()
        {
            txtEmail.KeyDown += Control_KeyDown;
            txtMobileNo.KeyDown += Control_KeyDown;
            txtEmergency.KeyDown += Control_KeyDown;
            txtMarital.KeyDown += Control_KeyDown;
            btnSaveEditPatient.KeyDown += Control_KeyDown;

            txtEmail.TabIndex = 0;
            txtMobileNo.TabIndex = 1;
            txtEmergency.TabIndex = 2;
            txtMarital.TabIndex = 3;
            btnSaveEditPatient.TabIndex = 4;
        }

        private void Control_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                if (sender == txtEmail)
                {
                    txtMobileNo.Focus();
                }
                else if (sender == txtMobileNo)
                {
                    txtEmergency.Focus();
                }
                else if (sender == txtEmergency)
                {
                    txtMarital.Focus();
                }
                else if (sender == txtMarital)
                {
                    btnSaveEditPatient.Focus();
                }
            }

            else if (e.KeyCode == Keys.Up)
            {
                if (sender == btnSaveEditPatient)
                {
                    txtMarital.Focus();
                }
                else if (sender == txtMarital)
                {
                    txtEmergency.Focus();
                }
                else if (sender == txtEmergency)
                {
                    txtMobileNo.Focus();
                }
                else if (sender == txtMobileNo)
                {
                    txtEmail.Focus();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}