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
    public partial class frmSecretaries : Form
    {
        private frmAdminMain mainForm;
        private GlobalProcedure globalProcedure = new GlobalProcedure();
        int row = 0;

        public frmSecretaries(frmAdminMain form)
        {
            InitializeComponent();
            mainForm = form;
        }


        private void frmSecretaries_Load(object sender, EventArgs e)
        {
            globalProcedure.checkDatabaseConnection();
            prcLoadSecretaries();
        }

        private void prcLoadSecretaries()
        {
            try
            {
                globalProcedure.sqlClinicAdapter = new MySqlDataAdapter();
                globalProcedure.datSecretaries = new DataTable();

                globalProcedure.sqlCommand.Parameters.Clear();
                globalProcedure.sqlCommand.CommandText = "procSearchSecretaryByName";
                globalProcedure.sqlCommand.CommandType = CommandType.StoredProcedure;
                globalProcedure.sqlClinicAdapter.SelectCommand = globalProcedure.sqlCommand;
                globalProcedure.sqlCommand.Parameters.AddWithValue("@p_search", txtSearch.Text);
                globalProcedure.datSecretaries.Clear();
                globalProcedure.sqlClinicAdapter.Fill(globalProcedure.datSecretaries);

                if (globalProcedure.datSecretaries.Rows.Count > 0)
                {
                    row = 0;
                    //lblTotal.Text = "Total: " + Convert.ToString(globalProcedure.datSecretaries.Rows.Count);
                    grdSecretaries.RowCount = globalProcedure.datSecretaries.Rows.Count;
                    while (!(globalProcedure.datSecretaries.Rows.Count - 1 < row))
                    {
                        grdSecretaries.Rows[row].Cells[0].Value = globalProcedure.datSecretaries.Rows[row]["id"].ToString();
                        grdSecretaries.Rows[row].Cells[1].Value = globalProcedure.datSecretaries.Rows[row]["firstname"].ToString();
                        grdSecretaries.Rows[row].Cells[2].Value = globalProcedure.datSecretaries.Rows[row]["lastname"].ToString();
                        grdSecretaries.Rows[row].Cells[3].Value = globalProcedure.datSecretaries.Rows[row]["gender"].ToString();
                        grdSecretaries.Rows[row].Cells[4].Value = globalProcedure.datSecretaries.Rows[row]["birthdate"].ToString();
                        grdSecretaries.Rows[row].Cells[5].Value = globalProcedure.datSecretaries.Rows[row]["email"].ToString();
                        grdSecretaries.Rows[row].Cells[6].Value = globalProcedure.datSecretaries.Rows[row]["mobileno"].ToString();
                        grdSecretaries.Rows[row].Cells[7].Value = globalProcedure.datSecretaries.Rows[row]["address"].ToString();
                        row++;
                    }
                }
                else
                {
                    globalProcedure.datSecretaries.Clear();
                    grdSecretaries.Rows.Clear();
                }

                globalProcedure.sqlClinicAdapter.Dispose();
                globalProcedure.datSecretaries.Dispose();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAddSecretary_Click(object sender, EventArgs e)
        {
            globalProcedure.displayFormAsModal(mainForm, new frmAddSecretary(mainForm));
        }

        private void btnEditSecretary_Click(object sender, EventArgs e)
        {
            if (grdSecretaries.SelectedRows.Count != 0)
            {
                DataGridViewRow row = this.grdSecretaries.SelectedRows[0];
                globalProcedure.displayFormAsModal(mainForm, new frmEditSecretary(mainForm, row.Cells["id"].Value.ToString()));
            }
        }

        private void btnDeleteSecretary_Click(object sender, EventArgs e)
        {
            if (grdSecretaries.SelectedRows.Count != 0)
            {
                MySqlCommand sqlCmd = this.globalProcedure.sqlCommand;
                try
                {
                    sqlCmd.Parameters.Clear();
                    sqlCmd.CommandText = "procDeleteSecretaryByID";
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    DataGridViewRow row = this.grdSecretaries.SelectedRows[0];
                    sqlCmd.Parameters.AddWithValue("@p_id", grdSecretaries.CurrentRow.Cells["id"].Value.ToString());
                    sqlCmd.ExecuteNonQuery();
                    prcLoadSecretaries();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            prcLoadSecretaries();
        }
    }
}
