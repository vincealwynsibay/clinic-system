﻿using ClinicSystem.CrystalReport;
using ClinicSystem.Prescription;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace ClinicSystem
{
    public partial class frmPrescription : Form
    {
        GlobalProcedure g_proc = new GlobalProcedure();

        private frmDoctorMain mainForm;
        private int doctor_id;
        private int patient_id;
        private int prescription_id;

        private int row;
        public frmPrescription(frmDoctorMain mainForm, int doctor_id, int patient_id, int prescription_id)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.doctor_id = doctor_id;
            this.patient_id = patient_id;
            this.prescription_id = prescription_id;
            g_proc.fncConnectToDatabase();

            func_LoadPrescription();
        }

        private void func_LoadPrescription()
        {
            try
            {
                g_proc.sqlClinicAdapter = new MySqlDataAdapter();
                g_proc.datPrescription = new DataTable();

                g_proc.sqlCommand.Parameters.Clear();
                g_proc.sqlCommand.CommandText = "procGetPrescriptionDetail";

                g_proc.sqlCommand.Parameters.AddWithValue("@p_prescription_id", prescription_id);

                g_proc.sqlCommand.CommandType = CommandType.StoredProcedure;
                g_proc.sqlClinicAdapter.SelectCommand = g_proc.sqlCommand;
                g_proc.datPrescription.Clear();
                g_proc.sqlClinicAdapter.Fill(g_proc.datPrescription);

                if (g_proc.datPrescription.Rows.Count > 0)
                {
                    row = 0;
                    grdPrescription.RowCount = g_proc.datPrescription.Rows.Count;
                    while (!(g_proc.datPrescription.Rows.Count - 1 < row))
                    {
                        var patientRow = g_proc.datPrescription.Rows[row];

                        grdPrescription.Rows[row].Cells[0].Value = patientRow["quantity"].ToString();
                        grdPrescription.Rows[row].Cells[1].Value = patientRow["medicine"].ToString();
                        grdPrescription.Rows[row].Cells[2].Value = patientRow["dosage"].ToString();
                        grdPrescription.Rows[row].Cells[3].Value = patientRow["frequency"].ToString();
                        grdPrescription.Rows[row].Cells[4].Value = patientRow["comment"].ToString();
                        grdPrescription.Rows[row].Cells[7].Value = patientRow["id"].ToString();
                        row++;
                        grdPrescription.CellClick -= func_TableButtonEventHandler;

                        grdPrescription.CellPainting += func_ButtonStyleCell;
                        grdPrescription.CellClick += func_TableButtonEventHandler;
                    }
                }
                else
                {
                    grdPrescription.RowCount = 0;
                }
                g_proc.sqlClinicAdapter.Dispose();
                g_proc.datPrescription.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            g_proc.displayFormAsModal(mainForm, new frmPrescriptionAdd(mainForm, doctor_id, patient_id, prescription_id));
            func_LoadPrescription();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.mainForm.NavigateToForm(new frmPatientDetail(mainForm, doctor_id, patient_id));
            this.Close();
        }

        // Event Handler for Datagrid Buttons
        private void func_TableButtonEventHandler(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == grdPrescription.Columns["btnEdit"].Index && e.RowIndex >= 0)
            {
                g_proc.displayFormAsModal(mainForm, new frmPrescriptionModify(mainForm, doctor_id, patient_id, prescription_id, Convert.ToInt32(grdPrescription.CurrentRow.Cells[7].Value)));
                func_LoadPrescription();
            }
            else if (e.ColumnIndex == grdPrescription.Columns["btnDelete"].Index && e.RowIndex >= 0)
            {
                DialogResult result = MessageBox.Show(
                    "Are you sure you want to delete this row?",
                    "Confirm Deletion",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.No) { return; }

                try
                {
                    g_proc.sqlCommand.Parameters.Clear();
                    g_proc.sqlCommand.CommandText = "procDeletePrescriptionItem";
                    g_proc.sqlCommand.CommandType = CommandType.StoredProcedure;
                    g_proc.sqlCommand.Parameters.AddWithValue("@p_id", Convert.ToInt32(grdPrescription.CurrentRow.Cells[7].Value.ToString()));
                    g_proc.sqlCommand.ExecuteNonQuery();
                    func_LoadPrescription();

                    MessageBox.Show("Record deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Create Buttons inside the datagrid
        private void func_ButtonStyleCell(object sender, DataGridViewCellPaintingEventArgs e)
        {
            // Edit Button
            if (e.ColumnIndex == grdPrescription.Columns["btnEdit"].Index && e.RowIndex >= 0)
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
            if (e.ColumnIndex == grdPrescription.Columns["btnDelete"].Index && e.RowIndex >= 0)
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

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            g_proc.datPrescription = new DataTable();
            g_proc.datGetDoctor = new DataTable();

            g_proc.datPrescription.Columns.Add("Qty.", typeof(string));
            g_proc.datPrescription.Columns.Add("Medicine", typeof(string));
            g_proc.datPrescription.Columns.Add("Dosage", typeof(string));
            g_proc.datPrescription.Columns.Add("Frequency", typeof(string));
            g_proc.datPrescription.Columns.Add("Comment", typeof(string));
            g_proc.datPrescription.Columns.Add("Name", typeof(string));


            g_proc.datGetDoctor.Columns.Add("firstname", typeof(String));
            g_proc.datGetDoctor.Columns.Add("middlename", typeof(String));
            g_proc.datGetDoctor.Columns.Add("lastname", typeof(String));


            g_proc.sqlCommand.Parameters.Clear();
            g_proc.sqlCommand.CommandType = CommandType.StoredProcedure;
            g_proc.sqlCommand.CommandText = "procGetDoctorById";
            g_proc.sqlCommand.Parameters.AddWithValue(@"p_doctorId", this.doctor_id);
            g_proc.reader = g_proc.sqlCommand.ExecuteReader();


            if (g_proc.reader.Read())
            {
                g_proc.datGetDoctor.Rows.Add(g_proc.reader["firstname"].ToString(),
                                             g_proc.reader["middlename"].ToString(),
                                             g_proc.reader["lastname"].ToString());
            }
            else
            {
                g_proc.reader.Close();
            }
            String[] Fullname =
                {
                  g_proc.datGetDoctor.Rows[0]["firstname"].ToString(),
                  g_proc.datGetDoctor.Rows[0]["middlename"].ToString(),
                  g_proc.datGetDoctor.Rows[0]["lastname"].ToString()
                };

            for (int i = 0; i < grdPrescription.Rows.Count; i++)
            {

                g_proc.datPrescription.Rows.Add(grdPrescription.Rows[i].Cells[0].Value,
                                                grdPrescription.Rows[i].Cells[1].Value,
                                                grdPrescription.Rows[i].Cells[2].Value,
                                                grdPrescription.Rows[i].Cells[3].Value,
                                                grdPrescription.Rows[i].Cells[4].Value,
                                                String.Concat("Dr. ", String.Join(" ", Fullname)));
            }
            ds.Tables.Add(g_proc.datPrescription);
            ds.Tables.Add(g_proc.datGetDoctor);
            ds.WriteXmlSchema("ReceiptPrescription.xml");

            frmReceiptPrescription receiptPrescription = new frmReceiptPrescription();

            csrReceiptPrescription report = new csrReceiptPrescription();
            report.SetDataSource(ds);

            receiptPrescription.csrReceiptPrescriptionView.ReportSource = report;
            receiptPrescription.csrReceiptPrescriptionView.Refresh();
            receiptPrescription.ShowDialog();
            g_proc.reader.Close();
        }
    }
}
