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
    }
}
