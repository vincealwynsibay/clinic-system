using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ClinicSystem
{
    public partial class frmAdminDashboard : Form
    {
        GlobalProcedure globalProcedures = new GlobalProcedure();
        private frmAdminMain mainForm;
        public frmAdminDashboard(frmAdminMain mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }
        // Call the stored procedure to get monthly profits.
        private void GetMonthlyProfits()
        {
            try
            {
                // Initialize adapter and DataTable
                globalProcedures.sqlClinicAdapter = new MySqlDataAdapter();
                globalProcedures.datPatients = new DataTable();

                // Clear previous parameters and set up the command
                globalProcedures.sqlCommand.Parameters.Clear();
                globalProcedures.sqlCommand.CommandText = "procGetMonthlyProfits";
                globalProcedures.sqlCommand.CommandType = CommandType.StoredProcedure;

                // Execute the stored procedure and fill the DataTable with the result
                globalProcedures.sqlClinicAdapter.SelectCommand = globalProcedures.sqlCommand;
                globalProcedures.datPatients.Clear();
                globalProcedures.sqlClinicAdapter.Fill(globalProcedures.datPatients);

                // Bind the data to the chart
                var monthNames = new List<string>
                {
                    "January", "February", "March", "April",
                    "May", "June", "July", "August",
                    "September", "October", "November", "December"
                };

                chartMonthlyProfits.Series.Clear();
                chartMonthlyProfits.Titles.Add("Monthly Profits");

                Series series = new Series
                {
                    Name = "Profits",
                    XValueType = ChartValueType.String,
                    YValueType = ChartValueType.Double,
                    ChartType = SeriesChartType.Column
                };
                chartMonthlyProfits.Series.Add(series);

                var profitDict = monthNames.ToDictionary(m => m, m => 0.0);

                // Populate the dictionary with actual data from the DataTable
                foreach (DataRow row in globalProcedures.datPatients.Rows)
                {
                    // Convert the month from YYYY-MM format to just the month name
                    string month = DateTime.ParseExact(row["Month"].ToString(), "yyyy-MM", null).ToString("MMMM");
                    double profit = Convert.ToDouble(row["TotalProfit"]);
                    profitDict[month] = profit; // Update the dictionary with the actual profit
                }

                // Add all months to the chart
                foreach (var month in monthNames)
                {
                    double profit = profitDict[month]; // Get the profit for the month (0.0 if no data)
                    series.Points.AddXY(month, profit); // Add to the chart
                }

                // Set chart axis titles
                chartMonthlyProfits.ChartAreas[0].AxisX.Title = "Month";
                chartMonthlyProfits.ChartAreas[0].AxisY.Title = "Total Profit (AmountPaid)";
                chartMonthlyProfits.ChartAreas[0].AxisX.Interval = 1; // Set the interval to 1
                chartMonthlyProfits.ChartAreas[0].AxisX.LabelStyle.IsEndLabelVisible = true;
            }
            catch (Exception ex)
            {
                // Display error message if something goes wrong
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                // Dispose of resources to free memory
                globalProcedures.sqlClinicAdapter.Dispose();
                globalProcedures.datPatients.Dispose();
            }

        }

        // Display the profits data in the chart.
        private void DisplayChart(DataTable data)
        {
            chartMonthlyProfits.Series.Clear();
            chartMonthlyProfits.Titles.Add("Monthly Profits");

            Series series = new Series
            {
                Name = "Profits",
                XValueType = ChartValueType.String,
                YValueType = ChartValueType.Double,
                ChartType = SeriesChartType.Column
            };

            chartMonthlyProfits.Series.Add(series);

            foreach (DataRow row in data.Rows)
            {
                string month = row["Month"].ToString();
                double profit = Convert.ToDouble(row["TotalProfit"]);
                series.Points.AddXY(month, profit);
            }

            chartMonthlyProfits.ChartAreas[0].AxisX.Title = "Month";
            chartMonthlyProfits.ChartAreas[0].AxisY.Title = "Total Profit (AmountPaid)";
        }

        private void frmAdminDashboard_Load(object sender, EventArgs e)
        {
            globalProcedures.checkDatabaseConnection();
            func_LoadAnalytics();
            GetMonthlyProfits();
        }
        private void func_LoadAnalytics()
        {

            globalProcedures.sqlClinicAdapter = new MySqlDataAdapter();
            MySqlCommand sqlCmd = globalProcedures.sqlCommand;
            sqlCmd.Parameters.Clear();
            sqlCmd.CommandText = "procGetAllDataAnalytics";
            sqlCmd.CommandType = CommandType.StoredProcedure;

            using (var reader = sqlCmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    lblDoctorCount.Text = reader.GetInt32(reader.GetOrdinal("DoctorCount")).ToString();
                    lblPatientsCount.Text = reader.GetInt32(reader.GetOrdinal("PatientCount")).ToString(); // based on total appoinments this month
                    lblSecretaryCount.Text = reader.GetInt32(reader.GetOrdinal("SecretaryCount")).ToString();
                }
            }
        }

    }
}
