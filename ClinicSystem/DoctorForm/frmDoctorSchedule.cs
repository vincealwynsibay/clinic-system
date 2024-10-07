using Guna.UI2.WinForms;
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
    public partial class frmDoctorSchedule : Form
    {
        GlobalProcedure g_proc = new GlobalProcedure();
        private frmDoctorMain mainForm;
        private int key_index = 0;
        public frmDoctorSchedule(frmDoctorMain mainForm, int key_index)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.key_index = key_index;
            g_proc.fncConnectToDatabase();
            func_TimeDateCustomFormat();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.mainForm.NavigateToForm(new frmDoctorSetting(mainForm, key_index));
            this.Close();
        }

        private void func_TimeDateCustomFormat()
        {
            ConfigureTimePicker(timeStartMon);
            ConfigureTimePicker(timeEndMon);

            ConfigureTimePicker(timeStartTue);
            ConfigureTimePicker(timeEndTue);

            ConfigureTimePicker(timeStartWed);
            ConfigureTimePicker(timeEndWed);

            ConfigureTimePicker(timeStartThu);
            ConfigureTimePicker(timeEndThu);

            ConfigureTimePicker(timeStartFri);
            ConfigureTimePicker(timeEndFri);

            ConfigureTimePicker(timeStartSat);
            ConfigureTimePicker(timeEndSat);

            ConfigureTimePicker(timeStartSun);
            ConfigureTimePicker(timeEndSun);
        }

        private void ConfigureTimePicker(Guna2DateTimePicker timePicker)
        {
            timePicker.CustomFormat = "hh:mm tt";
            timePicker.ShowUpDown = true;
        }
    }
}
