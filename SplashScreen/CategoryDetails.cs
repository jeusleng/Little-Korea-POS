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
    // CategoryDetails form
    public partial class CategoryDetails : Form
    {
        private int categoryId;

        public CategoryDetails(int categoryId)
        {
            InitializeComponent();

            this.categoryId = categoryId;

            // Fetch category details from the database
            try
            {
                Connection dbCon = new Connection();
                dbCon.openConnection();

                string query = "SELECT category_name FROM categoryTable WHERE category_id = @categoryId";
                SqlCommand cmd = new SqlCommand(query, dbCon.getConnection());
                cmd.Parameters.AddWithValue("@categoryId", categoryId);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    // Populate controls with fetched data
                    name.Text = reader["category_name"].ToString();
                    
                }

                reader.Close();
                dbCon.closeConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
