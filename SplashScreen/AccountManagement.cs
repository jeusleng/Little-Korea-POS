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

                DataTable dataTable = dataSet.Tables[0];

                var statusColumn = new DataGridViewComboBoxColumn();

                statusColumn.HeaderText = "Status";
                statusColumn.DataPropertyName = "Status";
                statusColumn.DataSource = new[] { "Active", "Inactive" };
                statusColumn.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;

                dataGridview.DataSource = dataTable;
                dataGridview.Columns.Add(statusColumn);


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
            passwordField.UseSystemPasswordChar = true;
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
            usernameField.Text = "";
            passwordField.Text = "";
            roleField.Text = "";
        }

        public void searchUser(String searchValue)
        {
            dbCon.openConnection();
            SqlDataAdapter adapter = new SqlDataAdapter("select user_id, username, password, role from usersTable where concat(user_id, username, password, role) LIKE '%" + searchBox.Text + "%'", dbCon.getConnection());
            DataTable newDataTable = new DataTable();
            adapter.Fill(newDataTable);
            dataGridview.DataSource = newDataTable;
            dbCon.closeConnection();
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            searchUser(searchBox.Text);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
