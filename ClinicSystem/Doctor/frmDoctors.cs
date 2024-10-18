using ClinicSystem.DoctorForm;
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
    public partial class frmDoctors : Form
    {
        private frmAdminMain mainForm;
        private GlobalProcedure globalProcedure = new GlobalProcedure();
        int row = 0;
        public frmDoctors(frmAdminMain form)
        {
            InitializeComponent();
            mainForm = form;
        }

        private void frmDoctors_Load(object sender, EventArgs e)
        {
            globalProcedure.checkDatabaseConnection();
            prcLoadDoctors();
        }

        private void prcLoadDoctors()
        {
            try
            {
                globalProcedure.sqlClinicAdapter = new MySqlDataAdapter();
                globalProcedure.datDoctors = new DataTable();
                globalProcedure.sqlCommand.Parameters.Clear();
                globalProcedure.sqlCommand.CommandText = "procSearchDoctorByName";
                globalProcedure.sqlCommand.CommandType = CommandType.StoredProcedure;
                globalProcedure.sqlClinicAdapter.SelectCommand = globalProcedure.sqlCommand;
                globalProcedure.sqlCommand.Parameters.AddWithValue("@p_search", txtSearch.Text);
                globalProcedure.datDoctors.Clear();
                globalProcedure.sqlClinicAdapter.Fill(globalProcedure.datDoctors);

                if (globalProcedure.datDoctors.Rows.Count > 0)
                {
                    row = 0;
                    grdDoctors.RowCount = globalProcedure.datDoctors.Rows.Count;    
                    while (!(globalProcedure.datDoctors.Rows.Count - 1 < row))
                    {
                        grdDoctors.Rows[row].Cells[0].Value = globalProcedure.datDoctors.Rows[row]["id"].ToString();
                        grdDoctors.Rows[row].Cells[1].Value = globalProcedure.datDoctors.Rows[row]["firstname"].ToString();
                        grdDoctors.Rows[row].Cells[2].Value = globalProcedure.datDoctors.Rows[row]["lastname"].ToString();
                        grdDoctors.Rows[row].Cells[3].Value = globalProcedure.datDoctors.Rows[row]["gender"].ToString();
                        grdDoctors.Rows[row].Cells[4].Value = globalProcedure.datDoctors.Rows[row]["birthdate"].ToString();
                        grdDoctors.Rows[row].Cells[5].Value = globalProcedure.datDoctors.Rows[row]["email"].ToString();
                        grdDoctors.Rows[row].Cells[6].Value = globalProcedure.datDoctors.Rows[row]["mobileno"].ToString();
                        grdDoctors.Rows[row].Cells[7].Value = globalProcedure.datDoctors.Rows[row]["address"].ToString();
                        grdDoctors.Rows[row].Cells[8].Value = globalProcedure.datDoctors.Rows[row]["secretary"].ToString();
                        row++;
                    }
                }
                else
                {
                    globalProcedure.datDoctors.Clear();
                    grdDoctors.Rows.Clear();
                }

                globalProcedure.sqlClinicAdapter.Dispose();
                globalProcedure.datDoctors.Dispose();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAddDoctor_Click(object sender, EventArgs e)
        {
           globalProcedure.displayFormAsModal(mainForm, new frmAddDoctor(mainForm));
            prcLoadDoctors();
        }

        private void grdDoctors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEditDoctor_Click(object sender, EventArgs e)
        {
            if (grdDoctors.SelectedRows.Count != 0)
            {
                DataGridViewRow row = this.grdDoctors.SelectedRows[0];

                globalProcedure.displayFormAsModal(mainForm, new frmEditDoctor(mainForm, row.Cells["id"].Value.ToString()));
                prcLoadDoctors();
            }
        }

        private void btnDeleteDoctor_Click(object sender, EventArgs e)
        {
            if (grdDoctors.SelectedRows.Count != 0)
            {
                MySqlCommand sqlCmd = this.globalProcedure.sqlCommand;
                try
                {
                    sqlCmd.Parameters.Clear();
                    sqlCmd.CommandText = "procDeleteDoctorByID";
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    DataGridViewRow row = this.grdDoctors.SelectedRows[0];
                    sqlCmd.Parameters.AddWithValue("@p_id", grdDoctors.CurrentRow.Cells["id"].Value.ToString());
                    sqlCmd.ExecuteNonQuery();
                    prcLoadDoctors();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void grdDoctors_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grdDoctors_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            prcLoadDoctors();
        }

        private void frmDoctors_Load_1(object sender, EventArgs e)
        {

        }

        private void btnAssignSecretary_Click(object sender, EventArgs e)
        {
            globalProcedure.displayFormAsModal(mainForm, new frmAssignSecretary(mainForm, Int32.Parse(this.grdDoctors.SelectedRows[0].Cells["id"].Value.ToString())));
            prcLoadDoctors();
        }
    }
}
