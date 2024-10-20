using ClinicSystem.Dashboard;
using ClinicSystem.Patient;
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

namespace ClinicSystem
{
    public partial class frmSecretaryDashboard : Form
    {
        private frmSecretaryMain mainForm;
        private GlobalProcedure g_proc = new GlobalProcedure();
        private int secretary_id;
        int row;
        public frmSecretaryDashboard(frmSecretaryMain mainForm, int secretary_id)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.secretary_id = secretary_id;
            g_proc.fncConnectToDatabase();


            grdAppointment.CellClick += func_ApproveAppointment;
            grdAppointment.CellPainting += func_ButtonStyleCell;
            func_LoadAppointments();
            func_LoadSecretary();
        }

        private void frmSecretaryDashboard_Load(object sender, EventArgs e)
        {

        }

        private void func_LoadAppointments()
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
                    g_proc.sqlCommand.Parameters.AddWithValue("@p_search", "");
                    g_proc.sqlCommand.Parameters.AddWithValue("@p_filter", 1);
                    g_proc.sqlCommand.Parameters.AddWithValue("@p_doctor_id", doctor_id);
                    g_proc.sqlCommand.Parameters.AddWithValue("@p_status", "pending");
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
                func_LoadAppointments();
                MessageBox.Show($"Appointment for {fullName} has been approved!");
            }
        }

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

                    TextRenderer.DrawText(e.Graphics, "Approve", e.CellStyle.Font,
                        e.CellBounds, Color.White,
                        TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
                }
                else
                {
                    e.CellStyle.BackColor = Color.FromArgb(0, 55, 75);
                    e.CellStyle.ForeColor = Color.White;
                    e.CellStyle.Font = new Font("IBM Plex Sans", 12, FontStyle.Regular);

                    e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                    var textRect = new Rectangle(e.CellBounds.Left, e.CellBounds.Top,
                                                 e.CellBounds.Width, e.CellBounds.Height);

                    TextRenderer.DrawText(e.Graphics, "Approve", e.CellStyle.Font,
                        textRect, e.CellStyle.ForeColor,
                        TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);

                    e.Handled = true;
                }
                func_LoadAppointments();
            }
        }

        public void LoadFormIntoPanel(Form form)
        {
            this.grdAppointment.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            this.grdAppointment.Controls.Add(form);
            form.Show();
        }

        private void func_LoadSecretary()
        {
            try
            {
                g_proc.sqlClinicAdapter = new MySqlDataAdapter();
                g_proc.datPatients = new DataTable();

                int patientCount = 0;
                int appointmentCount = 0;
                int paymentCount = 0;

                // get doctors handled by secretary
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

                foreach (int doctor_id in doctorIds)  // Loop through each doctor ID
                {
                    // get patient count
                    g_proc.sqlCommand.Parameters.Clear();
                    g_proc.sqlCommand.CommandText = "procGetDataAnalytic";

                    g_proc.sqlCommand.Parameters.AddWithValue("@p_doctor_id", doctor_id);

                    g_proc.sqlCommand.CommandType = CommandType.StoredProcedure;
                    g_proc.sqlClinicAdapter.SelectCommand = g_proc.sqlCommand;
                    g_proc.datPatients.Clear();
                    g_proc.sqlClinicAdapter.Fill(g_proc.datPatients);

                    if (g_proc.datPatients.Rows.Count > 0)
                    {
                        DataRow row = g_proc.datPatients.Rows[0];
                        patientCount += Convert.ToInt32(row["PatientCount"]);
                        appointmentCount += Convert.ToInt32(row["AppointmentCount"]);
                        paymentCount += Convert.ToInt32(row["PaymentCount"]);
                    }
                }

                lblPatientCount.Text = patientCount.ToString();
                lblAppointmentCount.Text = appointmentCount.ToString();
                lblEarningsCount.Text = paymentCount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            g_proc.sqlClinicAdapter.Dispose();
            g_proc.datPatients.Dispose();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //this.mainForm.NavigateToForm(new frmPatientAdd(mainForm, doctor_id));
            this.Close();
        }


        private void pnlAppointmentTable_Click(object sender, EventArgs e)
        {

        }
    }
}
