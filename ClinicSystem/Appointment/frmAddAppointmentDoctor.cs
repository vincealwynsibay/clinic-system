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
    public partial class frmAddAppointmentDoctor : Form
    {
        GlobalProcedure g_proc = new GlobalProcedure();
        frmDoctorMain mainForm;
        int doctor_id;
        public frmAddAppointmentDoctor(frmDoctorMain mainForm, int doctor_id)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.doctor_id = doctor_id;
            g_proc.fncConnectToDatabase();
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
                g_proc.sqlCommand.CommandText = "procCreateAppointmentDoctor";
                g_proc.sqlCommand.Parameters.AddWithValue("@p_name", txtFullname.Text);
                g_proc.sqlCommand.Parameters.AddWithValue("@p_mobileno", txtMobileNo.Text);
                g_proc.sqlCommand.Parameters.AddWithValue("@p_email", txtEmail.Text);
                g_proc.sqlCommand.Parameters.AddWithValue("@p_appointmentdate", dtAppointmentDate.Value);
                g_proc.sqlCommand.Parameters.AddWithValue("@p_createddate", DateTime.Now);
                g_proc.sqlCommand.Parameters.AddWithValue("@p_doctor_id", doctor_id);
                g_proc.sqlCommand.CommandType = CommandType.StoredProcedure;
                g_proc.sqlCommand.ExecuteNonQuery();

                MessageBox.Show("Appointment added successfully!");
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
