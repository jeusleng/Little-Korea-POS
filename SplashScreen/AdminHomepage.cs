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
    public partial class AdminHomepage : Form
    {
        private string username;
        private string role;
        public AdminHomepage(string username)
        {
            InitializeComponent();

            // Store the username when the form is created
            this.username = username;

        }

        private void currentTimeDisplay_Click(object sender, EventArgs e)
        {

        }

        private void AdminHomepage_Load(object sender, EventArgs e)
        {
            Timer timerUpdater = new Timer();
            timerUpdater.Interval = 1000; // 1 second
            timerUpdater.Tick += new EventHandler(timerUpdater_Tick);
            timerUpdater.Start();

            // Retrieve the user's role from the database
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ASUS\\Documents\\sampleDB.mdf;Integrated Security=True;Connect Timeout=30";
            string query = "SELECT role FROM usersTable WHERE username = @username";
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@username", username);
                connection.Open();
                role = (string)command.ExecuteScalar();
            }

            // Display the username and role in the form
            usernameLabel.Text = username;
            roleLabel.Text = role;
        }

        private void timerUpdater_Tick(object sender, EventArgs e)
        {
            currentTimeDisplay.Text = DateTime.Now.ToString("hh:mm:ss tt");

        }


        private void productsButton_Click(object sender, EventArgs e)
        {
           
        }

        private void dashboadButton_Click(object sender, EventArgs e)
        {
            
            
        }

        private void usernameLabel_Click(object sender, EventArgs e)
        {

        }

        private void roleLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
