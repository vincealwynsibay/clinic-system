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

        string id;
        public frmEditDoctor(string id)
        {
            InitializeComponent();
            this.id = id;
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
                    txtMiddleName.Text = reader.GetString(reader.GetOrdinal("middlename"));
                    txtLastName.Text = reader.GetString(reader.GetOrdinal("lastname"));
                    dtBirthdate.Value = (DateTime) reader.GetValue(reader.GetOrdinal("birthdate"));
                    txtEmail.Text = reader.GetString(reader.GetOrdinal("email"));
                    txtMobileNo.Text = reader.GetString(reader.GetOrdinal("mobileno"));
                    rtxtAddress.Text = reader.GetString(reader.GetOrdinal("address"));
                }
            }
        }
    }
}
