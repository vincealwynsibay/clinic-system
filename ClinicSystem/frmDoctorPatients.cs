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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ClinicSystem.DoctorMain
{
    public partial class frmDoctorPatients : Form
    {
        GlobalProcedure g_proc = new GlobalProcedure();
        private frmDoctorMain mainForm;
        private int key_index;
        private int row;

        public frmDoctorPatients(frmDoctorMain mainForm, int key_index)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.key_index = key_index;
            g_proc.fncConnectToDatabase();
            func_DisplayAllPatients();
        }

        public void func_DisplayAllPatients()
        {
            try
            {
                g_proc.sqlClinicAdapter = new MySqlDataAdapter();
                g_proc.datPatients = new DataTable();

                g_proc.sqlCommand.Parameters.Clear();
                g_proc.sqlCommand.CommandText = "procDisplayAllPatients";
                g_proc.sqlCommand.CommandType = CommandType.StoredProcedure;
                g_proc.sqlClinicAdapter.SelectCommand = g_proc.sqlCommand;
                g_proc.datPatients.Clear();
                g_proc.sqlClinicAdapter.Fill(g_proc.datPatients);
                if (g_proc.datPatients.Rows.Count > 0)
                {
                    row = 0;
                    lblTotal.Text = "Total: " + (Convert.ToString(g_proc.datPatients.Rows.Count));
                    grdPatients.RowCount = g_proc.datPatients.Rows.Count;
                    while (!(g_proc.datPatients.Rows.Count - 1 < row))
                    {
                        grdPatients.Rows[row].Cells[0].Value = g_proc.datPatients.Rows[row]["id"].ToString();
                        grdPatients.Rows[row].Cells[1].Value = g_proc.datPatients.Rows[row]["fullname"].ToString();
                        grdPatients.Rows[row].Cells[2].Value = Convert.ToDateTime(g_proc.datPatients.Rows[row]["birthdate"].ToString()).ToShortDateString();
                        grdPatients.Rows[row].Cells[3].Value = g_proc.datPatients.Rows[row]["gender"].ToString();
                        grdPatients.Rows[row].Cells[4].Value = g_proc.datPatients.Rows[row]["mobileno"].ToString();
                        grdPatients.Rows[row].Cells[5].Value = g_proc.datPatients.Rows[row]["email"].ToString();
                        grdPatients.Rows[row].Cells[6].Value = g_proc.datPatients.Rows[row]["maritalstatus"].ToString();
                        grdPatients.Rows[row].Cells[7].Value = g_proc.datPatients.Rows[row]["emergencyno"].ToString();
                        row++;
                    }
                }
                else
                {
                    MessageBox.Show("Record not Found!", "Records", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                g_proc.sqlClinicAdapter.Dispose();
                g_proc.datPatients.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message);
            }
        }

        private void func_Search(string v_search, string v_row)
        {
            try
            {
                g_proc.sqlClinicAdapter = new MySqlDataAdapter();
                g_proc.datPatients = new DataTable();

                g_proc.sqlCommand.Parameters.Clear();
                g_proc.sqlCommand.CommandText = v_row;
                g_proc.sqlCommand.Parameters.AddWithValue("@p_search", v_search);
                g_proc.sqlCommand.CommandType = CommandType.StoredProcedure;
                g_proc.sqlClinicAdapter.SelectCommand = g_proc.sqlCommand;
                g_proc.datPatients.Clear();
                g_proc.sqlClinicAdapter.Fill(g_proc.datPatients);
                if (g_proc.datPatients.Rows.Count > 0)
                {
                    row = 0;
                    lblTotal.Text = "Total Patients: " + (Convert.ToString(g_proc.datPatients.Rows.Count));
                    grdPatients.RowCount = g_proc.datPatients.Rows.Count;
                    while (!(g_proc.datPatients.Rows.Count - 1 < row))
                    {
                        var patientRow = g_proc.datPatients.Rows[row];

                        grdPatients.Rows[row].Cells[0].Value = patientRow["id"].ToString();
                        grdPatients.Rows[row].Cells[1].Value = patientRow["firstname"].ToString() + " " + (string.IsNullOrEmpty(patientRow["middlename"].ToString()) ? "" : patientRow["middlename"].ToString() + " ") + patientRow["lastname"].ToString();
                        grdPatients.Rows[row].Cells[2].Value = Convert.ToDateTime(patientRow["birthdate"].ToString()).ToShortDateString();
                        grdPatients.Rows[row].Cells[3].Value = patientRow["gender"].ToString();
                        grdPatients.Rows[row].Cells[4].Value = patientRow["mobileno"].ToString();
                        grdPatients.Rows[row].Cells[5].Value = patientRow["email"].ToString();
                        grdPatients.Rows[row].Cells[6].Value = patientRow["maritalstatus"].ToString();
                        grdPatients.Rows[row].Cells[7].Value = patientRow["emergencyno"].ToString();
                        row++;
                    }
                }
                g_proc.sqlClinicAdapter.Dispose();
                g_proc.datPatients.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Search Error: " + ex.Message);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                func_DisplayAllPatients();
                return;
            }
             
            switch (cboSearch.SelectedIndex)
            {
                case 0:
                    func_Search(txtSearch.Text,"procSearchPatientID");
                    break;
                case 1:
                    func_Search(txtSearch.Text,"procSearchPatientName");
                    break;
            }
        }
    }
}
