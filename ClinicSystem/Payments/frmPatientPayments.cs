using Guna.UI2.WinForms;
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

namespace ClinicSystem.Patient
{
    public partial class frmPatientPayments : Form
    {
        GlobalProcedure g_proc = new GlobalProcedure();
        private frmSecretaryMain mainForm;
        private int secretary_id;
        private int row;
        private string status = "";
        public frmPatientPayments(frmSecretaryMain main, int secretary_id)
        {
            InitializeComponent();
            this.mainForm = main;
            this.secretary_id = secretary_id;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void frmPatientPayments_Load(object sender, EventArgs e)
        {

            g_proc.fncConnectToDatabase();
            btnUnpaid.PerformClick();
            func_LoadTable();
        }

        private void func_LoadTable()
        {
            grdBillings.CellClick -= func_ResolveBill;

            grdBillings.CellPainting += func_ButtonStyleCell;
            grdBillings.CellClick += func_ResolveBill;

            func_LoadDataFromDB();
        }

        private void func_LoadDataFromDB()
        {
            try
            {
                g_proc.sqlClinicAdapter = new MySqlDataAdapter();
                g_proc.datPatients = new DataTable();

                g_proc.sqlCommand.Parameters.Clear();
                g_proc.sqlCommand.CommandText = "procGetDoctorsBySecretary";
                g_proc.sqlCommand.Parameters.AddWithValue("@p_secretary", secretary_id);
                g_proc.sqlCommand.CommandType = CommandType.StoredProcedure;

                List<int> doctorIds = new List<int>();

                using (var reader = g_proc.sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        doctorIds.Add(reader.GetInt32(reader.GetOrdinal("id")));
                    }
                }


                List<DataTable> allBillings = new List<DataTable>();  // Store all appointments

                foreach (int doctor_id in doctorIds)  // Loop through each doctor ID
                {
                    g_proc.sqlCommand.Parameters.Clear();
                    g_proc.sqlCommand.CommandText = "procGetPatientBillingsByDoctor";
                    g_proc.sqlCommand.Parameters.AddWithValue("@p_search", txtSearch.Text);
                    g_proc.sqlCommand.Parameters.AddWithValue("@p_filter", cboFilter.SelectedIndex);
                    g_proc.sqlCommand.Parameters.AddWithValue("@p_doctor_id", doctor_id);
                    g_proc.sqlCommand.Parameters.AddWithValue("@p_status", status.ToUpper());
                    g_proc.sqlCommand.CommandType = CommandType.StoredProcedure;

                    g_proc.sqlClinicAdapter.SelectCommand = g_proc.sqlCommand;
                    DataTable tempData = new DataTable();  // Temporary table for current doctor
                    g_proc.sqlClinicAdapter.Fill(tempData);  // Fill the temp table

                    allBillings.Add(tempData);  // Collect each doctor's appointments
                }


                //Merge all appointments into a single DataTable
                DataTable mergedData = fncMergeDataTables(allBillings);

                // Sort merged data by status (pending first) and then by ID
                DataTable sortedData = fncSortDataTable(mergedData);


                row = 0;
                grdBillings.RowCount = sortedData.Rows.Count;
                while (!(sortedData.Rows.Count - 1 < row))
                {
                    var billingRow = sortedData.Rows[row];

                    grdBillings.Rows[row].Cells[0].Value = billingRow["id"].ToString();
                    grdBillings.Rows[row].Cells[1].Value = billingRow["fullname"].ToString();
                    grdBillings.Rows[row].Cells[2].Value = billingRow["amount"].ToString();
                    grdBillings.Rows[row].Cells[3].Value = billingRow["amountpaid"].ToString();
                    grdBillings.Rows[row].Cells[4].Value = billingRow["doctor"].ToString();
                    grdBillings.Rows[row].Cells[5].Value = billingRow["status"].ToString();
                    row++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            g_proc.sqlClinicAdapter.Dispose();
            g_proc.datPatients.Dispose();
        }

        DataTable fncMergeDataTables(List<DataTable> tables)
        {
            DataTable mergedTable = new DataTable();

            if (tables.Count > 0)
            {
                mergedTable = tables[0].Clone();  // Copy schema from the first table

                foreach (DataTable table in tables)
                {
                    foreach (DataRow row in table.Rows)
                    {
                        mergedTable.ImportRow(row);  // Import each row
                    }
                }
            }

            return mergedTable;
        }

        // Function to sort the DataTable by 'status' (pending first) and 'id'
        DataTable fncSortDataTable(DataTable data)
        {
            DataView dataView = data.DefaultView;
            dataView.Sort = "status ASC, id ASC";  // Sort by status, then by ID
            return dataView.ToTable();
        }

        private void ResetButtons()
        {
            btnAll.FillColor = Color.White;
            btnAll.ForeColor = Color.FromArgb(64, 64, 64);
            btnAll.BorderColor = Color.FromArgb(233, 233, 233);

            btnPaid.FillColor = Color.White;
            btnPaid.ForeColor = Color.FromArgb(64, 64, 64);
            btnPaid.BorderColor = Color.FromArgb(233, 233, 233);

            btnUnpaid.FillColor = Color.White;
            btnUnpaid.ForeColor = Color.FromArgb(64, 64, 64);
            btnUnpaid.BorderColor = Color.FromArgb(233, 233, 233);
        }
        private void HighlightButton(Guna2Button buttonToHighlight)
        {
            buttonToHighlight.FillColor = Color.FromArgb(64, 64, 64);
            buttonToHighlight.ForeColor = Color.White;
            buttonToHighlight.BorderColor = Color.FromArgb(233, 233, 233);
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            ResetButtons();
            HighlightButton(btnAll);

            grdBillings.Columns["btnEdit"].Visible = true;
            grdBillings.Columns["btnPay"].Visible = false;
            status = "";
            func_LoadTable();
        }

        private void btnPaid_Click(object sender, EventArgs e)
        {
            ResetButtons();
            HighlightButton(btnPaid);
            grdBillings.Columns["btnEdit"].Visible = true;
            grdBillings.Columns["btnPay"].Visible = false;
            status = "paid";
            func_LoadTable();
        }

        private void btnUnpaid_Click(object sender, EventArgs e)
        {
            ResetButtons();
            HighlightButton(btnUnpaid);

            grdBillings.Columns["btnEdit"].Visible = true;
            grdBillings.Columns["btnPay"].Visible = true;
            status = "unpaid";
            func_LoadTable();
        }

        private void cboFilter_SelectedIndexChanged(object sender, EventArgs e)
        {

            func_LoadTable();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

            func_LoadTable();
        }

        private void func_ResolveBill(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == grdBillings.Columns["btnPay"].Index && e.RowIndex >= 0)
            {
                g_proc.displayFormAsModal(mainForm, new frmPaymentForm(mainForm, Int32.Parse(grdBillings.Rows[e.RowIndex].Cells["id"].Value.ToString())));
                func_LoadTable();
            }
            else if (e.ColumnIndex == grdBillings.Columns["btnEdit"].Index && e.RowIndex >= 0)
            {
                g_proc.displayFormAsModal(mainForm, new frmEditPayment(mainForm, Int32.Parse(grdBillings.Rows[e.RowIndex].Cells["id"].Value.ToString())));
                string fullName = grdBillings.Rows[e.RowIndex].Cells["fullname"].Value.ToString();
                func_LoadTable();
            }
        }

        private void func_ButtonStyleCell(object sender, DataGridViewCellPaintingEventArgs e)
        {
            // Approve Button
            if (e.ColumnIndex == grdBillings.Columns["btnPay"].Index && e.RowIndex >= 0)
            {
                if (e.State.HasFlag(DataGridViewElementStates.Selected))
                {
                    e.Handled = true;
                    using (Brush brush = new SolidBrush(Color.FromArgb(0, 55, 75)))
                    {
                        e.Graphics.FillRectangle(brush, e.CellBounds);
                    }

                    using (Pen pen = new Pen(Color.White, 2))
                    {
                        e.Graphics.DrawRectangle(pen, e.CellBounds);
                    }

                    TextRenderer.DrawText(e.Graphics, "Pay", e.CellStyle.Font, e.CellBounds, Color.White, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
                }
                else
                {
                    e.CellStyle.BackColor = Color.FromArgb(0, 55, 75);
                    e.CellStyle.ForeColor = Color.White;
                    e.CellStyle.Font = new Font("IBM Plex Sans", 12, FontStyle.Regular);
                    e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                    var textRect = new Rectangle(e.CellBounds.Left, e.CellBounds.Top,
                                                 e.CellBounds.Width, e.CellBounds.Height);

                    TextRenderer.DrawText(e.Graphics, "Pay", e.CellStyle.Font, textRect, e.CellStyle.ForeColor, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);

                    e.Handled = true;
                }
            }

            // Edit Button
            if (e.ColumnIndex == grdBillings.Columns["btnEdit"].Index && e.RowIndex >= 0)
            {
                if (e.State.HasFlag(DataGridViewElementStates.Selected))
                {
                    e.Handled = true;

                    using (Brush brush = new SolidBrush(Color.White))
                    {
                        e.Graphics.FillRectangle(brush, e.CellBounds);
                    }

                    Image editImage = Properties.Resources.icnColoredEdit;
                    var imgRect = new Rectangle(e.CellBounds.Left + (e.CellBounds.Width - editImage.Height / 2) / 2,
                                                e.CellBounds.Top + (e.CellBounds.Height - editImage.Width / 2) / 2,
                                                editImage.Width / 2, editImage.Height / 2);

                    e.Graphics.DrawImage(editImage, imgRect);
                }
                else
                {
                    e.CellStyle.BackColor = Color.White;
                    e.CellStyle.ForeColor = Color.FromArgb(0, 55, 75);
                    e.CellStyle.Font = new Font("IBM Plex Sans", 12, FontStyle.Regular);

                    e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                    Image editImage = Properties.Resources.icnColoredEdit;
                    var imgRect = new Rectangle(e.CellBounds.Left + (e.CellBounds.Width - editImage.Height / 2) / 2,
                                                e.CellBounds.Top + (e.CellBounds.Height - editImage.Width / 2) / 2,
                                                editImage.Width / 2, editImage.Height / 2);

                    e.Graphics.DrawImage(editImage, imgRect);
                    e.Handled = true;
                }
            }



        }
    }
}
