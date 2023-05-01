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

namespace SplashScreenLadera
{
    public partial class ProductDetails : Form
    {
        
        public ProductDetails(int productId, string productName, decimal productPrice, int stock, int categoryId)
        {
            InitializeComponent();

            prodId.Text = productId.ToString();
            name.Text = productName;
            price.Text = productPrice.ToString("0.00");
            stockLabel.Text = stock.ToString();

            // Fetch the category name from the database using the category ID
            Connection dbCon = new Connection();
            dbCon.openConnection();
            string query = "SELECT category_name FROM categoryTable WHERE category_id=@categoryId";
            SqlCommand cmd = new SqlCommand(query, dbCon.getConnection());
            cmd.Parameters.AddWithValue("@categoryId", categoryId);
            string categoryName = Convert.ToString(cmd.ExecuteScalar());
            dbCon.closeConnection();

            categoryLabel.Text = categoryName;
            name.Text = productName;
            price.Text = productPrice.ToString();
            stockLabel.Text = stock.ToString();
        }

        private void ProductDetails_Load(object sender, EventArgs e)
        {
            
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
