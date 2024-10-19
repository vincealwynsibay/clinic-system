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
    public partial class frmAddAppointment : Form
    {
        GlobalProcedure g_proc = new GlobalProcedure();
        frmSecretaryMain mainForm;
        int secretary_id;
        public frmAddAppointment(frmSecretaryMain mainForm, int secretary_id)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.secretary_id = secretary_id;

            // get all doctors (id, fullname) handled by secretary
            // procGetDoctorsBySecretary

        }

        private void frmAddAppointment_Load(object sender, EventArgs e)
        {
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
                g_proc.sqlCommand.CommandText = "procGetDoctorsBySecretary";
                g_proc.sqlCommand.Parameters.AddWithValue("@p_secretary", secretary_id);
                g_proc.sqlCommand.CommandType = CommandType.StoredProcedure;
                g_proc.sqlClinicAdapter.SelectCommand = g_proc.sqlCommand;

                g_proc.datDoctors.Clear();
                g_proc.sqlClinicAdapter.Fill(g_proc.datDoctors);

                cmbDoctor.DataSource = g_proc.datDoctors;
                cmbDoctor.DisplayMember = "fullname";
                cmbDoctor.ValueMember = "id";
                cmbDoctor.SelectedIndex = 0;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                g_proc.sqlCommand.CommandText = "procCreateAppointment";
                g_proc.sqlCommand.Parameters.AddWithValue("@p_name", txtFullname.Text);
                g_proc.sqlCommand.Parameters.AddWithValue("@p_mobileno", txtMobileNo.Text);
                g_proc.sqlCommand.Parameters.AddWithValue("@p_email", txtEmail.Text);
                g_proc.sqlCommand.Parameters.AddWithValue("@p_appointmentdate", dtAppointmentDate.Value);
                g_proc.sqlCommand.Parameters.AddWithValue("@p_createddate", DateTime.Now);
                g_proc.sqlCommand.Parameters.AddWithValue("@p_doctor_id", cmbDoctor.SelectedValue);
                g_proc.sqlCommand.Parameters.AddWithValue("@p_secretary_id", secretary_id);
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
