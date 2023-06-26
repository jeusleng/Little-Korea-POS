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

        private CashierDetailsScreen cashierDetailsScreen;

        public AccountManagement()
        {
            InitializeComponent();

            cashierDetailsScreen = new CashierDetailsScreen();
            cashierDetailsScreen.CashierUpdated += CashierDetailsScreen_CashierUpdated;


        }

        // Event handler for the CashierUpdated event
        private void CashierDetailsScreen_CashierUpdated(object sender, EventArgs e)
        {
            // Refresh the data grid view
            populate();
        }

        Connection dbCon = new Connection();
        private bool isComboBoxEditingControlShown;

        private void populate()
        {
            try
            {
                dbCon.openConnection();
                string query = "select * from usersTable where role = 'Cashier'";
                SqlDataAdapter sda = new SqlDataAdapter(query, dbCon.getConnection());
                SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(sda);
                var dataSet = new DataSet();
                sda.Fill(dataSet);

                DataTable dataTable = dataSet.Tables[0];
                dataTable.Columns.Add("No", typeof(int));

                //add counter 
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    dataTable.Rows[i]["No"] = i + 1;
                }

                var statusColumn = new DataGridViewComboBoxColumn();

                statusColumn.HeaderText = "Status";
                statusColumn.DataPropertyName = "Status";
                statusColumn.DataSource = new[] { "Active", "Inactive" };
                statusColumn.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;

                dataGridview.DataSource = dataTable;
                dataGridview.Columns.Add(statusColumn);
                dataGridview.Columns["No"].DisplayIndex = 0;
                dataGridview.Columns["user_id"].Visible = false;
                dataGridview.Columns["status"].Visible = false;


                // Customize header titles
                dataGridview.Columns["username"].HeaderText = "Username";
                dataGridview.Columns["password"].HeaderText = "Password";
                dataGridview.Columns["role"].HeaderText = "Role";

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
            dataGridview.CellClick += dataGridview_CellClick;
            dataGridview.CellBeginEdit += dataGridview_CellBeginEdit;
            dataGridview.CellEndEdit += dataGridview_CellEndEdit;
            dataGridview.DefaultCellStyle.Font = new Font("Poppins", 9, FontStyle.Regular);
            dataGridview.ColumnHeadersDefaultCellStyle.Font = new Font("Poppins", 9, FontStyle.Regular);
            
        }

        private void dataGridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var column = dataGridview.Columns[e.ColumnIndex];
                if (column is DataGridViewComboBoxColumn && !isComboBoxEditingControlShown)
                {
                    isComboBoxEditingControlShown = true;
                    dataGridview.BeginEdit(true);
                    var editingControl = dataGridview.EditingControl as DataGridViewComboBoxEditingControl;
                    editingControl.DroppedDown = true;
                }
            }
        }

        private void dataGridview_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var column = dataGridview.Columns[e.ColumnIndex];
                if (column is DataGridViewComboBoxColumn)
                {
                    isComboBoxEditingControlShown = true;
                }
            }
        }

        private void dataGridview_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var column = dataGridview.Columns[e.ColumnIndex];
                if (column is DataGridViewComboBoxColumn)
                {
                    isComboBoxEditingControlShown = false;
                }
            }
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

        private void AccountManagement_Click(object sender, EventArgs e)
        {

        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (dataGridview.SelectedCells.Count > 0)
            {
                int rowIndex = dataGridview.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridview.Rows[rowIndex];
                string userId = selectedRow.Cells["user_id"].Value.ToString();
                string status = selectedRow.Cells["Status"].FormattedValue.ToString();

                try
                {
                    dbCon.openConnection();
                    string query = "UPDATE usersTable SET Status = @status WHERE user_id = @userId";
                    SqlCommand cmd = new SqlCommand(query, dbCon.getConnection());
                    cmd.Parameters.AddWithValue("@status", status);
                    cmd.Parameters.AddWithValue("@userId", userId);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Status updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dbCon.closeConnection();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a user to update the status.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}

