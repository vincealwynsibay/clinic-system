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

namespace ClinicSystem.DoctorMain
{
    public partial class frmPatients : Form
    {
        GlobalProcedure g_proc = new GlobalProcedure();
        private frmDoctorMain mainForm;
        private int doctor_id;
        private int row;

        public frmPatients(frmDoctorMain mainForm, int doctor_id)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.doctor_id = doctor_id;
            g_proc.fncConnectToDatabase();
            func_Search("");     // displays customer
        }

        private void func_Search(string v_search)
        {
            try
            {
                g_proc.sqlClinicAdapter = new MySqlDataAdapter();
                g_proc.datPatients = new DataTable();

                g_proc.sqlCommand.Parameters.Clear();
                g_proc.sqlCommand.CommandText = "procSearchPatientName";

                g_proc.sqlCommand.Parameters.AddWithValue("@p_search", v_search);
                g_proc.sqlCommand.Parameters.AddWithValue("@p_filter", cboFilter.SelectedIndex);    // use index to know what filter to do (0 - none, 1 today, 2 this week, 3 this month, 4 this year)
                g_proc.sqlCommand.Parameters.AddWithValue("@p_doctor_id", doctor_id);               // checks the tbldiagnosis if patient and doctor is related

                g_proc.sqlCommand.CommandType = CommandType.StoredProcedure;
                g_proc.sqlClinicAdapter.SelectCommand = g_proc.sqlCommand;
                g_proc.datPatients.Clear();
                g_proc.sqlClinicAdapter.Fill(g_proc.datPatients);
                if (g_proc.datPatients.Rows.Count > 0)
                {
                    row = 0;
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
                        row++;
                    }
                    grdPatients.CellClick -= func_ApproveAppointment;

                    grdPatients.CellPainting += func_ButtonStyleCell;
                    grdPatients.CellClick += func_ApproveAppointment;
                }
                else
                {
                    grdPatients.RowCount = 0;
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
            func_Search(txtSearch.Text);
        }

        private void cboFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            func_Search(txtSearch.Text);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            g_proc.displayFormAsModal(mainForm, new frmPatientAdd(mainForm, doctor_id));
        }

        private void grdPatients_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.mainForm.NavigateToForm(new frmPatientDetail(mainForm, doctor_id, Convert.ToInt32(grdPatients.CurrentRow.Cells[0].Value)));
            this.Close();
        }

        // Event Handler for Datagrid Buttons
        private void func_ApproveAppointment(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == grdPatients.Columns["btnEdit"].Index && e.RowIndex >= 0)
            {
                g_proc.displayFormAsModal(mainForm, new frmPatientEdit(mainForm, doctor_id, Convert.ToInt32(grdPatients.CurrentRow.Cells[0].Value)));
            }
            else if (e.ColumnIndex == grdPatients.Columns["btnDelete"].Index && e.RowIndex >= 0)
            {
                string fullName = grdPatients.Rows[e.RowIndex].Cells["fullname"].Value.ToString();
                MessageBox.Show($"Appointment for {fullName} deleted!");
            }
        }

        // Create Buttons inside the datagrid
        private void func_ButtonStyleCell(object sender, DataGridViewCellPaintingEventArgs e)
        {
            // Edit Button
            if (e.ColumnIndex == grdPatients.Columns["btnEdit"].Index && e.RowIndex >= 0)
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
            if (e.ColumnIndex == grdPatients.Columns["btnDelete"].Index && e.RowIndex >= 0)
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
