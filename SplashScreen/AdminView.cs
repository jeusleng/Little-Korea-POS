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

namespace SplashScreen
{
    public partial class Form1 : Form
    {
        private string username;
        private string role;

        Connection con = new Connection();

        public Form1(string username)
        {
            InitializeComponent();
            this.username = username;
        }


        private void btnMedia_Click(object sender, EventArgs e)
        {
            openChildForm(new Form2());
        }

       

        private void btnPlaylist_Click(object sender, EventArgs e)
        {
            openChildForm(new AccountManagement());
        }



        #region PlayListManagemetSubMenu
        private void button8_Click(object sender, EventArgs e)
        {
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            
        }
        #endregion

        private void btnTools_Click(object sender, EventArgs e)
        {
            openChildForm(new CategoryManagement());
        }
        

        private void btnEqualizer_Click(object sender, EventArgs e)
        {
            openChildForm(new ProductsManagement());
            //..
            //your codes
            
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            openChildForm(new CashierManagement());
            //..
            //your codes
            //..

        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AdminHomepage_Load(object sender, EventArgs e)
        {

            Timer timer1 = new Timer();
            timer1.Interval = 1000; // 1 second
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start();

            // Retrieve the user's role from the database
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

        private void usernameLabel_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            currentTimeDisplay.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void ordersBtn_Click(object sender, EventArgs e)
        {
            openChildForm(new OrderManagement());
        }
    }
}
