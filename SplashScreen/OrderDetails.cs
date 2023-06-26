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

namespace SplashScreenLadera
{
    public partial class OrderDetails : Form
    {
        public OrderDetails(String transaction_id, String transaction_date, String cashierName)
        {
            InitializeComponent();
            transactionIdLabel.Text = transaction_id;
            transactionDateLabel.Text = transaction_date;
            cashierNameLabel.Text = cashierName; 
        }

        Connection dbCon = new Connection();

        private void OrderDetails_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void populate()
        {
            dbCon.openConnection();
            string query = "select * from transactionDetailsTable where transaction_id = '"+ transactionIdLabel.Text +"'";
            SqlDataAdapter sda = new SqlDataAdapter(query, dbCon.getConnection());
            SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(sda);
            var dataSet = new DataSet();
            sda.Fill(dataSet);

            DataTable dataTable = dataSet.Tables[0];
            dataTable.Columns.Add("No", typeof(int));

            //add counter 
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dataTable.Rows[i]["No"] = i + 1;
            }

            dataGridview.DataSource = dataTable;

            dataGridview.Columns["transaction_id"].Visible = false;
            dataGridview.Columns["transaction_details_id"].Visible = false;

            // Customize header titles
            dataGridview.Columns["product_id"].HeaderText = "Product ID";
            dataGridview.Columns["quantity"].HeaderText = "Quantity";
            dataGridview.Columns["price"].HeaderText = "Price";
            dataGridview.Columns["total_price"].HeaderText = "Total Price";


            dbCon.closeConnection();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
