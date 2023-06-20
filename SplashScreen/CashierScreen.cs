using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SplashScreenLadera
{
    public partial class CashierScreen : Form
    {
        private string username;
        private string userId;

        public CashierScreen(string username, string userId)
        {
            this.userId = userId;
            InitializeComponent();
        }

        private void CashierScreen_Load(object sender, EventArgs e)
        {
            populateProduct();
            populateTempTransaction();

            Timer timer1 = new Timer();
            timer1.Interval = 1000; // 1 second
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start();
        }

        Connection dbCon = new Connection();

        private void populateProduct()
        {
            try
            {
                dbCon.openConnection();
                string query = "select * from productsTable inner join categoryTable on productsTable.category_id = categoryTable.category_id";
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

                productGridview.DataSource = dataTable;

                productGridview.Columns["No"].DisplayIndex = 0;
                productGridview.Columns["product_id"].Visible = false;
                productGridview.Columns["category_id"].Visible = false;
                productGridview.Columns["category_id1"].Visible = false;
                productGridview.Columns["category_name"].Visible = false;

                //rename header
                productGridview.Columns[0].HeaderText = "No";
                productGridview.Columns[1].HeaderText = "Product Name";
                productGridview.Columns[2].HeaderText = "Price";
                productGridview.Columns[3].HeaderText = "Stock";

                dbCon.closeConnection();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public double totalPrice;

        private void populateTempTransaction()
        {
          

            try
            {
                totalPrice = 0;
                dbCon.openConnection();
                string query = "select *, (product_price * product_qty) as totalPrice from tempTransactionTable where user_id = '"+ userId +"'";
                SqlDataAdapter sda = new SqlDataAdapter(query, dbCon.getConnection());
                SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(sda);
                var dataSet = new DataSet();
                sda.Fill(dataSet);

                DataTable dataTable = dataSet.Tables[0];
                dataTable.Columns.Add("No", typeof(int));

                //add counter and get total price
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    dataTable.Rows[i]["No"] = i + 1;
                    float rowTotalPrice = Convert.ToSingle(dataTable.Rows[i]["totalPrice"]); // Convert the value to float
                    totalPrice += rowTotalPrice;
                }

                temptransactionGridview.DataSource = dataTable;

                temptransactionGridview.Columns["No"].DisplayIndex = 0;
                temptransactionGridview.Columns["temp_id"].Visible = false;
                temptransactionGridview.Columns["user_id"].Visible = false;
                temptransactionGridview.Columns["product_id"].Visible = false;

                //rename header
                temptransactionGridview.Columns[0].HeaderText = "No";
                temptransactionGridview.Columns[1].HeaderText = "Name";
                temptransactionGridview.Columns[2].HeaderText = "Price";
                temptransactionGridview.Columns[3].HeaderText = "Quantity";
                temptransactionGridview.Columns[4].HeaderText = "Total Price";


                dbCon.closeConnection();

                totalAmountLabel.Text = totalPrice.ToString();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }


        private void productGridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow rows = this.productGridview.Rows[e.RowIndex];
                productId.Text = rows.Cells["product_id"].Value.ToString();
                productName.Text = rows.Cells["product_name"].Value.ToString();
                productPrice.Text = rows.Cells["product_price"].Value.ToString();
            }
        }

        private void temptransactionGridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow rows = this.temptransactionGridview.Rows[e.RowIndex];
                productId.Text = rows.Cells["temp_id"].Value.ToString();
                productQtyField.Text = rows.Cells["product_qty"].Value.ToString();
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                if(productName.Text == string.Empty || productPrice.Text == string.Empty || productQty.Text == string.Empty) {
                    MessageBox.Show("Please fill out quanity.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    dbCon.openConnection();
                    string query = "insert into tempTransactionTable values('"+ userId +"', '"+ productId.Text +"', '"+ productName.Text +"', '"+ productPrice.Text +"', '"+ productQty.Text +"')";
                    SqlCommand cmd = new SqlCommand(query, dbCon.getConnection());

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Product added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    dbCon.closeConnection();
                    populateTempTransaction();

                    productId.Text = "";
                    productName.Text = "";
                    productPrice.Text = "";
                    productQty.Text = "";
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void voidButton_Click(object sender, EventArgs e)
        {
            try
            {
                if(productId.Text == string.Empty)
                {
                    MessageBox.Show("Please select an item to void.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    dbCon.openConnection();
                    string query = "delete from tempTransactionTable where temp_id = '"+ productId.Text +"'";
                    SqlCommand cmd = new SqlCommand(query, dbCon.getConnection());

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Product voided successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    dbCon.closeConnection();
                    populateTempTransaction();

                    productId.Text = "";
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void newtransButton_Click(object sender, EventArgs e)
        {
            try
            {
                dbCon.openConnection();
                string query = "delete from tempTransactionTable where user_id = '"+ userId +"'";
                SqlCommand cmd = new SqlCommand(query, dbCon.getConnection());

                cmd.ExecuteNonQuery();

                MessageBox.Show("Created new transaction successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                dbCon.closeConnection();
                populateTempTransaction();

                transIdLabel.Text = "0";
                totalAmountLabel.Text = "0";
                changeLabel.Text = "0";
                amountPaidLabel.Text = "0";

                paymentButton.Enabled = true;
                addqtyButton.Enabled = true;
                voidButton.Enabled = true;
                cancelButton.Enabled = true;
                newtransButton.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void addqtyButton_Click(object sender, EventArgs e)
        {
            if(productQtyField.Text == string.Empty || productId.Text == string.Empty)
            {
                MessageBox.Show("Please select an item to add quantity.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                CashierAddQty cashierAddQty = new CashierAddQty(productQty: productQtyField.Text, temp_id: productId.Text);
                cashierAddQty.ShowDialog();

                MessageBox.Show("Quantity changed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            

            populateTempTransaction() ;
        }

        private void paymentButton_Click(object sender, EventArgs e)
        {
            CashierPay cashierPay = new CashierPay();
            cashierPay.ShowDialog();
            double amountPaid = Convert.ToDouble(cashierPay.amountPay.Text);

            if (amountPaid < totalPrice) 
            {
                cashierPay.Hide();
                MessageBox.Show("Insufficient amount.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                amountPaidLabel.Text = amountPaid.ToString();
                changeLabel.Text = (amountPaid - totalPrice).ToString();

                dbCon.openConnection();
                //create new transaction
                string query1 = "insert into transactionsTable values('" +userId+ "', GETDATE(), '"+ totalPrice +"', '"+ amountPaid +"', '"+ (amountPaid - totalPrice).ToString() + "')";
                SqlCommand cmd1 = new SqlCommand(query1, dbCon.getConnection());

                cmd1.ExecuteNonQuery();

                //select recently created transaction
                string query2 = "select top 1 transaction_id from transactionsTable order by transaction_date desc";
                SqlCommand cmd2 = new SqlCommand(query2, dbCon.getConnection());
                int transactionId = Convert.ToInt32(cmd2.ExecuteScalar());
                transIdLabel.Text = transactionId.ToString();

                cmd2.ExecuteNonQuery();

                //select all items to be purchased
                string query3 = "select *, (product_price * product_qty) as totalPrice from tempTransactionTable where user_id = '"+ userId +"'";
                SqlCommand cmd3 = new SqlCommand(query3, dbCon.getConnection());

                SqlDataReader reader = cmd3.ExecuteReader();

                List<Dictionary<string, object>> selectedItems = new List<Dictionary<string, object>>();

                //put the selected items in a list
                while (reader.Read())
                {
                    Dictionary<string, object> row = new Dictionary<string, object>();
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        row[reader.GetName(i)] = reader[i];
                    }
                    selectedItems.Add(row);
                }

                reader.Close();

                //loop the list insert each product details
                foreach (Dictionary<string, object> item in selectedItems)
                {
                    int product_id = Convert.ToInt32(item["product_id"]);
                    int product_qty = Convert.ToInt32(item["product_qty"]);
                    decimal product_price = Convert.ToDecimal(item["product_price"]);
                    decimal itemTotalPrice = product_qty * product_price;



                    string query4 = "insert into transactionDetailsTable values('" + transactionId + "', '" + product_id + "', '" + product_qty + "', '" + product_price + "', '" + itemTotalPrice + "')";
                    SqlCommand cmd4 = new SqlCommand(query4, dbCon.getConnection());
                    cmd4.ExecuteNonQuery();

                    SqlCommand cmd5 = new SqlCommand("UPDATE productsTable SET stock = stock - '" + product_qty + "' WHERE product_id = '" + product_id + "'", dbCon.getConnection());
                    cmd5.ExecuteNonQuery();
                }

             

                dbCon.closeConnection();

                paymentButton.Enabled = false;
                addqtyButton.Enabled = false;
                voidButton.Enabled = false;
                cancelButton.Enabled = false;
                newtransButton.Enabled = true;

                cashierPay.Hide();
                MessageBox.Show("Transaction Complete!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            try
            {
                dbCon.openConnection();
                string query = "delete from tempTransactionTable where user_id = '" + userId + "'";
                SqlCommand cmd = new SqlCommand(query, dbCon.getConnection());

                cmd.ExecuteNonQuery();

                MessageBox.Show("Created new transaction successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                dbCon.closeConnection();
                populateTempTransaction();

                transIdLabel.Text = "0";
                totalAmountLabel.Text = "0";
                changeLabel.Text = "0";
                amountPaidLabel.Text = "0";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            datetime.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
