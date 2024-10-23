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

namespace ClinicSystem.Appointment
{
    public partial class frmEditAppointment : Form
    {
        GlobalProcedure g_proc = new GlobalProcedure();
        int secretary_id;
        int appointment_id;
        public frmEditAppointment(int appointment_id)
        {
            InitializeComponent();
            this.appointment_id = appointment_id;

            // get all doctors (id, fullname) handled by secretary
            // procGetDoctorsBySecretary

        }

        private void frmEditAppointment_Load(object sender, EventArgs e)
        {
            g_proc.fncConnectToDatabase();
            func_LoadAppointment();

        }

        private void func_LoadAppointment()
        {
            g_proc.checkDatabaseConnection();

            MySqlCommand sqlCmd = g_proc.sqlCommand;
            sqlCmd.Parameters.Clear();
            sqlCmd.CommandText = "procGetAppointment";
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@p_id", appointment_id);


            using (var reader = sqlCmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    txtFullname.Text = reader.GetString(reader.GetOrdinal("name"));
                    dtAppointmentDate.Value = (DateTime)reader.GetValue(reader.GetOrdinal("appointmentdate"));
                    txtEmail.Text = reader.GetString(reader.GetOrdinal("email"));
                    txtMobileNo.Text = reader.GetString(reader.GetOrdinal("mobileno"));
                }
            }
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                g_proc.sqlCommand.Parameters.Clear();
                g_proc.sqlCommand.CommandText = "procEditAppointment";
                g_proc.sqlCommand.Parameters.AddWithValue("@p_id", appointment_id);
                g_proc.sqlCommand.Parameters.AddWithValue("@p_name", txtFullname.Text);
                g_proc.sqlCommand.Parameters.AddWithValue("@p_mobileno", txtMobileNo.Text);
                g_proc.sqlCommand.Parameters.AddWithValue("@p_email", txtEmail.Text);
                g_proc.sqlCommand.Parameters.AddWithValue("@p_appointmentdate", dtAppointmentDate.Value);
                g_proc.sqlCommand.CommandType = CommandType.StoredProcedure;
                g_proc.sqlCommand.ExecuteNonQuery();

                MessageBox.Show("Appointment edited successfully!");
                this.Close();
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
