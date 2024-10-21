using ClinicSystem.Appointment;
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

namespace ClinicSystem
{
    public partial class frmSecretaryMain : Form
    {

        private int key_index;
        GlobalProcedure g_proc = new GlobalProcedure();
        public frmSecretaryMain(int key_index)
        {
            InitializeComponent();
            this.key_index = key_index;
            g_proc.fncConnectToDatabase();
            btnDashboard.PerformClick();
            func_LoadDoctor();
        }

        private void func_LoadDoctor()
        {
            try
            {
                g_proc.sqlClinicAdapter = new MySqlDataAdapter();
                g_proc.datDoctors = new DataTable();

                g_proc.sqlCommand.Parameters.Clear();
                g_proc.sqlCommand.CommandText = "procGetSecretaryDetails";
                g_proc.sqlCommand.Parameters.AddWithValue("@p_id", key_index);
                g_proc.sqlCommand.CommandType = CommandType.StoredProcedure;
                g_proc.sqlClinicAdapter.SelectCommand = g_proc.sqlCommand;

                g_proc.datDoctors.Clear();
                g_proc.sqlClinicAdapter.Fill(g_proc.datDoctors);

                DataRow row = g_proc.datDoctors.Rows[0];
                string name = (row["firstname"].ToString() + " " + (string.IsNullOrEmpty(row["middlename"].ToString()) ? "" : row["middlename"].ToString() + " ") + row["lastname"].ToString());
                if (name.ToString().Length > 10)
                {
                    txtName.Text = row["lastname"].ToString();
                }
                else
                {
                    txtName.Text = name;
                }

                if (row["photo"] != DBNull.Value && row["photo"].ToString() != "")
                {
                    picProfile.Image = new Bitmap(row["photo"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            g_proc.sqlClinicAdapter.Dispose();
            g_proc.datDoctors.Dispose();
        }

        private void frmSecretaryMain_Load(object sender, EventArgs e)
        {
            btnDashboard.PerformClick();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
                LoadFormIntoPanel(new frmSecretaryDashboard(this, key_index));
        }

        public void LoadFormIntoPanel(Form form)
        {
            this.pnlMain.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            this.pnlMain.Controls.Add(form);
            form.Show();
        }

        public void NavigateToForm(Form childForm)
        {
            LoadFormIntoPanel(childForm);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
            this.Hide();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            LoadFormIntoPanel(new frmPatientPayments(this, key_index));
        }

        private void btnAppointments_Click(object sender, EventArgs e)
        {
            LoadFormIntoPanel(new frmSecretaryAppointment(this, key_index));
        }
    }
}
