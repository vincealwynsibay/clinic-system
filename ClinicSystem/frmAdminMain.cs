using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicSystem
{
    public partial class frmAdminMain : Form
    {
        GlobalProcedure g_proc = new GlobalProcedure();
        private int index;
        public frmAdminMain(int index)
        {
            InitializeComponent();
            this.index = index;

            g_proc.fncConnectToDatabase();
            loadAdmin();
        }

        private void loadAdmin()
        {
            try
            {
                g_proc.checkDatabaseConnection();

                MySqlCommand sqlCmd = g_proc.sqlCommand;
                g_proc.sqlCommand.Parameters.Clear();
                g_proc.sqlCommand.CommandText = "procGetUserByID";
                g_proc.sqlCommand.Parameters.AddWithValue("@p_id", index);

                g_proc.sqlCommand.CommandType = CommandType.StoredProcedure;


                using (var reader = sqlCmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        txtName.Text = reader.GetString(reader.GetOrdinal("username"));
                        var photo = reader.GetString(reader.GetOrdinal("username"));
                        if (photo.ToString() != "")
                        {
                            picProfile.Image = new Bitmap(photo.ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void frmAdminMain_Load(object sender, EventArgs e)
        {
            btnDashboard.PerformClick();

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            LoadFormIntoPanel(new frmAdminDashboard(this));
        }


        private void btnUsers_Click(object sender, EventArgs e)
        {
            LoadFormIntoPanel(new frmUsers(this));
        }

        private void btnDoctors_Click(object sender, EventArgs e)
        {
            LoadFormIntoPanel(new frmDoctors(this));
        }
        private void btnSecretaries_Click(object sender, EventArgs e)
        {
            LoadFormIntoPanel(new frmSecretaries(this));
        }

        public void LoadFormIntoPanel(Form form)
        {
            this.pnlMain.Controls.Clear();

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            //form.Dock = DockStyle.Fill;
            //form.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            form.StartPosition = FormStartPosition.CenterParent;

            this.pnlMain.Controls.Add(form);
            form.Show();
        }

        public void NavigateToForm(Form childForm)
        {
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            LoadFormIntoPanel(childForm);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
            this.Hide();
        }

        private void bunifuPanel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuGroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtName_Click(object sender, EventArgs e)
        {

        }

        private void pnlMain_Click(object sender, EventArgs e)
        {

        }

        private void pnlMainParent_Click(object sender, EventArgs e)
        {

        }
    }
}
