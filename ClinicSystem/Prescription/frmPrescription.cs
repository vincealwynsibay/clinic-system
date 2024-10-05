using ClinicSystem.DoctorMain;
using ClinicSystem.Prescription;
using Google.Protobuf.WellKnownTypes;
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

namespace ClinicSystem
{
    public partial class frmPrescription : Form
    {
        GlobalProcedure g_proc = new GlobalProcedure();

        private frmDoctorMain mainForm;
        private int doctor_id;
        private int patient_id;
        private int prescription_id;

        private int row;
        public frmPrescription(frmDoctorMain mainForm, int doctor_id, int patient_id, int prescription_id)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.doctor_id = doctor_id;
            this.patient_id = patient_id;
            this.prescription_id = prescription_id;
            g_proc.fncConnectToDatabase();

            func_LoadPrescription();
        }

        private void func_LoadPrescription()
        {
            try
            {
                g_proc.sqlClinicAdapter = new MySqlDataAdapter();
                g_proc.datPrescription = new DataTable();

                g_proc.sqlCommand.Parameters.Clear();
                g_proc.sqlCommand.CommandText = "procGetPrescriptionDetail";

                g_proc.sqlCommand.Parameters.AddWithValue("@p_prescription_id", prescription_id);

                g_proc.sqlCommand.CommandType = CommandType.StoredProcedure;
                g_proc.sqlClinicAdapter.SelectCommand = g_proc.sqlCommand;
                g_proc.datPrescription.Clear();
                g_proc.sqlClinicAdapter.Fill(g_proc.datPrescription);

                if (g_proc.datPrescription.Rows.Count > 0)
                {
                    row = 0;
                    grdPrescription.RowCount = g_proc.datPrescription.Rows.Count;
                    while (!(g_proc.datPrescription.Rows.Count - 1 < row))
                    {
                        var patientRow = g_proc.datPrescription.Rows[row];

                        grdPrescription.Rows[row].Cells[0].Value = patientRow["quantity"].ToString();
                        grdPrescription.Rows[row].Cells[1].Value = patientRow["medicine"].ToString();
                        grdPrescription.Rows[row].Cells[2].Value = patientRow["dosage"].ToString();
                        grdPrescription.Rows[row].Cells[3].Value = patientRow["frequency"].ToString();
                        grdPrescription.Rows[row].Cells[4].Value = patientRow["comment"].ToString();
                        row++;
                    }
                }
                else
                {
                    grdPrescription.RowCount = 0;
                }
                g_proc.sqlClinicAdapter.Dispose();
                g_proc.datPrescription.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.mainForm.NavigateToForm(new frmPatientDetail(mainForm, doctor_id, patient_id));
            this.Close();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            this.mainForm.NavigateToForm(new frmPrescriptionModify(mainForm, doctor_id, patient_id, prescription_id));
            this.Close();
        }
    }
}
