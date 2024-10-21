using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cmp;
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
    public partial class frmPaymentForm : Form
    {
        GlobalProcedure g_proc = new GlobalProcedure();
        private frmSecretaryMain mainForm;
        private int billing_id;
        public frmPaymentForm(frmSecretaryMain mainForm, int billing_id)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.billing_id = billing_id;
        }

        private void func_LoadBilling()
        {
            try
            {

                g_proc.sqlClinicAdapter = new MySqlDataAdapter();
                g_proc.datDoctors = new DataTable();

                g_proc.sqlCommand.Parameters.Clear();
                g_proc.sqlCommand.CommandText = "procGetPatientBillByID";
                g_proc.sqlCommand.Parameters.AddWithValue("@p_id", billing_id);
                g_proc.sqlCommand.CommandType = CommandType.StoredProcedure;
                g_proc.sqlClinicAdapter.SelectCommand = g_proc.sqlCommand;
                g_proc.datDoctors.Clear();
                g_proc.sqlClinicAdapter.Fill(g_proc.datDoctors);

                DataRow row = g_proc.datDoctors.Rows[0];
                txtAmount.Text = row["amountpaid"].ToString();
                lblBalance.Text = "Balance: " + row["balance"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {

            try
            {
                g_proc.sqlCommand.Parameters.Clear();
                g_proc.sqlCommand.CommandText = "procPayPatientBill";
                g_proc.sqlCommand.CommandType = CommandType.StoredProcedure;

                g_proc.sqlCommand.Parameters.AddWithValue("@p_id", billing_id);
                g_proc.sqlCommand.Parameters.AddWithValue("@p_amount_paid", txtAmount.Text);

                g_proc.sqlCommand.ExecuteNonQuery();

                MessageBox.Show("Payment successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmPaymentForm_Load(object sender, EventArgs e)
        {
            g_proc.fncConnectToDatabase();
            func_LoadBilling();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
