using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicSystem
{
    public partial class frmEditDoctor : Form
    {
        private GlobalProcedure globalProcedure = new GlobalProcedure();
        private frmAdminMain mainForm;
        string id;
        string imgProfile = "";

        public frmEditDoctor(frmAdminMain frmAdminMain, string id)
        {
            InitializeComponent();
            this.id = id;
            this.mainForm = frmAdminMain;
        }

        private void frmEditDoctor_Load(object sender, EventArgs e)
        {
            globalProcedure.checkDatabaseConnection();

            MySqlCommand sqlCmd = globalProcedure.sqlCommand;
            sqlCmd.Parameters.Clear();
            sqlCmd.CommandText = "procGetDoctorById";
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@p_doctorId", id);


            using (var reader = sqlCmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    txtFirstName.Text = reader.GetString(reader.GetOrdinal("firstname"));
                    txtLastName.Text = reader.GetString(reader.GetOrdinal("lastname"));
                    dtBirthdate.Value = (DateTime) reader.GetValue(reader.GetOrdinal("birthdate"));
                    txtEmail.Text = reader.GetString(reader.GetOrdinal("email"));
                    txtMobileNo.Text = reader.GetString(reader.GetOrdinal("mobileno"));
                    txtAddress.Text = reader.GetString(reader.GetOrdinal("address"));

                    if (reader.GetString("gender") == "Male")
                    { 
                        rdoGender1.Checked = true;
                    } else
                    {
                        rdoGender2.Checked = true;
                    }

                    if (reader["photo"] != DBNull.Value)
                    {
                        picProfile.Image = new Bitmap(reader.GetString("photo"));
                    } 
                }
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

        private void btnEditDoctor_Click(object sender, EventArgs e)
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

            try
            {
                sqlCmd.Parameters.Clear();
                sqlCmd.CommandText = "procUpdateDoctorByID";
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@p_id", this.id);
                sqlCmd.Parameters.AddWithValue("@p_firstname", txtFirstName.Text);
                sqlCmd.Parameters.AddWithValue("@p_middlename", "");
                sqlCmd.Parameters.AddWithValue("@p_lastname", txtLastName.Text);
                sqlCmd.Parameters.AddWithValue("@p_gender", gender);
                sqlCmd.Parameters.AddWithValue("@p_birthdate", (DateTime)dtBirthdate.Value);
                sqlCmd.Parameters.AddWithValue("@p_email", txtEmail.Text);
                sqlCmd.Parameters.AddWithValue("@p_mobileno", txtMobileNo.Text);
                sqlCmd.Parameters.AddWithValue("@p_address", txtAddress.Text);
                sqlCmd.Parameters.AddWithValue("@p_photo", imgProfile);
                sqlCmd.ExecuteNonQuery();
               
                MessageBox.Show("Doctor updated Succesfully");
                this.mainForm.NavigateToForm(new frmDoctors(mainForm));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
