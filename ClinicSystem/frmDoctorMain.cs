using ClinicSystem.DoctorMain;
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
        private int key_index;
        public frmDoctorMain(int key_index)
        {
            InitializeComponent();
            this.key_index = key_index;
        }

        private void frmDoctorMain_Load(object sender, EventArgs e)
        {
            btnDashboard.PerformClick();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            LoadFormIntoPanel(new frmDoctorDashboard(this, key_index));
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
            LoadFormIntoPanel(new frmPatients(this, key_index));
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            LoadFormIntoPanel(new frmDoctorSetting(this, key_index));
        }
    }
}
