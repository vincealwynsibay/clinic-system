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
    public partial class frmAddAdmin : Form
    {
        private frmAdminMain mainForm;
        private GlobalProcedure globalProcedure = new GlobalProcedure();
        public frmAddAdmin(frmAdminMain frmAdminMain)
        {
            InitializeComponent();
            this.mainForm = frmAdminMain;
        }

        private void frmAddAdmin_Load(object sender, EventArgs e)
        {
            this.globalProcedure.checkDatabaseConnection();
        }

        private void btnAddAdmin_Click(object sender, EventArgs e)
        {
            MySqlCommand sqlCmd = this.globalProcedure.sqlCommand;

            if (!txtPassword.Text.Equals(txtConfirmPassword.Text))
            {
                MessageBox.Show("Password and Confirm Password is not Equal");
                return;
            }

            try
            {
                string hashedPassword = BCrypt.Net.BCrypt.EnhancedHashPassword(txtPassword.Text, 13);

                sqlCmd.Parameters.Clear();
                sqlCmd.CommandText = "procAddUser";
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@p_username", txtUsername.Text);
                sqlCmd.Parameters.AddWithValue("@p_password", hashedPassword);
                sqlCmd.ExecuteNonQuery();

                MessageBox.Show("User added Succesfully");
                this.mainForm.NavigateToForm(new frmUsers(mainForm));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
