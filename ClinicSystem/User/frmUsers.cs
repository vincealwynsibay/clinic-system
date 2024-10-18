using Bunifu.UI.WinForms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace ClinicSystem
{
    public partial class frmUsers : Form
    {
        private frmAdminMain mainForm;
        private GlobalProcedure globalProcedure = new GlobalProcedure();
        int row = 0;
        public frmUsers(frmAdminMain mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void frmUsers_Load(object sender, EventArgs e)
        {
            this.globalProcedure.checkDatabaseConnection();
            prcLoadUsers();
        }


    private void prcLoadUsers()
        {
            try
            {
                globalProcedure.sqlClinicAdapter = new MySqlDataAdapter();
                globalProcedure.datUsers = new DataTable();

                globalProcedure.sqlCommand.Parameters.Clear();
                globalProcedure.sqlCommand.CommandText = "procSearchUserByUsername";
                globalProcedure.sqlCommand.CommandType = CommandType.StoredProcedure;
                globalProcedure.sqlClinicAdapter.SelectCommand = globalProcedure.sqlCommand;

                globalProcedure.sqlCommand.Parameters.AddWithValue("@p_search", txtSearch.Text);
                globalProcedure.datUsers.Clear();
                globalProcedure.sqlClinicAdapter.Fill(globalProcedure.datUsers);

                if (globalProcedure.datUsers.Rows.Count > 0)
                {
                    row = 0;
                    //lblTotal.Text = "Total: " + Convert.ToString(globalProcedure.datUsers.Rows.Count);
                    grdUsers.RowCount = globalProcedure.datUsers.Rows.Count;
                    
                    while (!(globalProcedure.datUsers.Rows.Count - 1 < row))
                    {
                        grdUsers.Rows[row].Cells[0].Value = globalProcedure.datUsers.Rows[row]["id"].ToString();
                        grdUsers.Rows[row].Cells[1].Value = globalProcedure.datUsers.Rows[row]["username"].ToString();
                        grdUsers.Rows[row].Cells[2].Value = globalProcedure.datUsers.Rows[row]["role"].ToString();
                        grdUsers.Rows[row].Cells[3].Value = globalProcedure.datUsers.Rows[row]["fullname"].ToString();
                        row++;
                    }
                }
                else
                {
                    globalProcedure.datUsers.Clear();
                    grdUsers.Rows.Clear();
                }

                globalProcedure.sqlClinicAdapter.Dispose();
                globalProcedure.datUsers.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            if (grdUsers.SelectedRows.Count != 0)
            {
                DataGridViewRow row = this.grdUsers.SelectedRows[0];
                globalProcedure.displayFormAsModal(mainForm, new frmEditUser(mainForm, row.Cells["id"].Value.ToString()));
                prcLoadUsers();
            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (grdUsers.SelectedRows.Count != 0)
            {
                MySqlCommand sqlCmd = this.globalProcedure.sqlCommand;
                try
                {
                    sqlCmd.Parameters.Clear();
                    sqlCmd.CommandText = "procDeleteUserByID";
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    DataGridViewRow row = this.grdUsers.SelectedRows[0];
                    sqlCmd.Parameters.AddWithValue("@p_id", grdUsers.CurrentRow.Cells["id"].Value.ToString());
                    sqlCmd.ExecuteNonQuery();
                    prcLoadUsers();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            globalProcedure.displayFormAsModal(mainForm, new frmAddAdmin(mainForm));
            prcLoadUsers();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            prcLoadUsers();
        }
    }
}
