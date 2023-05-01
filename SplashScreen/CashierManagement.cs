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
using Guna.UI2.WinForms;

namespace SplashScreen
{
    public partial class CashierManagement : Form
    {
        public CashierManagement()
        {
            InitializeComponent();
        }

        Connection dbCon = new Connection();

        private void populate()
        {
            try
            {
                dbCon.openConnection();
                string query = "select * from cashierTable";
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


        private void CashierManagement_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            try
            {
                dbCon.openConnection();
                string query = "insert into cashierTable values('" + firstName.Text + "', '" + lastName.Text + "', 'dummyusername', 'dummypass', '" + contactNum.Text + "', '" + birthday.Text + "', '" + dateHired.Text + "', '" + salary.Text + "', 'Active')";
                SqlCommand cmd = new SqlCommand(query, dbCon.getConnection());

                cmd.ExecuteNonQuery();

                MessageBox.Show("Cashier added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                dbCon.closeConnection();
                populate();

                firstName.Text = "";
                lastName.Text = "";
                contactNum.Text = "";
                birthday.Text = "";
                dateHired.Text = "";
                salary.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow rows = this.dataGridview.Rows[e.RowIndex];
                cashierId.Text = rows.Cells["cashier_id"].Value.ToString();
                firstName.Text = rows.Cells["first_name"].Value.ToString();
                lastName.Text = rows.Cells["last_name"].Value.ToString();
                contactNum.Text = rows.Cells["contact_no"].Value.ToString();
                birthday.Text = rows.Cells["birthday"].Value.ToString();
                dateHired.Text = rows.Cells["date_hired"].Value.ToString();
                salary.Text = rows.Cells["salary"].Value.ToString();
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (contactNum.Text == string.Empty)
            {
                MessageBox.Show("Please fill out Cashier field.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                dbCon.openConnection();
                SqlDataAdapter sda = new SqlDataAdapter("select cashier_id from cashierTable where cashier_id='" + cashierId.Text + "'", dbCon.getConnection());
                DataSet dataSet = new DataSet();
                sda.Fill(dataSet);

                if (dataSet.Tables[0].Rows.Count != 0)
                {
                    SqlCommand cmd = new SqlCommand("update cashierTable set first_name='" + firstName.Text + "', last_name='" + lastName.Text + "', contact_no='" + contactNum.Text + "', birthday='" + birthday.Text + "', date_hired='" + dateHired.Text + "', salary='" + salary.Text + "' where cashier_id='" + cashierId.Text + "'", dbCon.getConnection());

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Cashier name updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                dbCon.closeConnection();
                firstName.Text = " ";
                lastName.Text = " ";
                contactNum.Text = "";
                birthday.Text = " ";    
                dateHired.Text = " ";   
                salary.Text = " ";  
                populate();
            }
        }



        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (contactNum.Text == string.Empty)
            {
                MessageBox.Show("Please fill Cashier field", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                dbCon.openConnection();
                SqlDataAdapter sda = new SqlDataAdapter("select cashier_id from cashierTable where cashier_id='" + cashierId.Text + "'", dbCon.getConnection());
                DataSet dataSet = new DataSet();
                sda.Fill(dataSet);

                if (dataSet.Tables[0].Rows.Count != 0)
                {
                    
                        if (MessageBox.Show("Do you want to delete this Cashier?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            SqlCommand cmd = new SqlCommand("delete from cashierTable where cashier_id='" + cashierId.Text + "'", dbCon.getConnection());
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Cashier deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    
                }
                dbCon.closeConnection();
                firstName.Text = " ";
                lastName.Text = " ";
                contactNum.Text = "";
                birthday.Text = " ";
                dateHired.Text = " ";
                salary.Text = " ";
                populate();
            }
        }

        private void viewDetailsButton_Click(object sender, EventArgs e)
        {
            if (dataGridview.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridview.SelectedRows[0];
                string firstName = row.Cells["first_name"].Value.ToString();
                string lastName = row.Cells["last_name"].Value.ToString();
                string contactNumber = row.Cells["contact_no"].Value.ToString();
                string birthday = row.Cells["birthday"].Value.ToString();
                string dateHired = row.Cells["date_hired"].Value.ToString();
                decimal salary = decimal.Parse(row.Cells["salary"].Value.ToString());
                CashierDetails detailsForm = new CashierDetails(firstName, lastName, contactNumber, birthday, dateHired, salary);
                detailsForm.ShowDialog();
            }

        }
        public void searchCashier(String searchValue)
        {
            dbCon.openConnection();
            SqlDataAdapter adapter = new SqlDataAdapter("select cashier_id, first_name, last_name, username, contact_no, birthday, date_hired, salary from cashierTable where concat(cashier_id, first_name, last_name, username, contact_no, birthday, date_hired, salary) LIKE '%" + searchBox.Text + "%'", dbCon.getConnection());
            DataTable newDataTable = new DataTable();
            adapter.Fill(newDataTable);
            dataGridview.DataSource = newDataTable;
            dbCon.closeConnection();
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            searchCashier(searchBox.Text);
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
