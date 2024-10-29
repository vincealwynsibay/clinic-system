using ClinicSystem.DoctorAppointment;
using ClinicSystem.DoctorMain;
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
    public partial class frmDoctorMain : Form
    {
        private int doctor_id;
        GlobalProcedure g_proc = new GlobalProcedure();
        public frmDoctorMain(int doctor_id)
        {
            InitializeComponent();
            this.doctor_id = doctor_id;
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
                g_proc.sqlCommand.Parameters.AddWithValue("@p_id", doctor_id);
                g_proc.sqlCommand.CommandType = CommandType.StoredProcedure;
                g_proc.sqlClinicAdapter.SelectCommand = g_proc.sqlCommand;
                g_proc.datDoctors.Clear();
                g_proc.sqlClinicAdapter.Fill(g_proc.datDoctors);

                DataRow row = g_proc.datDoctors.Rows[0];
                //string name = (row["firstname"].ToString() + " " + (string.IsNullOrEmpty(row["middlename"].ToString()) ? "" : row["middlename"].ToString() + " ") + row["lastname"].ToString()) + ", PhD";
                //if (name.ToString().Length > 10)
                //{
                //    txtName.Text = "Dr. " + row["lastname"].ToString();
                //} else
                //{
                //    txtName.Text = "Dr. " + name;
                //}

                txtName.Text = (row["firstname"].ToString() + " " + (string.IsNullOrEmpty(row["middlename"].ToString()) ? "" : row["middlename"].ToString() + " ") + row["lastname"].ToString());

                if (row["photo"] != DBNull.Value && row["photo"].ToString() != "")
                {
                    picProfile.Image = new Bitmap(row["photo"].ToString());
                }
            }
            catch (Exception ex)
            {
            }
            g_proc.sqlClinicAdapter.Dispose();
            g_proc.datDoctors.Dispose();
        }

        private void frmDoctorMain_Load(object sender, EventArgs e)
        {
            btnDashboard.PerformClick();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            LoadFormIntoPanel(new frmDoctorDashboard(this, doctor_id));
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

        private void btnPatients_Click(object sender, EventArgs e)
        {
            LoadFormIntoPanel(new frmPatients(this, doctor_id));
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            LoadFormIntoPanel(new frmDoctorSetting(this, doctor_id));
        }

        private void bunifuPanel1_Click(object sender, EventArgs e)
        {

        }

        private void txtName_Click(object sender, EventArgs e)
        {

        }

        private void btnAppointment_Click(object sender, EventArgs e)
        {
            LoadFormIntoPanel(new frmDoctorAppointment(this, doctor_id));
        }
    }
}
