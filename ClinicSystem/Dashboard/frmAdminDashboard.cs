﻿using System;
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
        private frmAdminMain mainForm;
        public frmAdminDashboard(frmAdminMain mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }
    }
}
