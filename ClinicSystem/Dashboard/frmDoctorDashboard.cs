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
    public partial class frmDoctorDashboard : Form
    {
        private frmDoctorMain mainForm;
        public frmDoctorDashboard(frmDoctorMain mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }
    }
}
