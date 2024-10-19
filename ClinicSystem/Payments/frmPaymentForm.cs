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

        private void btnPay_Click(object sender, EventArgs e)
        {

            try
            {
                g_proc.sqlCommand.Parameters.Clear();
                g_proc.sqlCommand.CommandText = "procPayPatientBill";
                g_proc.sqlCommand.CommandType = CommandType.StoredProcedure;

                g_proc.sqlCommand.Parameters.AddWithValue("@p_billing_id", billing_id);
                g_proc.sqlCommand.Parameters.AddWithValue("@p_amount", txtAmount.Text);

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
        }
    }
}
