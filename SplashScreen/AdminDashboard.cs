using LiveCharts.Wpf;
using LiveCharts;
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
using Newtonsoft.Json.Linq;

namespace SplashScreenLadera
{
    public partial class AdminDashboard : Form
    {

        public AdminDashboard()
        {
            InitializeComponent();
        }

        Connection dbCon = new Connection();

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            populate();
        }

        void populate()
        {
            dbCon.openConnection();
            string query1 = "select count(*) from usersTable where status = 'Active'";
            SqlCommand cmd1 = new SqlCommand(query1, dbCon.getConnection());
            int countActive = Convert.ToInt32(cmd1.ExecuteScalar());

            string query2 = "select count(*) from usersTable where status = 'Inactive'";
            SqlCommand cmd2 = new SqlCommand(query2, dbCon.getConnection());
            int countInactive = Convert.ToInt32(cmd2.ExecuteScalar());

            string query3 = "select count(*) from transactionsTable";
            SqlCommand cmd3 = new SqlCommand(query3, dbCon.getConnection());
            countTransLabel.Text = cmd3.ExecuteScalar().ToString();

            string query4 = "select count(*) from productsTable";
            SqlCommand cmd4 = new SqlCommand(query4, dbCon.getConnection());
            countItemsLabel.Text = cmd4.ExecuteScalar().ToString();

            string query5 = "select count(*) from transactionDetailsTable";
            SqlCommand cmd5 = new SqlCommand(query5, dbCon.getConnection());
            countSoldLabel.Text = cmd5.ExecuteScalar().ToString();
            dbCon.closeConnection();

            ChartValues<int> activeValues = new ChartValues<int> { countActive };
            ChartValues<int> inactiveValues = new ChartValues<int> { countInactive };

            cashierChart.Series.Clear();
            cashierChart.Series.Add(new PieSeries
            {
                Title = "Active",
                Values = activeValues
            });
            cashierChart.Series.Add(new PieSeries
            {
                Title = "Inactive",
                Values = inactiveValues
            });
                
           
        }
    }
}
