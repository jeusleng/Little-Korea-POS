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
    public partial class CashierAddQty : Form
    {
        private string productQty;
        private string temp_id;

        public CashierAddQty(string productQty, string temp_id)
        {
            InitializeComponent();
            productQtyField.Text = productQty;
            this.temp_id = temp_id;
        }

        private void CashierAddQty_Load(object sender, EventArgs e)
        {

        }

        Connection dbCon = new Connection();

        private void addqtyButton_Click(object sender, EventArgs e)
        {
            try {
                dbCon.openConnection();
                string query = "update tempTransactionTable set product_qty = '"+ productQtyField.Text +"' where temp_id = '"+ temp_id +"'";
                SqlCommand cmd = new SqlCommand(query, dbCon.getConnection());

                cmd.ExecuteNonQuery();

                dbCon.closeConnection();

                this.Hide();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
