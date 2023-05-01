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
    public partial class AccountDetails : Form
    {

        private string username;
        private string role;
        Connection con = new Connection();

        public AccountDetails(string username, string role)
        {
            InitializeComponent();
            this.username = username;
            this.role = role;
        }

        private void AccountDetails_Load(object sender, EventArgs e)
        {
            con.openConnection();

            string query = "SELECT role FROM usersTable WHERE username = @username";
            SqlCommand cmd = con.createCommand();
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("@username", username);

            string role = (string)cmd.ExecuteScalar();

            con.closeConnection();

            // Display the username and role in the form
            usernameLabel.Text = username;
            roleLabel.Text = role;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
