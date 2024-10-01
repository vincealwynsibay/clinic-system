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
    public partial class frmDoctorDashboard : Form
    {
        GlobalProcedure g_proc = new GlobalProcedure();
        private frmDoctorMain mainForm;
        private int key_index;
        public frmDoctorDashboard(frmDoctorMain mainForm, int key_index)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.key_index = key_index;
            g_proc.fncConnectToDatabase();
            func_LoadDoctor();
        }

        private void func_LoadDoctor()
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
                lblDoctorName.Text = "Dr. " + (row["firstname"].ToString() + " " + (string.IsNullOrEmpty(row["middlename"].ToString()) ? "" : row["middlename"].ToString() + " ") + row["lastname"].ToString()) + ", PhD";

                //picProfile.Image = Image.FromFile("photo"); not working
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            g_proc.sqlClinicAdapter.Dispose();
            g_proc.datDoctors.Dispose();
        }
    }
}
