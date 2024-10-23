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
    public partial class frmEditPayment : Form
    {
        GlobalProcedure g_proc = new GlobalProcedure();
        private frmSecretaryMain mainForm;
        private int billing_id;
        public frmEditPayment(frmSecretaryMain mainForm, int billing_id)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.billing_id = billing_id;
        }

        private void frmEditPayment_Load(object sender, EventArgs e)
        {
            g_proc.fncConnectToDatabase();
        }

        private void func_LoadBilling()
        {
            // fetch billing details (procGetPatientBillByID)
            // load existing amount to txtAmount
            // load existing status to cmbStatus

            try
            {
                g_proc.sqlCommand.Parameters.Clear();
                g_proc.sqlCommand.CommandText = "procGetPatientBillByID";
                g_proc.sqlCommand.Parameters.AddWithValue("@p_billing_id", billing_id);
                g_proc.sqlCommand.CommandType = CommandType.StoredProcedure;

                g_proc.sqlClinicAdapter.SelectCommand = g_proc.sqlCommand;
                g_proc.datDoctors.Clear();
                g_proc.sqlClinicAdapter.Fill(g_proc.datDoctors);

                DataRow row = g_proc.datDoctors.Rows[0];
                txtAmount.Text = row["amount"].ToString();
                cmbStatus.Text = row["status"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            //procUpdatePatientBillByID (id, amount, status)

            try
            {
                g_proc.sqlCommand.Parameters.Clear();
                g_proc.sqlCommand.CommandText = "procUpdatePatientBillByID";
                g_proc.sqlCommand.CommandType = CommandType.StoredProcedure;

                g_proc.sqlCommand.Parameters.AddWithValue("@p_billing_id", billing_id);
                g_proc.sqlCommand.Parameters.AddWithValue("@p_amount", txtAmount.Text);
                g_proc.sqlCommand.Parameters.AddWithValue("@p_status", cmbStatus.Text);

                g_proc.sqlCommand.ExecuteNonQuery();

                MessageBox.Show("Payment updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
