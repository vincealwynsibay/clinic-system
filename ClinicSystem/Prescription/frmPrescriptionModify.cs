using ClinicSystem.DoctorMain;
using ClinicSystem.Prescription;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ClinicSystem.Prescription
{
    public partial class frmPrescriptionModify : Form
    {
        GlobalProcedure g_proc = new GlobalProcedure();

        private frmDoctorMain mainForm;
        private int doctor_id;
        private int patient_id;
        private int prescription_id;
        private int prescriptionitem_id;

        private string originalQuantity;
        private string originalMedicine;
        private string originalDosage;
        private string originalFrequency;
        private string originalComment;

        public frmPrescriptionModify(frmDoctorMain mainForm, int doctor_id, int patient_id, int prescription_id, int prescriptionitem_id)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.doctor_id = doctor_id;
            this.patient_id = patient_id;
            this.prescription_id = prescription_id;
            this.prescriptionitem_id = prescriptionitem_id;
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
                g_proc.sqlCommand.CommandText = "procGetPrescriptionItem";

                g_proc.sqlCommand.Parameters.AddWithValue("@p_prescription_id", prescription_id);
                g_proc.sqlCommand.Parameters.AddWithValue("@p_id", prescriptionitem_id);

                g_proc.sqlCommand.CommandType = CommandType.StoredProcedure;
                g_proc.sqlClinicAdapter.SelectCommand = g_proc.sqlCommand;
                g_proc.datPrescription.Clear();
                g_proc.sqlClinicAdapter.Fill(g_proc.datPrescription);

                var patientRow = g_proc.datPrescription.Rows[0];

                txtQuantity.Text = patientRow["quantity"].ToString();
                txtMedicine.Text = patientRow["medicine"].ToString();
                txtDosage.Text = patientRow["dosage"].ToString();
                txtFrequency.Text = patientRow["frequency"].ToString();
                txtComment.Text = patientRow["comment"].ToString();

                g_proc.sqlClinicAdapter.Dispose();
                g_proc.datPrescription.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            originalQuantity = txtQuantity.Text;
            originalMedicine = txtMedicine.Text;
            originalDosage = txtDosage.Text;
            originalFrequency = txtFrequency.Text;
            originalComment = txtComment.Text;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string quantity = txtQuantity.Text;
                string medicine = txtMedicine.Text;
                string dosage = txtDosage.Text;
                string frequency = txtFrequency.Text;
                string comment = txtComment.Text;

                if (quantity == originalQuantity &&
                    medicine == originalMedicine &&
                    dosage == originalDosage &&
                    frequency == originalFrequency &&
                    comment == originalComment)
                {
                    MessageBox.Show("No changes detected in the fields.",
                                    "No Changes",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    return;
                }

                if (string.IsNullOrWhiteSpace(quantity) ||
                    string.IsNullOrWhiteSpace(medicine) ||
                    string.IsNullOrWhiteSpace(dosage) ||
                    string.IsNullOrWhiteSpace(frequency))
                {
                    MessageBox.Show("Please fill in all required fields (Quantity, Medicine, Dosage, Frequency).",
                                    "Validation Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return;
                }

                g_proc.sqlCommand.Parameters.Clear();
                g_proc.sqlCommand.CommandText = "procEditPrescriptionItem";
                g_proc.sqlCommand.CommandType = CommandType.StoredProcedure;

                g_proc.sqlCommand.Parameters.AddWithValue("@p_id", prescriptionitem_id);
                g_proc.sqlCommand.Parameters.AddWithValue("@p_prescription_id", prescription_id);
                g_proc.sqlCommand.Parameters.AddWithValue("@p_quantity", txtQuantity.Text);
                g_proc.sqlCommand.Parameters.AddWithValue("@p_medicine", txtMedicine.Text);
                g_proc.sqlCommand.Parameters.AddWithValue("@p_dosage", txtDosage.Text);
                g_proc.sqlCommand.Parameters.AddWithValue("@p_frequency", txtFrequency.Text);
                g_proc.sqlCommand.Parameters.AddWithValue("@p_comment", txtComment.Text);

                g_proc.sqlCommand.ExecuteNonQuery();

                MessageBox.Show("Modified successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
