﻿using ClinicSystem.Dashboard;
using ClinicSystem.DoctorMain;
using ClinicSystem.Patient;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace ClinicSystem
{
    public partial class frmDoctorDashboard : Form
    {
        GlobalProcedure g_proc = new GlobalProcedure();
        private frmDoctorMain mainForm;
        private int doctor_id;
        public frmDoctorDashboard(frmDoctorMain mainForm, int doctor_id)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.doctor_id = doctor_id;
            g_proc.fncConnectToDatabase();

            func_LoadDoctor();
            LoadFormIntoPanel(new frmDashboardAppointment(mainForm, doctor_id));
        }

        public void LoadFormIntoPanel(Form form)
        {
            this.pnlAppointmentTable.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            this.pnlAppointmentTable.Controls.Add(form);
            form.Show();
        }

        private void func_LoadDoctor()
        {
            try
            {
                g_proc.sqlClinicAdapter = new MySqlDataAdapter();
                g_proc.datPatients = new DataTable();

                g_proc.sqlCommand.Parameters.Clear();
                g_proc.sqlCommand.CommandText = "procGetDataAnalytic";

                g_proc.sqlCommand.Parameters.AddWithValue("@p_doctor_id", doctor_id);

                g_proc.sqlCommand.CommandType = CommandType.StoredProcedure;
                g_proc.sqlClinicAdapter.SelectCommand = g_proc.sqlCommand;
                g_proc.datPatients.Clear();
                g_proc.sqlClinicAdapter.Fill(g_proc.datPatients);

                if (g_proc.datPatients.Rows.Count > 0)
                {
                    DataRow row = g_proc.datPatients.Rows[0];
                    lblPatientCount.Text = row["PatientCount"].ToString();      // based on the diagnosis date is created this month
                    lblAppointmentCount.Text = row["AppointmentCount"].ToString();  // based on total appoinments this month
                    lblAppointmentPercent.Text = "+" + row["AppointmentIncreasePercentage"].ToString() + "%";
                    lblPatientPercent.Text = "+" + row["PatientIncreasePercentage"].ToString() + "%";
                    //lblEarningsCount.Text = "₱"+(Convert.ToDouble(row["EarningsCount"]).ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            g_proc.sqlClinicAdapter.Dispose();
            g_proc.datPatients.Dispose();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.mainForm.NavigateToForm(new frmPatientAdd(mainForm, doctor_id));
            this.Close();
        }
    }
}
