using ClinicSystem.Appointment;
using ClinicSystem.Patient;
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

namespace ClinicSystem.DoctorAppointment
{
    public partial class frmDoctorAppointment : Form
    {
        GlobalProcedure g_proc = new GlobalProcedure();
        private frmDoctorMain mainForm;
        private int doctor_id;
        private int row;
        private string status = "pending";

        public frmDoctorAppointment(frmDoctorMain mainForm, int doctor_id)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.doctor_id = doctor_id;
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

                g_proc.sqlCommand.Parameters.Clear();
                g_proc.sqlCommand.CommandText = "procSearchAppointment";

                g_proc.sqlCommand.Parameters.AddWithValue("@p_search", txtSearch.Text);
                g_proc.sqlCommand.Parameters.AddWithValue("@p_filter", cboFilter.SelectedIndex);    // use index to know what filter to do (0 - none, 1 today, 2 this week, 3 this month, 4 this year)
                g_proc.sqlCommand.Parameters.AddWithValue("@p_doctor_id", doctor_id);               // checks the tbldiagnosis if patient and doctor is related
                g_proc.sqlCommand.Parameters.AddWithValue("@p_status", status.ToUpper());

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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            g_proc.sqlClinicAdapter.Dispose();
            g_proc.datPatients.Dispose();
        }

        private void func_ChangeAppointmentStatus(DataGridViewCellEventArgs e, string v_proc, string v_message)
        {
            g_proc.sqlCommand.Parameters.Clear();
            g_proc.sqlCommand.CommandText = v_proc;
            g_proc.sqlCommand.CommandType = CommandType.StoredProcedure;

            g_proc.sqlCommand.Parameters.AddWithValue("@p_id", grdAppointment.Rows[e.RowIndex].Cells["id"].Value);

            g_proc.sqlCommand.ExecuteNonQuery();
            g_proc.sqlClinicAdapter.Dispose();
            g_proc.datPatients.Dispose();

            string fullName = grdAppointment.Rows[e.RowIndex].Cells["fullname"].Value.ToString();
            func_LoadTable();
            MessageBox.Show($"Appointment for {fullName} " + v_message);
        }
        // Event Handler for Datagrid Buttons
        private void func_ApproveAppointment(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == grdAppointment.Columns["btnApprove"].Index && e.RowIndex >= 0)
            {
                func_ChangeAppointmentStatus(e, "procApproveAppointment", "approved!");
            }
            else if (e.ColumnIndex == grdAppointment.Columns["btnEdit"].Index && e.RowIndex >= 0)
            {
                //func_ChangeAppointmentStatus(e, "procApproveAppointment", "edited!");
                g_proc.displayFormAsModal(mainForm, new frmEditAppointment(Convert.ToInt32(grdAppointment.Rows[e.RowIndex].Cells["id"].Value.ToString())));
            }
            else if (e.ColumnIndex == grdAppointment.Columns["btnDelete"].Index && e.RowIndex >= 0)
            {
                DialogResult dialogConfirmDelete = MessageBox.Show("Are you sure you want to cancel this appointment permanently?",
                                                        "Confirm Cancellation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogConfirmDelete == DialogResult.No) { return; }
                func_ChangeAppointmentStatus(e, "procCancelAppointment", "cancelled!");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            g_proc.displayFormAsModal(mainForm, new frmPatientAdd(mainForm, doctor_id));
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
            grdAppointment.Columns["btnDelete"].Visible = true;
            grdAppointment.Columns["btnApprove"].Visible = false;
            status = "approved";
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
                    var imgRect = new Rectangle(e.CellBounds.Left + (e.CellBounds.Width - editImage.Height/2) / 2,
                                                e.CellBounds.Top + (e.CellBounds.Height - editImage.Width/2) / 2,
                                                editImage.Width/2, editImage.Height/2);

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
    }
}
