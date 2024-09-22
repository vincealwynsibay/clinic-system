using Bunifu.UI.WinForms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace ClinicSystem
{
    public partial class frmUsers : Form
    {
        private frmAdminMain mainForm;
        private GlobalProcedure globalProcedure = new GlobalProcedure();
        DataTable datDoctors = new DataTable();
        DataTable datSecretary = new DataTable();
        public frmUsers(frmAdminMain mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void frmUsers_Load(object sender, EventArgs e)
        {
            this.globalProcedure.checkDatabaseConnection();

            try
            {
                DataTable datRole = new DataTable();

                globalProcedure.sqlCommand.Parameters.Clear();
                globalProcedure.sqlCommand.CommandText = "procGetAllRoles";
                globalProcedure.sqlCommand.CommandType = CommandType.StoredProcedure;
                datRole.Load(globalProcedure.sqlCommand.ExecuteReader());

                cmbRole.DataSource = datRole;
                cmbRole.ValueMember = "id";
                cmbRole.DisplayMember = "name";

                globalProcedure.sqlCommand.Parameters.Clear();
                globalProcedure.sqlCommand.CommandText = "procGetAllDoctorsByFullname";
                globalProcedure.sqlCommand.CommandType = CommandType.StoredProcedure;
                globalProcedure.sqlCommand.Parameters.AddWithValue("@p_fullname", "");
                datDoctors.Load(globalProcedure.sqlCommand.ExecuteReader());
                datDoctors.CaseSensitive = false;

                globalProcedure.sqlCommand.Parameters.Clear();
                globalProcedure.sqlCommand.CommandText = "procGetAllSecretaryByFullname";
                globalProcedure.sqlCommand.CommandType = CommandType.StoredProcedure;
                globalProcedure.sqlCommand.Parameters.AddWithValue("@p_fullname", "");
                datSecretary.Load(globalProcedure.sqlCommand.ExecuteReader());
                datSecretary.CaseSensitive = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbRole.Text.ToString() == "ADMIN")
            {
                //cmbFullname.Enabled = false;
            }
            else if (cmbRole.Text.ToString() == "DOCTOR")
            {
                //cmbFullname.Enabled = true;
                //cmbFullname.ValueMember = datDoctors.Columns["id"].ColumnName;
                //cmbFullname.DisplayMember = datDoctors.Columns["fullname"].ColumnName;
                //cmbFullname.DataSource = datDoctors;

            }
            else if (cmbRole.Text.ToString() == "SECRETARY")
            {
                //cmbFullname.Enabled = true;
                //cmbFullname.ValueMember = "id";
                //cmbFullname.DisplayMember = "fullname";
                //cmbFullname.DataSource = datSecretary;
            }
        }

      
    }
}
