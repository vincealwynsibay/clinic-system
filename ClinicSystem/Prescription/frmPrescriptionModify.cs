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

        private int row;
        private string originalQuantity;
        private string originalMedicine;
        private string originalDosage;
        private string originalFrequency;
        private string originalComment;

        public frmPrescriptionModify(frmDoctorMain mainForm, int doctor_id, int patient_id, int prescription_id)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.doctor_id = doctor_id;
            this.patient_id = patient_id;
            this.prescription_id = prescription_id;
            g_proc.fncConnectToDatabase();

            btnDelete.Visible = false;
            btnSave.Visible = false;
            func_LoadPrescription();
        }

        private void func_LoadPrescription()
        {
            txtQuantity.Focus();
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
                        grdPrescription.Rows[row].Cells[5].Value = patientRow["id"].ToString(); // this is hidden
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
            this.mainForm.NavigateToForm(new frmPrescription(mainForm, doctor_id, patient_id, prescription_id));
            this.Close();
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

                func_LoadPrescription();
                func_ClearTextBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void func_ClearTextBox()
        {
            txtQuantity.Clear();
            txtMedicine.Clear();
            txtDosage.Clear();
            txtFrequency.Clear();
            txtComment.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        { 
            DialogResult result = MessageBox.Show(
                    "Are you sure you want to delete this row?",
                    "Confirm Deletion",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

            if (result == DialogResult.No)
            {
                return;
            }

            try
            {
                g_proc.sqlCommand.Parameters.Clear();
                g_proc.sqlCommand.CommandText = "procDeletePrescriptionItem";
                g_proc.sqlCommand.CommandType = CommandType.StoredProcedure;

                g_proc.sqlCommand.Parameters.AddWithValue("@p_id", prescriptionitem_id);

                g_proc.sqlCommand.ExecuteNonQuery();

                MessageBox.Show("Record deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                func_LoadPrescription();
                func_ClearTextBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            btnDelete.Visible = false;
            btnSave.Visible = false;
            btnAdd.Visible = true;
            func_ClearTextBox();
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

                MessageBox.Show("Record added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                func_LoadPrescription();
                func_ClearTextBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            btnDelete.Visible = false;
            btnSave.Visible = false;
            btnAdd.Visible = true;
            func_ClearTextBox();
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void grdPrescription_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnDelete.Visible = true;
            btnSave.Visible = true;
            btnAdd.Visible = false;

            prescriptionitem_id = Convert.ToInt32(grdPrescription.CurrentRow.Cells[5].Value);   // to avoid current row being alternated
            txtQuantity.Text = grdPrescription.CurrentRow.Cells[0].Value.ToString();
            txtMedicine.Text = grdPrescription.CurrentRow.Cells[1].Value.ToString();
            txtDosage.Text = grdPrescription.CurrentRow.Cells[2].Value.ToString();
            txtFrequency.Text = grdPrescription.CurrentRow.Cells[3].Value.ToString();
            txtComment.Text = grdPrescription.CurrentRow.Cells[4].Value.ToString();

            originalQuantity = txtQuantity.Text;
            originalMedicine = txtMedicine.Text;
            originalDosage = txtDosage.Text;
            originalFrequency = txtFrequency.Text;
            originalComment = txtComment.Text;

            txtQuantity.Focus();
        }
    }
}
