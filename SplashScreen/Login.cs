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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\Documents\sampleDB.mdf;Integrated Security=True;Connect Timeout=30");

        private void FrmMain_Load(object sender, EventArgs e)
        {
            display_users();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void usernameField_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordField_TextChanged(object sender, EventArgs e)
        {
            passwordField.UseSystemPasswordChar = true;
        }

        private void maximizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into usersTable values('"+usernameField.Text+"', '"+passwordField.Text+"')";
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Record inserted successfully!");
                display_users();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            //ORIGINAL CODE
            //try
            //{
            //    if (string.IsNullOrEmpty(usernameField.Text) || string.IsNullOrEmpty(passwordField.Text))
            //    {
            //        MessageBox.Show("Please enter both username and password.");
            //        return;
            //    }

            //    con.Open();
            //    SqlCommand cmd = con.CreateCommand();
            //    cmd.CommandType = CommandType.Text;
            //    cmd.CommandText = "delete from usersTable where username='"+usernameField.Text+"'";
            //    cmd.ExecuteNonQuery();
            //    con.Close();

            //    MessageBox.Show("Record deleted successfully!");
            //    display_users();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}

            //CODE NI SIR
            if(usernameField.Text == string.Empty)
            {
                MessageBox.Show("Please select a user to be deleted", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select user_id from usersTable where user_id='"+idField.Text+"'", con);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                if(ds.Tables[0].Rows.Count != 0)
                {
                    if (MessageBox.Show("Do you want to delete this user?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        SqlCommand cmd = new SqlCommand("delete from usersTable where user_id='"+idField.Text+"'", con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("User deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                    }
                }
                
                con.Close();
                display_users();
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            
        }

        public void display_users()
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from usersTable";
                cmd.ExecuteNonQuery();

                DataTable dataTbl = new DataTable();
                SqlDataAdapter dataAdap = new SqlDataAdapter(cmd);
                dataAdap.Fill(dataTbl);
                gridView.DataSource = dataTbl;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            //ORIGINAL CODE
            //try
            //{
            //    // Validate user input
            //    if (string.IsNullOrEmpty(usernameField.Text) || string.IsNullOrEmpty(passwordField.Text))
            //    {
            //        MessageBox.Show("Please enter both username and password.");
            //        return;
            //    }

            //    con.Open();
            //    SqlCommand cmd = con.CreateCommand();
            //    cmd.CommandType = CommandType.Text;
            //    cmd.CommandText = "update usersTable set username='" + usernameField.Text + "' where password='" + passwordField.Text + "'";
            //    cmd.ExecuteNonQuery();

            //    con.Close();

            //    MessageBox.Show("Record updated successfully!");
            //    display_users();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}

            //CODE NI SIR
            if (usernameField.Text == string.Empty || passwordField.Text == string.Empty)
            {
                MessageBox.Show("Please fill out all fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select user_id from usersTable where user_id='" + idField.Text + "'", con);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                if (ds.Tables[0].Rows.Count != 0)
                {
                        SqlCommand cmd = new SqlCommand("update usersTable set username='"+usernameField.Text+"', password='"+passwordField.Text+"' where user_id='" + idField.Text + "'", con);
                        cmd.ExecuteNonQuery();
                        
                        MessageBox.Show("User info updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }

                con.Close();
                display_users();
            }

        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            //ORIGINAL CODE
            //try
            //{
            //    if (string.IsNullOrEmpty(usernameField.Text) || string.IsNullOrEmpty(passwordField.Text))
            //    {
            //        MessageBox.Show("Please enter both username and password.");
            //        return;
            //    }

            //    con.Open();
            //    SqlCommand cmd = con.CreateCommand();
            //    cmd.CommandType = CommandType.Text;
            //    cmd.CommandText = "select * from usersTable where username='" + usernameField.Text + "' and password='" + passwordField.Text + "'";
            //    SqlDataReader reader = cmd.ExecuteReader();

            //    if (reader.HasRows)
            //    {

            //        reader.Close();
            //        con.Close();
            //        MessageBox.Show("Correct credentials", "CORRECT", MessageBoxButtons.OK);

            //        SplashScreenLadera.HomePage loginPage = new SplashScreenLadera.HomePage();
            //        this.Hide();
            //        loginPage.Show();
            //    }
            //    else
            //    {
            //        reader.Close();
            //        con.Close();
            //        MessageBox.Show("Your username or password is incorrect.", "Incorrect Credentials", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}

            //CODE NI SIR
            if (usernameField.Text == string.Empty)
            {
                MessageBox.Show("Please enter your username.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (passwordField.Text == string.Empty)
            {
                MessageBox.Show("Please enter your password.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select count (*) from usersTable where username='" + usernameField.Text + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    SqlDataAdapter sda2 = new SqlDataAdapter("select count (*) from usersTable where username='" + usernameField.Text + "' and password='" + passwordField.Text + "'", con);
                    DataTable dt2 = new DataTable();
                    sda2.Fill(dt2);
                    if (dt2.Rows[0][0].ToString() == "1")
                    {
                        Form1 form1 = new Form1(username: usernameField.Text);
                        this.Hide();
                        form1.Show();
                    }
                    else
                    {
                        MessageBox.Show("Your password is incorrect.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Your username is incorrect.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                con.Close();
            }

        }

        private void gridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = this.gridView.Rows[e.RowIndex];
                idField.Text = row.Cells["user_id"].Value.ToString();
                usernameField.Text = row.Cells["username"].Value.ToString();
                passwordField.Text = row.Cells["password"].Value.ToString();
            }
        }

        private void idField_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            idField.Text = "";
            usernameField.Text = "";
            passwordField.Text = "";
        }

        public void searching(String searchValue)
        {
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select username, password from usersTable where concat(username, password) LIKE '%"+searchBox.Text+"%'", con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            gridView.DataSource = dt;
            con.Close();
        }
        
        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            searching(searchBox.Text);
        }
    }
}
