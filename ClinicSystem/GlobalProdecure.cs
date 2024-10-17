using Org.BouncyCastle.Tls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using ClinicSystem.Misc;
using System.Drawing;

namespace ClinicSystem
{
    internal class GlobalProcedure
    {
        public string server;
        public string database;
        public string username;
        public string password;
        public string port;

        public MySqlConnection conLaundry;
        public MySqlCommand sqlCommand;
        public string strConnection;


        public MySqlDataAdapter sqlClinicAdapter;
        public DataTable datDoctors;
        public DataTable datSecretaries;
        public DataTable datUsers;
        public DataTable datPatients;
        public DataTable datPrescription;

        public bool fncConnectToDatabase()
        {
            try
            {
                server = "localhost";
                database = "clinicsystem";
                username = "root";
                password = "Harmonize0805";
                port = "3306";

                strConnection = "Server=" + server + ";" +
                        "Database=" + database + ";" +
                        "User=" + username + ";" +
                        "Password=" + password + ";" +
                        "Port=" + port + ";" +
                        "Convert Zero Datetime=true";
                conLaundry = new MySqlConnection(strConnection);
                sqlCommand = new MySqlCommand(strConnection, conLaundry);

                if (conLaundry.State == System.Data.ConnectionState.Closed)
                {
                    sqlCommand.Connection = conLaundry;
                    conLaundry.Open();
                    return true;
                }
                else
                {
                    conLaundry.Close();
                    return false;
                }

            }
            catch (Exception err)
            {
                MessageBox.Show("Error Message " + err.Message);
            }
            return false;
        }

        public void checkDatabaseConnection()
        {
            if (fncConnectToDatabase().Equals(false))
            {
                conLaundry.Open();
            }
            else
            {
            }
        }

        public void displayFormAsModal(Form frmParent, Form frmChild)
        {
            Form frmModalBackground = new Form();
            frmModalBackground.ShowInTaskbar = false;
            frmModalBackground.StartPosition = FormStartPosition.Manual;
            frmModalBackground.FormBorderStyle = FormBorderStyle.None;
            frmModalBackground.BackColor = Color.Black;
            frmModalBackground.Opacity = 0.50d;
            frmModalBackground.Location = frmParent.Location;
            frmModalBackground.TopMost = false;
            frmModalBackground.Owner = frmParent;
            frmModalBackground.Size = frmParent.Size;
            frmModalBackground.Show();

            frmChild.ShowInTaskbar = false;
            frmChild.TopMost = false;
            frmChild.Owner = frmParent;
            frmChild.StartPosition = FormStartPosition.CenterParent;

            //MessageBox.Show((frmParent.Width * 0.8).ToString());
            //MessageBox.Show((frmParent.Height * 0.8).ToString());
            //MessageBox.Show((frmModalBackground.Width * 0.8).ToString());
            //MessageBox.Show((frmModalBackground.Height * 0.8).ToString());
            frmChild.Size = new System.Drawing.Size(
            (int)(frmModalBackground.Width * 0.8),
            (int)(frmModalBackground.Height * 0.8)
        );
            frmChild.ShowDialog();

            frmModalBackground.Close();
            frmModalBackground.Dispose();
            frmParent.BringToFront();

        }
    }
}
