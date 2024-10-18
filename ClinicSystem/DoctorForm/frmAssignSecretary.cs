using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicSystem.DoctorForm
{
    public partial class frmAssignSecretary : Form
    {

        private frmAdminMain mainForm;
        private GlobalProcedure globalProcedure = new GlobalProcedure();
        int row = 0;
        int doctorId = 0;
        public frmAssignSecretary(frmAdminMain form, int doctorId)
        {
            InitializeComponent();
            this.mainForm = form;
            this.doctorId = doctorId;
        }

        private void frmAssignSecretary_Load(object sender, EventArgs e)
        {
            globalProcedure.checkDatabaseConnection();
        }

        private void prcLoadSecretaries()
        {
            try
            {

                if (txtSearch.Text.Length < 1)
                {
                    grdSecretaries.Rows.Clear();
                    return;
                }

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
                        string fullname = globalProcedure.datSecretaries.Rows[row]["firstname"].ToString() + " " + globalProcedure.datSecretaries.Rows[row]["lastname"].ToString();
                        grdSecretaries.Rows[row].Cells[0].Value = globalProcedure.datSecretaries.Rows[row]["id"].ToString();
                        grdSecretaries.Rows[row].Cells[1].Value = fullname;
                        row++;
                    }

                    if (globalProcedure.datSecretaries.Rows.Count > 3)
                    {
                        grdSecretaries.Height = 50 * 3;

                    } else
                    {
                        grdSecretaries.Height = 50 * globalProcedure.datSecretaries.Rows.Count;
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
            this.Close();
            this.Dispose();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.TextLength > 1)
            {
                prcLoadSecretaries();
            } else
            {
                grdSecretaries.Rows.Clear();
            }
        }

        private void grdSecretaries_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdSecretaries.SelectedRows.Count != 0)
            {
                DataGridViewRow row = this.grdSecretaries.SelectedRows[0];
                txtSearch.Text = row.Cells["fullname"].Value.ToString();
                txtSearch.Focus();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void btnAssignSecretary_Click(object sender, EventArgs e)
        {
            MySqlCommand sqlCmd = this.globalProcedure.sqlCommand;

            if (grdSecretaries.SelectedRows.Count != 0)
            {
                DataGridViewRow row = this.grdSecretaries.SelectedRows[0];
                try
                {

                    sqlCmd.Parameters.Clear();
                    sqlCmd.CommandText = "procAssignSecretaryToDoctor";
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@p_doctorId", this.doctorId);
                    sqlCmd.Parameters.AddWithValue("@p_secretaryId", row.Cells["id"].Value.ToString());
                    sqlCmd.ExecuteNonQuery();

                    MessageBox.Show("Secretary Assigned Successfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                this.Close();
                this.Dispose();
            }
        }
    }
}
