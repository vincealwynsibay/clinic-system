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
    public partial class frmSecretaryDashboard : Form
    {
        private frmSecretaryMain mainForm;
        public frmSecretaryDashboard(frmSecretaryMain mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void frmSecretaryDashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
