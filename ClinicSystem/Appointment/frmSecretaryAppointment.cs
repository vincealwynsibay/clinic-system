using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace ClinicSystem.Appointment
{
    public partial class frmSecretaryAppointment : Form
    {

        GlobalProcedure g_proc = new GlobalProcedure();
        private frmSecretaryMain mainForm;
        private int secretary_id;
        private int row;
        private string status = "pending";

        public frmSecretaryAppointment(frmSecretaryMain mainForm, int secretary_id)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.secretary_id = secretary_id;
            g_proc.fncConnectToDatabase();

            func_LoadTable();
            HighlightButton(btnPending);
            btnPending_Click(null, null);
        }

        private void func_LoadTable()
        {
            grdAppointment.CellClick -= func_ApproveAppointment;
            grdAppointment.CellPainting += func_ButtonStyleCell;
            grdAppointment.CellClick += func_ApproveAppointment;

            func_LoadDataFromDB();
        }

        private void func_LoadDataFromDB()
        {
            try
            {
                g_proc.sqlClinicAdapter = new MySqlDataAdapter();
                g_proc.datPatients = new DataTable();


                // get all doctors handled by secretary
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


                List<DataTable> allAppointments = new List<DataTable>();  // Store all appointments

                foreach (int doctor_id in doctorIds)  // Loop through each doctor ID
                {
                    g_proc.sqlCommand.Parameters.Clear();
                    g_proc.sqlCommand.CommandText = "procSearchAppointment2";
                    g_proc.sqlCommand.Parameters.AddWithValue("@p_search", txtSearch.Text);
                    g_proc.sqlCommand.Parameters.AddWithValue("@p_filter", cboFilter.SelectedIndex);
                    g_proc.sqlCommand.Parameters.AddWithValue("@p_doctor_id", doctor_id);
                    g_proc.sqlCommand.Parameters.AddWithValue("@p_status", status.ToUpper());
                    g_proc.sqlCommand.CommandType = CommandType.StoredProcedure;

                    g_proc.sqlClinicAdapter.SelectCommand = g_proc.sqlCommand;
                    DataTable tempData = new DataTable();  // Temporary table for current doctor
                    g_proc.sqlClinicAdapter.Fill(tempData);  // Fill the temp table

                    allAppointments.Add(tempData);  // Collect each doctor's appointments
                }


                // Merge all appointments into a single DataTable
                DataTable mergedData = fncMergeDataTables(allAppointments);

                // Sort merged data by status (pending first) and then by ID
                DataTable sortedData = fncSortDataTable(mergedData);


                row = 0;
                grdAppointment.RowCount = sortedData.Rows.Count;
                while (!(sortedData.Rows.Count - 1 < row))
                {
                    var patientRow = sortedData.Rows[row];

                    grdAppointment.Rows[row].Cells[0].Value = patientRow["id"].ToString();
                    grdAppointment.Rows[row].Cells[1].Value = patientRow["name"].ToString();
                    grdAppointment.Rows[row].Cells[2].Value = patientRow["mobileno"].ToString();
                    grdAppointment.Rows[row].Cells[3].Value = patientRow["email"].ToString();
                    grdAppointment.Rows[row].Cells[4].Value = patientRow["fullname"].ToString();
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

        // Event Handler for Datagrid Buttons
        private void func_ApproveAppointment(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == grdAppointment.Columns["btnApprove"].Index && e.RowIndex >= 0)
            {
                g_proc.sqlCommand.Parameters.Clear();
                g_proc.sqlCommand.CommandText = "procApproveAppointment";
                g_proc.sqlCommand.CommandType = CommandType.StoredProcedure;

                g_proc.sqlCommand.Parameters.AddWithValue("@p_id", grdAppointment.Rows[e.RowIndex].Cells["id"].Value);

                g_proc.sqlCommand.ExecuteNonQuery();
                g_proc.sqlClinicAdapter.Dispose();
                g_proc.datPatients.Dispose();

                string fullName = grdAppointment.Rows[e.RowIndex].Cells["fullname"].Value.ToString();
                func_LoadTable();
            }
            else if (e.ColumnIndex == grdAppointment.Columns["btnEdit"].Index && e.RowIndex >= 0)
            {
                string fullName = grdAppointment.Rows[e.RowIndex].Cells["fullname"].Value.ToString();
                MessageBox.Show($"Appointment for {fullName} edited!");
            }
            else if (e.ColumnIndex == grdAppointment.Columns["btnDelete"].Index && e.RowIndex >= 0)
            {
                string fullName = grdAppointment.Rows[e.RowIndex].Cells["fullname"].Value.ToString();
                MessageBox.Show($"Appointment for {fullName} deleted!");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            g_proc.displayFormAsModal(mainForm, new frmAddAppointment(mainForm, secretary_id));
            func_LoadDataFromDB();
        }

        private void ResetButtons()
        {
            btnPending.FillColor = Color.White;
            btnPending.ForeColor = Color.FromArgb(64, 64, 64);
            btnPending.BorderColor = Color.FromArgb(233, 233, 233);

            btnCancelled.FillColor = Color.White;
            btnCancelled.ForeColor = Color.FromArgb(64, 64, 64);
            btnCancelled.BorderColor = Color.FromArgb(233, 233, 233);

            btnFilterApprove.FillColor = Color.White;
            btnFilterApprove.ForeColor = Color.FromArgb(64, 64, 64);
            btnFilterApprove.BorderColor = Color.FromArgb(233, 233, 233);
        }

        private void HighlightButton(Guna2Button buttonToHighlight)
        {
            buttonToHighlight.FillColor = Color.FromArgb(64, 64, 64);
            buttonToHighlight.ForeColor = Color.White;
            buttonToHighlight.BorderColor = Color.FromArgb(233, 233, 233);
        }

        private void btnPending_Click(object sender, EventArgs e)
        {
            ResetButtons();
            HighlightButton(btnPending);
            grdAppointment.Columns["btnEdit"].Visible = true;
            grdAppointment.Columns["btnDelete"].Visible = true;
            grdAppointment.Columns["btnApprove"].Visible = true;
            status = "pending";
            func_LoadTable();
        }

        private void btnCancelled_Click(object sender, EventArgs e)
        {
            ResetButtons();
            HighlightButton(btnCancelled);
            grdAppointment.Columns["btnEdit"].Visible = false;
            grdAppointment.Columns["btnDelete"].Visible = false;
            grdAppointment.Columns["btnApprove"].Visible = false;
            status = "cancelled";
            func_LoadTable();
        }

        private void btnFilterApprove_Click(object sender, EventArgs e)
        {
            ResetButtons();
            HighlightButton(btnFilterApprove);
            grdAppointment.Columns["btnEdit"].Visible = false;
            grdAppointment.Columns["btnDelete"].Visible = false;
            status = "approved";
            func_LoadTable();
        }

        private void cboFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(cboFilter.SelectedIndex.ToString());
            func_LoadTable();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            func_LoadTable();
        }

        // Create Buttons inside the datagrid
        private void func_ButtonStyleCell(object sender, DataGridViewCellPaintingEventArgs e)
        {
            // Approve Button
            if (e.ColumnIndex == grdAppointment.Columns["btnApprove"].Index && e.RowIndex >= 0)
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

                    TextRenderer.DrawText(e.Graphics, "Approve", e.CellStyle.Font, e.CellBounds, Color.White, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
                }
                else
                {
                    e.CellStyle.BackColor = Color.FromArgb(0, 55, 75);
                    e.CellStyle.ForeColor = Color.White;
                    e.CellStyle.Font = new Font("IBM Plex Sans", 12, FontStyle.Regular);
                    e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                    var textRect = new Rectangle(e.CellBounds.Left, e.CellBounds.Top,
                                                 e.CellBounds.Width, e.CellBounds.Height);

                    TextRenderer.DrawText(e.Graphics, "Approve", e.CellStyle.Font, textRect, e.CellStyle.ForeColor, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);

                    e.Handled = true;
                }
            }

            // Edit Button
            if (e.ColumnIndex == grdAppointment.Columns["btnEdit"].Index && e.RowIndex >= 0)
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

            // Delete Button
            if (e.ColumnIndex == grdAppointment.Columns["btnDelete"].Index && e.RowIndex >= 0)
            {
                if (e.State.HasFlag(DataGridViewElementStates.Selected))
                {
                    e.Handled = true;

                    using (Brush brush = new SolidBrush(Color.White))
                    {
                        e.Graphics.FillRectangle(brush, e.CellBounds);
                    }

                    Image deleteImage = Properties.Resources.icnColoredDelete;
                    var imgRect = new Rectangle(e.CellBounds.Left + (e.CellBounds.Width - deleteImage.Height / 2) / 2,
                                                e.CellBounds.Top + (e.CellBounds.Height - deleteImage.Width / 2) / 2,
                                                deleteImage.Width / 2, deleteImage.Height / 2);

                    e.Graphics.DrawImage(deleteImage, imgRect);
                }
                else
                {
                    e.CellStyle.BackColor = Color.White;
                    e.CellStyle.ForeColor = Color.FromArgb(0, 55, 75);
                    e.CellStyle.Font = new Font("IBM Plex Sans", 12, FontStyle.Regular);

                    e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                    Image deleteImage = Properties.Resources.icnColoredDelete;
                    var imgRect = new Rectangle(e.CellBounds.Left + (e.CellBounds.Width - deleteImage.Height / 2) / 2,
                                                e.CellBounds.Top + (e.CellBounds.Height - deleteImage.Width / 2) / 2,
                                                deleteImage.Width / 2, deleteImage.Height / 2);

                    e.Graphics.DrawImage(deleteImage, imgRect);
                    e.Handled = true;
                }
            }

        }

        private void frmSecretaryAppointment_Load(object sender, EventArgs e)
        {

        }
    }
}
