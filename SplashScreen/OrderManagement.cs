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
    public partial class OrderManagement : Form
    {
        public OrderManagement()
        {
            InitializeComponent();
        }

        Connection dbCon = new Connection();

        private void OrderManagement_Load(object sender, EventArgs e)
        {
            populate();
            dataGridview.DefaultCellStyle.Font = new Font("Poppins", 9, FontStyle.Regular);
            dataGridview.ColumnHeadersDefaultCellStyle.Font = new Font("Poppins", 9, FontStyle.Regular);
        }

        private void populate()
        {
            try
            {
                dbCon.openConnection();
                string query = "select transactionsTable.*, cashierTable.first_name from transactionsTable inner join cashierTable on transactionsTable.user_id = cashierTable.user_id";
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

                dataGridview.Columns["No"].DisplayIndex = 0;
                dataGridview.Columns["transaction_id"].Visible = false;
                dataGridview.Columns["user_id"].Visible = false;

                //rename header
                dataGridview.Columns[0].HeaderText = "No";
                dataGridview.Columns[2].HeaderText = "Transaction Date";
                dataGridview.Columns[3].HeaderText = "Total Amount";
                dataGridview.Columns[4].HeaderText = "Payment Amount";
                dataGridview.Columns[5].HeaderText = "Change Amount";
                dataGridview.Columns[6].HeaderText = "Cashier";

                dbCon.closeConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow rows = this.dataGridview.Rows[e.RowIndex];
            transactionId.Text = rows.Cells["transaction_id"].Value.ToString();
            transactionDate.Text = rows.Cells["transaction_date"].Value.ToString();
            cashierName.Text = rows.Cells["first_name"].Value.ToString();
        }

        private void viewDetailsButton_Click(object sender, EventArgs e)
        {
            try
            {
                if(transactionId.Text == string.Empty || transactionDate.Text == string.Empty || cashierName.Text == string.Empty)
                {
                    MessageBox.Show("Please select a transaction.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    OrderDetails orderDetails = new OrderDetails(transaction_id: transactionId.Text, transaction_date: transactionDate.Text, cashierName: cashierName.Text);
                    orderDetails.Show();
                }
               
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
