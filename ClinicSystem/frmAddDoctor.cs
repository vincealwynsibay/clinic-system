using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto.Generators;
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
    public partial class frmAddDoctor : Form
    {
        private frmAdminMain mainForm;
        private GlobalProcedure globalProcedure = new GlobalProcedure();
        public frmAddDoctor(frmAdminMain frmAdminMain)
        {
            InitializeComponent();
            this.mainForm = frmAdminMain;
        }

        private void btnAddDoctor_Click(object sender, EventArgs e)
        {
            MySqlCommand sqlCmd = this.globalProcedure.sqlCommand;

            string gender = "";

            if (rdoGender1.Checked)
            {
                gender = rdoGender1.Text;
            }
            else
            {
                gender = rdoGender2.Text;
            }

            if (!txtPassword.Text.Equals(txtConfirmPassword.Text))
            {
                MessageBox.Show("Password and Confirm Password is not Equal");
                return;
            }

            try
            {
                sqlCmd.Parameters.Clear();
                sqlCmd.CommandText = "procAddDoctor";
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@p_firstname", txtFirstName.Text);
                sqlCmd.Parameters.AddWithValue("@p_middlename", txtMiddleName.Text);
                sqlCmd.Parameters.AddWithValue("@p_lastname", txtLastName.Text);
                sqlCmd.Parameters.AddWithValue("@p_gender", gender);
                sqlCmd.Parameters.AddWithValue("@p_birthdate", (DateTime)dtBirthdate.Value);
                sqlCmd.Parameters.AddWithValue("@p_email", txtEmail.Text);
                sqlCmd.Parameters.AddWithValue("@p_mobileno", txtMobileNo.Text);
                sqlCmd.Parameters.AddWithValue("@p_address", rtxtAddress.Text);

                var doctor_id = sqlCmd.ExecuteScalar();

                //string hashedPassword = BCrypt.Net.BCrypt.EnhancedHashPassword(txtPassword.Text, 13);

                //sqlCmd.Parameters.Clear();
                //sqlCmd.CommandText = "procAddUser";
                //sqlCmd.CommandType = CommandType.StoredProcedure;
                //sqlCmd.Parameters.AddWithValue("@p_username", txtUsername.Text);
                //sqlCmd.Parameters.AddWithValue("@p_password", hashedPassword);
                //sqlCmd.Parameters.AddWithValue("@p_role", 2);
                //sqlCmd.Parameters.AddWithValue("@p_doctorId", doctor_id);
                //sqlCmd.Parameters.AddWithValue("@p_secretaryId", null);
                //sqlCmd.ExecuteNonQuery();

                MessageBox.Show("Doctor added Succesfully");
                this.mainForm.NavigateToForm(new frmDoctors(mainForm));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmAddDoctor_Load(object sender, EventArgs e)
        {
            this.globalProcedure.checkDatabaseConnection();
        }
    }
}
