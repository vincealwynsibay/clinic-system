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
    public partial class frmAddSecretary : Form
    {
        private frmAdminMain mainForm;
        private GlobalProcedure globalProcedure = new GlobalProcedure();
        string imgProfile = "";
        public frmAddSecretary(frmAdminMain frmAdminMain)
        {
            InitializeComponent();
            this.mainForm = frmAdminMain;
        }

        private void btnAddSecretary_Click(object sender, EventArgs e)
        {
            MySqlCommand sqlCmd = this.globalProcedure.sqlCommand;

            string gender = "";

            if (rdoGender1.Checked)
            {
                gender = "Male";
            }
            else
            {
                gender = "Female";
            }

            if (!txtPassword.Text.Equals(txtConfirmPassword.Text))
            {
                MessageBox.Show("Password and Confirm Password is not Equal");
                return;
            }

            try
            {
                sqlCmd.Parameters.Clear();
                sqlCmd.CommandText = "procAddSecretary";
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@p_firstname", txtFirstName.Text);
                sqlCmd.Parameters.AddWithValue("@p_middlename", "");
                sqlCmd.Parameters.AddWithValue("@p_lastname", txtLastName.Text);
                sqlCmd.Parameters.AddWithValue("@p_gender", gender);
                sqlCmd.Parameters.AddWithValue("@p_birthdate", (DateTime)dtBirthdate.Value);
                sqlCmd.Parameters.AddWithValue("@p_email", txtEmail.Text);
                sqlCmd.Parameters.AddWithValue("@p_mobileno", txtMobileNo.Text);
                sqlCmd.Parameters.AddWithValue("@p_address", txtAddress.Text);
                sqlCmd.Parameters.AddWithValue("@p_photo", imgProfile);

                var secretary_id = sqlCmd.ExecuteScalar();

                string hashedPassword = BCrypt.Net.BCrypt.EnhancedHashPassword(txtPassword.Text, 13);

                sqlCmd.Parameters.Clear();
                sqlCmd.CommandText = "procAddUser";
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@p_username", txtUsername.Text);
                sqlCmd.Parameters.AddWithValue("@p_password", hashedPassword);
                sqlCmd.Parameters.AddWithValue("@p_role", 3);
                sqlCmd.Parameters.AddWithValue("@p_doctorId", null);
                sqlCmd.Parameters.AddWithValue("@p_secretaryId", secretary_id);
                sqlCmd.ExecuteNonQuery();

                MessageBox.Show("Secretary added Succesfully");
                this.mainForm.NavigateToForm(new frmSecretaries(mainForm));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void picProfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialogProfilePic = new OpenFileDialog();
            fileDialogProfilePic.Filter = "Image Files(*.jpeg;*.bmp;*.png;*.jpg)|*.jpeg;*.bmp;*.png;*.jpg"; ;
            if (fileDialogProfilePic.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                picProfile.BackgroundImage = new Bitmap(fileDialogProfilePic.FileName);
                picProfile.Image = new Bitmap(fileDialogProfilePic.FileName);
                imgProfile = fileDialogProfilePic.FileName;
            }
        }

        private void frmAddSecretary_Load(object sender, EventArgs e)
        {
            globalProcedure.checkDatabaseConnection();
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
