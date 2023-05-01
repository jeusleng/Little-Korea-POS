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
    public partial class AccountManagement : Form
    {
        public AccountManagement()
        {
            InitializeComponent();
            
        }

        Connection dbCon = new Connection();

        private void populate()
        {
            try
            {
                dbCon.openConnection();
                string query = "select * from usersTable";
                SqlDataAdapter sda = new SqlDataAdapter(query, dbCon.getConnection());
                SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(sda);
                var dataSet = new DataSet();
                sda.Fill(dataSet);

                dataGridview.DataSource = dataSet.Tables[0];


                dbCon.closeConnection();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void AccountManagement_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'usersTable._usersTable' table. You can move, or remove it, as needed.
            this.usersTableTableAdapter.Fill(this.usersTable._usersTable);
            populate();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void firstnameField_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void passwordField_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void idField_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        

        private void dataGridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow rows = this.dataGridview.Rows[e.RowIndex];
                idField.Text = rows.Cells["user_id"].Value.ToString();
                usernameField.Text = rows.Cells["username"].Value.ToString();
                passwordField.Text = rows.Cells["password"].Value.ToString();
                roleField.Text = rows.Cells["role"].Value.ToString();
            }
        }

        private void updateButton_Click_1(object sender, EventArgs e)
        {
            if (usernameField.Text == string.Empty || roleField.Text == string.Empty || passwordField.Text == string.Empty)
            {
                MessageBox.Show("Please fill out all fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                dbCon.openConnection();
                SqlDataAdapter sda = new SqlDataAdapter("select user_id from usersTable where user_id='" + idField.Text + "'", dbCon.getConnection());
                DataSet dataSet = new DataSet();
                sda.Fill(dataSet);

                if (dataSet.Tables[0].Rows.Count != 0)
                {
                    SqlCommand cmd = new SqlCommand("update usersTable set username='" + usernameField.Text + "', password='" + passwordField.Text + "', role='" + roleField.Text + "' where user_id='" + idField.Text + "'", dbCon.getConnection());
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("User information updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                dbCon.closeConnection();
                populate();
            }
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            try
            {
                dbCon.openConnection();
                string query = "insert into usersTable values('" + usernameField.Text + "', '" + passwordField.Text + "', '" + roleField.Text + "')";
                SqlCommand cmd = new SqlCommand(query, dbCon.getConnection());

                cmd.ExecuteNonQuery();

                MessageBox.Show("User added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                dbCon.closeConnection();
                populate();

                usernameField.Text = "";
                passwordField.Text = "";
                roleField.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (usernameField.Text == string.Empty || passwordField.Text == string.Empty || roleField.Text == string.Empty)
            {
                MessageBox.Show("Please fill out both fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                dbCon.openConnection();
                SqlDataAdapter sda = new SqlDataAdapter("select user_id from usersTable where user_id='" + idField.Text + "'", dbCon.getConnection());
                DataSet dataSet = new DataSet();
                sda.Fill(dataSet);

                if (dataSet.Tables[0].Rows.Count != 0)
                {
                    if (MessageBox.Show("Do you want to delete this user?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        SqlCommand cmd = new SqlCommand("delete from usersTable where user_id='" + idField.Text + "'", dbCon.getConnection());
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("User deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                dbCon.closeConnection();
                populate();
            }
        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            try
            {
                dbCon.openConnection();
                string query = "select * from usersTable where username='" + usernameField.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, dbCon.getConnection());
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    idField.Text = dt.Rows[0]["user_id"].ToString();
                    passwordField.Text = dt.Rows[0]["password"].ToString();
                    roleField.Text = dt.Rows[0]["role"].ToString();
                    AccountDetails acctDetails = new AccountDetails(username: usernameField.Text, role: roleField.Text);
                    this.Close();
                    acctDetails.Show();
                }
                else
                {
                    MessageBox.Show("Username not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                dbCon.closeConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
