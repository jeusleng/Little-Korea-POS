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
    public partial class RegisterUser : Form
    {
        public RegisterUser()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\Documents\sampleDB.mdf;Integrated Security=True;Connect Timeout=30");

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "insert into usersTable values('" + usernameField.Text + "', '" + passwordField.Text + "', '" + firstnameField.Text + "', '" + lastnameField.Text + "', '" + phoneField.Text + "', '" + roleField.Text + "')";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.ExecuteNonQuery();

                MessageBox.Show("User added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                con.Close();

                usernameField.Text = "";
                passwordField.Text = "";
                firstnameField.Text = "";
                lastnameField.Text = "";
                phoneField.Text = "";
                roleField.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
