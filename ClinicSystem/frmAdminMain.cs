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
    public partial class frmAdminMain : Form
    {
        public frmAdminMain()
        {
            InitializeComponent();
        }
        private void frmAdminMain_Load(object sender, EventArgs e)
        {
            btnDoctors.PerformClick();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            LoadFormIntoPanel(new frmAdminDashboard(this));
        }


        private void btnUsers_Click(object sender, EventArgs e)
        {
            LoadFormIntoPanel(new frmUsers(this));
        }

        private void btnDoctors_Click(object sender, EventArgs e)
        {
            LoadFormIntoPanel(new frmDoctors(this));
        }
        private void btnSecretaries_Click(object sender, EventArgs e)
        {
            LoadFormIntoPanel(new frmSecretaries(this));
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

    }
}
