using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicSystem.DoctorMain
{
    public partial class frmAppointments : Form
    {
        private frmDoctorMain mainForm;
        public frmAppointments(frmDoctorMain mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }
    }
}
