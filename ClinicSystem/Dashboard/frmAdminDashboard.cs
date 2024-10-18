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
    public partial class frmAdminDashboard : Form
    {
        GlobalProcedure globalProcedures = new GlobalProcedure();
        private frmAdminMain mainForm;
        public frmAdminDashboard(frmAdminMain mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            globalProcedures.displayFormAsModal(mainForm, new frmAddDoctor(mainForm));
        }

        private void func_LoadAnalytics()
        {

            globalProcedures.sqlClinicAdapter = new MySqlDataAdapter();
            MySqlCommand sqlCmd = globalProcedures.sqlCommand;
            sqlCmd.Parameters.Clear();
            sqlCmd.CommandText = "procGetAllDataAnalytics";
            sqlCmd.CommandType = CommandType.StoredProcedure;

            using (var reader = sqlCmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    lblDoctorCount.Text = reader.GetInt32(reader.GetOrdinal("DoctorCount")).ToString();
                    lblPatientsCount.Text = reader.GetInt32(reader.GetOrdinal("PatientCount")).ToString(); // based on total appoinments this month
                    lblSecretaryCount.Text = reader.GetInt32(reader.GetOrdinal("SecretaryCount")).ToString();
                }
            }
        }

        private void frmAdminDashboard_Load(object sender, EventArgs e)
        {
            globalProcedures.checkDatabaseConnection();
            func_LoadAnalytics();
        }
    }
}
