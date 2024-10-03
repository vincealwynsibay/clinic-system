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
    public partial class frmDoctorPatientDiagnosisEdit : Form
    {
        GlobalProcedure g_proc = new GlobalProcedure();

        private frmDoctorMain mainForm;
        private int key_index;
        private int patient_id;
        int v_DiagnosisID;

        public frmDoctorPatientDiagnosisEdit(frmDoctorMain mainForm, int key_index, int patient_id, int v_DiagnosisID)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.key_index = key_index;
            this.patient_id = patient_id;
            this.v_DiagnosisID = v_DiagnosisID;
            g_proc.fncConnectToDatabase();

            func_LoadPatientDiagnosis();
        }

        private void func_LoadPatientDiagnosis()
        {
            try
            {
                g_proc.sqlClinicAdapter = new MySqlDataAdapter();
                g_proc.datPatients = new DataTable();

                g_proc.sqlCommand.Parameters.Clear();
                g_proc.sqlCommand.CommandText = "procGetPatientDiagnosisById";

                g_proc.sqlCommand.Parameters.AddWithValue("@p_id", v_DiagnosisID);

                g_proc.sqlCommand.CommandType = CommandType.StoredProcedure;
                g_proc.sqlClinicAdapter.SelectCommand = g_proc.sqlCommand;
                g_proc.datPatients.Clear();
                g_proc.sqlClinicAdapter.Fill(g_proc.datPatients);

                txtDiagnosis.Text = g_proc.datPatients.Rows[0]["diagnosis"].ToString();
                txtComment.Text = g_proc.datPatients.Rows[0]["comment"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.mainForm.NavigateToForm(new frmDoctorPatientDetail(mainForm, key_index, patient_id));
            this.Close();
        }

        private void btnSaveEdit_Click(object sender, EventArgs e)
        {
            try
            {
                g_proc.sqlCommand.Parameters.Clear();
                g_proc.sqlCommand.CommandText = "procSaveEditPatientDiagnosis";
                g_proc.sqlCommand.CommandType = CommandType.StoredProcedure;

                g_proc.sqlCommand.Parameters.AddWithValue("@p_id", v_DiagnosisID);
                g_proc.sqlCommand.Parameters.AddWithValue("@p_diagnosis", txtDiagnosis.Text);
                g_proc.sqlCommand.Parameters.AddWithValue("@p_comment", txtComment.Text);

                g_proc.sqlCommand.ExecuteNonQuery();

                MessageBox.Show("Record updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.mainForm.NavigateToForm(new frmDoctorPatientDetail(mainForm, key_index, patient_id));
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
