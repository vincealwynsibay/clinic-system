﻿using MySql.Data.MySqlClient;
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
    public partial class frmLogin : Form
    {
        GlobalProcedure globalProcedure = new GlobalProcedure();
        public frmLogin()
        {
            InitializeComponent();
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.globalProcedure.checkDatabaseConnection();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            MySqlCommand sqlCmd = this.globalProcedure.sqlCommand;

            try
            {
                sqlCmd.Parameters.Clear();
                sqlCmd.CommandText = "procLogin";
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@p_username", txtUsername.Text);
                sqlCmd.Parameters.AddWithValue("@p_password", txtPassword.Text);

                string username = "";
                string password = "";
                int id = -1;
                int role = -1;
                using (var reader = sqlCmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        id = Int32.Parse(reader[0].ToString());
                        username = reader[1].ToString();
                        password = reader[2].ToString();
                        role = Int32.Parse(reader[3].ToString());
                    }
                }

                bool isValid = BCrypt.Net.BCrypt.EnhancedVerify(txtPassword.Text, password);

                if (isValid && !username.Equals(""))
                {
                    if (role == 1)
                    {
                        frmAdminMain frmAdmin = new frmAdminMain(id);
                        frmAdmin.Show();
                        this.Hide();
                    }
                    else if (role == 2)
                    {
                        frmDoctorMain frmDoctor = new frmDoctorMain(id);  // Replace '5' with the variable containing the id of the doctor logging in.
                        frmDoctor.Show();
                        this.Hide();
                    }
                    else if (role == 3)
                    {
                        frmSecretaryMain frmSecretary = new frmSecretaryMain(id);
                        frmSecretary.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Credentials");
                }
            }
            catch
            {

                MessageBox.Show("Invalid Credentials");
            }
        }

    }
}
