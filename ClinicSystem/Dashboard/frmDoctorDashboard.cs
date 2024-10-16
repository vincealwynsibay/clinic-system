using ClinicSystem.Dashboard;
using ClinicSystem.DoctorMain;
using ClinicSystem.Patient;
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
using System.Windows.Forms.VisualStyles;

namespace ClinicSystem
{
    public partial class frmDoctorDashboard : Form
    {
        GlobalProcedure g_proc = new GlobalProcedure();
        private frmDoctorMain mainForm;
        private int doctor_id;
        public frmDoctorDashboard(frmDoctorMain mainForm, int doctor_id)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.doctor_id = doctor_id;
            g_proc.fncConnectToDatabase();

            func_LoadDoctor();
            LoadFormIntoPanel(new frmDashboardAppointment(mainForm, doctor_id));
        }

        public void LoadFormIntoPanel(Form form)
        {
            this.pnlAppointmentTable.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            this.pnlAppointmentTable.Controls.Add(form);
            form.Show();
        }

        private void func_LoadDoctor()
        {
            try
            {
                g_proc.sqlClinicAdapter = new MySqlDataAdapter();
                g_proc.datPatients = new DataTable();

                g_proc.sqlCommand.Parameters.Clear();
                g_proc.sqlCommand.CommandText = "procSearchPatientID";

                g_proc.sqlCommand.Parameters.AddWithValue("@p_search", "");
                g_proc.sqlCommand.Parameters.AddWithValue("@p_filter", 0);    // use index to know what filter to do (0 - none, 1 today, 2 this week, 3 this month, 4 this year)
                g_proc.sqlCommand.Parameters.AddWithValue("@p_doctor_id", doctor_id);               // checks the tbldiagnosis if patient and doctor is related

                g_proc.sqlCommand.CommandType = CommandType.StoredProcedure;
                g_proc.sqlClinicAdapter.SelectCommand = g_proc.sqlCommand;
                g_proc.datPatients.Clear();
                g_proc.sqlClinicAdapter.Fill(g_proc.datPatients);

                lblPatientCount.Text = (Convert.ToString(g_proc.datPatients.Rows.Count));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            g_proc.sqlClinicAdapter.Dispose();
            g_proc.datPatients.Dispose();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.mainForm.NavigateToForm(new frmPatientAdd(mainForm, doctor_id));
            this.Close();
        }
    }
}
