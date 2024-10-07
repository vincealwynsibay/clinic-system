using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicSystem
{
    public partial class frmDoctorSetting : Form
    {
        GlobalProcedure g_proc = new GlobalProcedure();
        OpenFileDialog filedialogueProfilePic = new OpenFileDialog();
        
        private frmDoctorMain mainForm;
        private int key_index;      // the value that holds who is who in the doctors
        private string imgProfile;

        private string originalEmail;
        private string originalMobileNo;
        private string originalAddress;
        private string originalConsultationAmount;

        public frmDoctorSetting(frmDoctorMain mainForm, int key_index)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.key_index = key_index;
            g_proc.fncConnectToDatabase();
            func_LoadDoctorData();
        }

        private void func_LoadDoctorData()
        {
            try
            {
                g_proc.sqlClinicAdapter = new MySqlDataAdapter();
                g_proc.datDoctors = new DataTable();

                g_proc.sqlCommand.Parameters.Clear();
                g_proc.sqlCommand.CommandText = "procGetDoctorDetails";
                g_proc.sqlCommand.Parameters.AddWithValue("@p_id", key_index);
                g_proc.sqlCommand.CommandType = CommandType.StoredProcedure;
                g_proc.sqlClinicAdapter.SelectCommand = g_proc.sqlCommand;

                g_proc.datDoctors.Clear();
                g_proc.sqlClinicAdapter.Fill(g_proc.datDoctors);

                DataRow row = g_proc.datDoctors.Rows[0];
                txtFirstName.Text = row["firstname"].ToString();
                txtLastName.Text = row["lastname"].ToString();
                func_SetGenderRadioButton(row["gender"].ToString());
                dtBirthdate.Value = Convert.ToDateTime(row["birthdate"]);
                txtEmail.Text = row["email"].ToString();
                txtMobileNo.Text = row["mobileno"].ToString();
                txtAddress.Text = row["address"].ToString();
                txtConsultation.Text = row["amount"].ToString(); // tbldoctorconsultationfee

                //picProfile.Image = Image.FromFile("photo"); not working

                originalEmail = row["email"].ToString();
                originalMobileNo = row["mobileno"].ToString();
                originalAddress = row["address"].ToString();
                originalConsultationAmount = row["amount"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            g_proc.sqlClinicAdapter.Dispose();
            g_proc.datDoctors.Dispose();
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

        private void picProfile_Click(object sender, EventArgs e)
        {
            filedialogueProfilePic.InitialDirectory = "c:\\";
            filedialogueProfilePic.Filter = "Image files (*.png;*.jpg;*.jpeg)|*.png;*.jpg;*.jpeg";
            filedialogueProfilePic.FilterIndex = 2;
            filedialogueProfilePic.RestoreDirectory = true;

            if (filedialogueProfilePic.ShowDialog() == DialogResult.OK)
            {
                picProfile.Image = new Bitmap(filedialogueProfilePic.FileName);
                picProfile.Image = new Bitmap(filedialogueProfilePic.FileName);
                imgProfile = filedialogueProfilePic.FileName;
            }
        }

        private void btnEditSchedule_Click(object sender, EventArgs e)
        {
            this.mainForm.NavigateToForm(new frmDoctorSchedule(mainForm, key_index));
            this.Close();
        }

        private void btnSaveEditDoctor_Click(object sender, EventArgs e)
        {

            try
            {
                if (!HasDataChanged())
                {
                    MessageBox.Show("No changes detected. Record not updated.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                g_proc.sqlCommand.Parameters.Clear();
                g_proc.sqlCommand.CommandText = "procSaveEditDoctorDetail";
                g_proc.sqlCommand.CommandType = CommandType.StoredProcedure;

                g_proc.sqlCommand.Parameters.AddWithValue("@p_id", key_index);
                g_proc.sqlCommand.Parameters.AddWithValue("@p_firstname", txtFirstName.Text);
                g_proc.sqlCommand.Parameters.AddWithValue("@p_lastname", txtLastName.Text);
                g_proc.sqlCommand.Parameters.AddWithValue("@p_birthdate", dtBirthdate.Value);
                g_proc.sqlCommand.Parameters.AddWithValue("@p_gender", func_GetSelectedGender());
                g_proc.sqlCommand.Parameters.AddWithValue("@p_address", txtAddress.Text);
                g_proc.sqlCommand.Parameters.AddWithValue("@p_mobile", txtMobileNo.Text);
                g_proc.sqlCommand.Parameters.AddWithValue("@p_email", txtEmail.Text);
                g_proc.sqlCommand.Parameters.AddWithValue("@p_photo", imgProfile);
                g_proc.sqlCommand.Parameters.AddWithValue("@p_amount", txtConsultation.Text);     // tbldoctorconsultationfee

                g_proc.sqlCommand.ExecuteNonQuery();

                MessageBox.Show("Record updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                func_LoadDoctorData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool HasDataChanged()
        {
            return txtEmail.Text != originalEmail ||
                   txtMobileNo.Text != originalMobileNo ||
                   txtAddress.Text != originalAddress ||
                   txtConsultation.Text != originalConsultationAmount;
        }
    }
}
