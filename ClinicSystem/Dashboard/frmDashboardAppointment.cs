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

namespace ClinicSystem.Dashboard
{
    public partial class frmDashboardAppointment : Form
    {
        GlobalProcedure g_proc = new GlobalProcedure();
        private frmDoctorMain mainForm;
        private int doctor_id;
        private int row;

        public frmDashboardAppointment(frmDoctorMain mainForm, int doctor_id)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.doctor_id = doctor_id;
            g_proc.fncConnectToDatabase();

            func_LoadDoctor();
        }

        private void func_LoadDoctor()
        {
            try
            {
                g_proc.sqlClinicAdapter = new MySqlDataAdapter();
                g_proc.datPatients = new DataTable();

                g_proc.sqlCommand.Parameters.Clear();
                g_proc.sqlCommand.CommandText = "procSearchAppointment";

                g_proc.sqlCommand.Parameters.AddWithValue("@p_search", "");
                g_proc.sqlCommand.Parameters.AddWithValue("@p_filter", 1);    // use index to know what filter to do (0 - none, 1 today, 2 this week, 3 this month, 4 this year)
                g_proc.sqlCommand.Parameters.AddWithValue("@p_doctor_id", doctor_id);               // checks the tbldiagnosis if patient and doctor is related
                g_proc.sqlCommand.Parameters.AddWithValue("@p_status", "PENDING");

                g_proc.sqlCommand.CommandType = CommandType.StoredProcedure;
                g_proc.sqlClinicAdapter.SelectCommand = g_proc.sqlCommand;
                g_proc.datPatients.Clear();
                g_proc.sqlClinicAdapter.Fill(g_proc.datPatients);
                row = 0;
                grdAppointment.RowCount = g_proc.datPatients.Rows.Count;
                while (!(g_proc.datPatients.Rows.Count - 1 < row))
                {
                    var patientRow = g_proc.datPatients.Rows[row];

                    grdAppointment.Rows[row].Cells[0].Value = patientRow["id"].ToString();
                    grdAppointment.Rows[row].Cells[1].Value = patientRow["name"].ToString();
                    grdAppointment.Rows[row].Cells[2].Value = patientRow["mobileno"].ToString();
                    grdAppointment.Rows[row].Cells[3].Value = patientRow["email"].ToString();
                    row++;
                }

                grdAppointment.CellClick += func_ApproveAppointment;
                grdAppointment.CellPainting += func_ButtonStyleCell;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            g_proc.sqlClinicAdapter.Dispose();
            g_proc.datPatients.Dispose();
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
                func_LoadDoctor();
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
            }
        }
    }
}
