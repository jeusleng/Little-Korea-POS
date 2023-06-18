using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using SplashScreenLadera;
using Guna.UI2.WinForms;

namespace SplashScreen
{
    public partial class ProductsManagement : Form
    {
        public ProductsManagement()
        {
            InitializeComponent();
        }

        Connection dbCon = new Connection();

        public class ComboboxItem
        {
            public string Text { get; set; }
            public string Value { get; set; }

            public ComboboxItem(string text, string value)
            {
                Text = text;
                Value = value;
            }

            public override string ToString()
            {
                return Text;
            }
        }

        private void populate()
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

                dataGridview.DataSource = dataTable;

                dataGridview.Columns["No"].DisplayIndex = 0;
                dataGridview.Columns["product_id"].Visible = false;
                dataGridview.Columns["category_id"].Visible = false;
                dataGridview.Columns["category_id1"].Visible = false;

                //rename header
                dataGridview.Columns[0].HeaderText = "No";
                dataGridview.Columns[1].HeaderText = "Product Name";
                dataGridview.Columns[2].HeaderText = "Price";
                dataGridview.Columns[3].HeaderText = "Stock";
                dataGridview.Columns[6].HeaderText = "Category Name";

                dbCon.closeConnection();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void bindcomboBox()
        {
            dbCon.openConnection();
            string query = "SELECT * FROM categoryTable";
            SqlCommand cmd = new SqlCommand(query, dbCon.getConnection());
            SqlDataReader reader = cmd.ExecuteReader();
            categoryDropdown.Items.Clear();
            if (!reader.HasRows)
            {
                categoryDropdown.Items.Add(new ComboboxItem("No categories available.", null));
            }
            else
            {
                while (reader.Read())
                {
                    categoryDropdown.Items.Add(new ComboboxItem(reader["category_name"].ToString(), reader["category_id"].ToString()));
                }
            }
            reader.Close();
            dbCon.closeConnection();
        }

        private void ProductsManagement_Load(object sender, EventArgs e)
        {
            populate();
            bindcomboBox();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void categoryDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            try
            {
                ComboboxItem selectedItem = (ComboboxItem)categoryDropdown.SelectedItem;
               
                if (productName.Text == string.Empty || productPrice.Text == string.Empty || stock.Text == string.Empty || categoryDropdown.SelectedItem == null)
                {
                    MessageBox.Show("Please fill out all fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    int categoryId = Convert.ToInt32(selectedItem.Value);
                    dbCon.openConnection();
                    string query = "insert into productsTable values('" + productName.Text + "', '" + productPrice.Text + "', '" + stock.Text + "', '" + categoryId + "')";
                    SqlCommand cmd = new SqlCommand(query, dbCon.getConnection());

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Product added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    dbCon.closeConnection();
                    populate();

                    productName.Text = "";
                    productPrice.Text = "";
                    stock.Text = "";
                    categoryDropdown.SelectedItem = null;
                }
                
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void category_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow rows = this.dataGridview.Rows[e.RowIndex];
                productId.Text = rows.Cells["product_id"].Value.ToString();
                productName.Text = rows.Cells["product_name"].Value.ToString();
                productPrice.Text = rows.Cells["product_price"].Value.ToString();
                stock.Text = rows.Cells["stock"].Value.ToString();
                foreach (ComboboxItem item in categoryDropdown.Items)
                {
                    if (item.Value == rows.Cells["category_id"].Value.ToString())
                    {
                        categoryDropdown.SelectedItem = item;
                        break;
                    }
                }
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (productName.Text == string.Empty || productPrice.Text == string.Empty || stock.Text == string.Empty || categoryDropdown.SelectedItem == null)
            {
                MessageBox.Show("Please fill out all fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                dbCon.openConnection();
                SqlDataAdapter sda = new SqlDataAdapter("select product_id from productsTable where product_id='" + productId.Text + "'", dbCon.getConnection());
                DataSet dataSet = new DataSet();
                sda.Fill(dataSet);

                if (dataSet.Tables[0].Rows.Count != 0)
                {
                    ComboboxItem selectedItem = (ComboboxItem)categoryDropdown.SelectedItem;
                    int categoryId = Convert.ToInt32(selectedItem.Value);
                    SqlCommand cmd = new SqlCommand("update productsTable set product_name='" + productName.Text + "', product_price='" + productPrice.Text + "', stock='" + stock.Text + "', category_id='" + categoryId + "' where product_id='" + productId.Text + "'", dbCon.getConnection());
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Product information updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                dbCon.closeConnection();
                productName.Text = "";
                productPrice.Text = "";
                stock.Text = "";
                categoryDropdown.SelectedItem = null;
                populate();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (productName.Text == string.Empty || productPrice.Text == string.Empty || stock.Text == string.Empty || categoryDropdown.SelectedItem == null)
            {
                MessageBox.Show("Please fill out all fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                dbCon.openConnection();
                SqlDataAdapter sda = new SqlDataAdapter("select product_id from productsTable where product_id='" + productId.Text + "'", dbCon.getConnection());
                DataSet dataSet = new DataSet();
                sda.Fill(dataSet);

                if (dataSet.Tables[0].Rows.Count != 0)
                {
                    if (MessageBox.Show("Do you want to delete this product?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        SqlCommand cmd = new SqlCommand("delete from productsTable where product_id='" + productId.Text + "'", dbCon.getConnection());
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Product deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                dbCon.closeConnection();
                productName.Text = "";
                productPrice.Text = "";
                stock.Text = "";
                categoryDropdown.SelectedItem = null;
                populate();
            }
        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            if (dataGridview.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridview.SelectedRows[0];

                // Extract the product details from the selected row
                int productId = Convert.ToInt32(selectedRow.Cells["product_id"].Value);
                string productName = Convert.ToString(selectedRow.Cells["product_name"].Value);
                decimal productPrice = Convert.ToDecimal(selectedRow.Cells["product_price"].Value);
                int stock = Convert.ToInt32(selectedRow.Cells["stock"].Value);
                int categoryId = Convert.ToInt32(selectedRow.Cells["category_id"].Value);

                // Create a new instance of the ProductDetails form and pass the product details
                ProductDetails productDetails = new ProductDetails(productId, productName, productPrice, stock, categoryId);
                productDetails.Show();
            }
            else
            {
                MessageBox.Show("Please select a product to view its details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        public void searchProduct(String searchValue)
        {
            try
            {
                dbCon.openConnection();
                string query = "select * from productsTable inner join categoryTable on productsTable.category_id = categoryTable.category_id where product_name like '%" + searchBox.Text + "%'";
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
                dataGridview.Columns["product_id"].Visible = false;
                dataGridview.Columns["category_id"].Visible = false;
                dataGridview.Columns["category_id1"].Visible = false;

                //rename header
                dataGridview.Columns[0].HeaderText = "No";
                dataGridview.Columns[1].HeaderText = "Product Name";
                dataGridview.Columns[2].HeaderText = "Price";
                dataGridview.Columns[3].HeaderText = "Stock";
                dataGridview.Columns[6].HeaderText = "Category Name";

                dbCon.closeConnection();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            searchProduct(searchBox.Text);
        }
    }
}
