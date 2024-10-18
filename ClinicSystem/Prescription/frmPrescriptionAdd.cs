using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicSystem.Prescription
{
    public partial class frmPrescriptionAdd : Form
    {
        GlobalProcedure g_proc = new GlobalProcedure();

        private frmDoctorMain mainForm;
        private int doctor_id;
        private int patient_id;
        private int prescription_id;

        public frmPrescriptionAdd(frmDoctorMain mainForm, int doctor_id, int patient_id, int prescription_id)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.doctor_id = doctor_id;
            this.patient_id = patient_id;
            this.prescription_id = prescription_id;
            g_proc.fncConnectToDatabase();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string quantity = txtQuantity.Text;
                string medicine = txtMedicine.Text;
                string dosage = txtDosage.Text;
                string frequency = txtFrequency.Text;
                string comment = txtComment.Text;

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
                g_proc.sqlCommand.CommandText = "procAddPrescriptionItem";
                g_proc.sqlCommand.CommandType = CommandType.StoredProcedure;

                g_proc.sqlCommand.Parameters.AddWithValue("@p_prescription_id", prescription_id);
                g_proc.sqlCommand.Parameters.AddWithValue("@p_quantity", txtQuantity.Text);
                g_proc.sqlCommand.Parameters.AddWithValue("@p_medicine", txtMedicine.Text);
                g_proc.sqlCommand.Parameters.AddWithValue("@p_dosage", txtDosage.Text);
                g_proc.sqlCommand.Parameters.AddWithValue("@p_frequency", txtFrequency.Text);
                g_proc.sqlCommand.Parameters.AddWithValue("@p_comment", txtComment.Text);

                g_proc.sqlCommand.ExecuteNonQuery();

                MessageBox.Show("Record added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
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
