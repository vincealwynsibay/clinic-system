﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicSystem
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin());
            //Application.Run(new frmAdminMain(14)); // Just delete if I didn't delete it. This is just a placeholder to skip login
            //Application.Run(new frmDoctorMain(14)); // Just delete if I didn't delete it. This is just a placeholder to skip login
            //Application.Run(new frmSecretaryMain(5));
        }
    }
}
