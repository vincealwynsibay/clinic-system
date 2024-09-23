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
    public partial class frmEditUser : Form
    {
        private GlobalProcedure globalProcedure = new GlobalProcedure();
        private frmAdminMain mainForm;
        string id;
        public frmEditUser(frmAdminMain frmAdminMain, string id)
        {
            InitializeComponent();
            this.id = id;
            this.mainForm = frmAdminMain;
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            MySqlCommand sqlCmd = this.globalProcedure.sqlCommand;

            try
            {
                sqlCmd.Parameters.Clear();
                sqlCmd.CommandText = "procUpdateUserByID";
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@p_id", this.id);
                sqlCmd.Parameters.AddWithValue("@p_username", txtUsername.Text);

                if (txtPassword.Text.Trim().Length > 0 & txtConfirmPassword.Text.Trim().Length > 0)
                {
                    if (txtPassword.Text.Equals(txtConfirmPassword.Text))
                    {

                        string hashedPassword = BCrypt.Net.BCrypt.EnhancedHashPassword(txtPassword.Text, 13);
                        sqlCmd.Parameters.AddWithValue("@p_password", hashedPassword);
                    } else
                    {
                        MessageBox.Show("Password and Confirm Password should be equal");
                    }
                } else
                {
                    sqlCmd.Parameters.AddWithValue("@p_password", null);
                }
                sqlCmd.ExecuteNonQuery();

                MessageBox.Show("User updated Succesfully");
                this.mainForm.NavigateToForm(new frmUsers(mainForm));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmEditUser_Load(object sender, EventArgs e)
        {
            globalProcedure.checkDatabaseConnection();

            MySqlCommand sqlCmd = globalProcedure.sqlCommand;
            sqlCmd.Parameters.Clear();
            sqlCmd.CommandText = "procGetUserByID";
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@p_id", id);


            using (var reader = sqlCmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    txtUsername.Text = reader.GetString(reader.GetOrdinal("username"));
                }
            }
        }
    }
}
