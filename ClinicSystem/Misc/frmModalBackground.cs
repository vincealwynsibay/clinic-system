using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicSystem.Misc
{
    public partial class frmModalBackground : Form
    {
        public frmModalBackground()
        {
            InitializeComponent();
        }

        private void frmModalBackground_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
            this.Opacity = 0.5;
        }
    }
}
