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
            this.globalProcedure.checkDatabaseConnection();

            try
            {
                globalProcedure.sqlClinicAdapter = new MySqlDataAdapter();
                globalProcedure.datDoctors = new DataTable();

                globalProcedure.sqlCommand.Parameters.Clear();
                globalProcedure.sqlCommand.CommandText = "procDisplayAllDoctors";
                globalProcedure.sqlCommand.CommandType = CommandType.StoredProcedure;
                globalProcedure.sqlClinicAdapter.SelectCommand = globalProcedure.sqlCommand;
                globalProcedure.datDoctors.Clear();
                globalProcedure.sqlClinicAdapter.Fill(globalProcedure.datDoctors);

                if (globalProcedure.datDoctors.Rows.Count > 0)
                {
                    row = 0;
                    //lblTotal.Text = "Total: " + Convert.ToString(globalProcedure.datDoctors.Rows.Count);
                    grdDoctors.RowCount = globalProcedure.datDoctors.Rows.Count;
                    while (!(globalProcedure.datDoctors.Rows.Count - 1 < row))
                    {
                        grdDoctors.Rows[row].Cells[0].Value = globalProcedure.datDoctors.Rows[row]["id"].ToString();
                        grdDoctors.Rows[row].Cells[1].Value = globalProcedure.datDoctors.Rows[row]["firstname"].ToString();
                        grdDoctors.Rows[row].Cells[2].Value = globalProcedure.datDoctors.Rows[row]["middlename"].ToString();
                        grdDoctors.Rows[row].Cells[3].Value = globalProcedure.datDoctors.Rows[row]["lastname"].ToString();
                        grdDoctors.Rows[row].Cells[4].Value = globalProcedure.datDoctors.Rows[row]["gender"].ToString();
                        grdDoctors.Rows[row].Cells[5].Value = globalProcedure.datDoctors.Rows[row]["birthdate"].ToString();
                        grdDoctors.Rows[row].Cells[6].Value = globalProcedure.datDoctors.Rows[row]["email"].ToString();
                        grdDoctors.Rows[row].Cells[7].Value = globalProcedure.datDoctors.Rows[row]["mobileno"].ToString();
                        grdDoctors.Rows[row].Cells[8].Value = globalProcedure.datDoctors.Rows[row]["address"].ToString();
                        row++;
                    }
                }
                else
                {
                    MessageBox.Show("Record not found!", "Records", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
           this.mainForm.NavigateToForm(new frmAddDoctor(mainForm));
        }

        private void grdDoctors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEditDoctor_Click(object sender, EventArgs e)
        {
            if (grdDoctors.SelectedRows.Count != 0)
            {
                DataGridViewRow row = this.grdDoctors.SelectedRows[0];
                mainForm.NavigateToForm(new frmEditDoctor(row.Cells["id"].Value.ToString()));
            }
        }
    }
}
