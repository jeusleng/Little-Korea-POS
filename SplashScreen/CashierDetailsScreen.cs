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

namespace SplashScreenLadera
{
    public partial class CashierDetailsScreen : Form
    {
        Connection dbCon = new Connection();

        // Properties to store the values passed from the CashierManagement form
        public string CashierId
        {
            get { return cashierId.Text; }
            set { cashierId.Text = value; }
        }

        public string FirstName
        {
            get { return fnameField.Text; }
            set { fnameField.Text = value; }
        }

        public string LastName
        {
            get { return lnameField.Text; }
            set { lnameField.Text = value; }
        }

        public string ContactNumber
        {
            get { return contactNumField.Text; }
            set { contactNumField.Text = value; }
        }

        public string Birthday
        {
            get { return bdayField.Text; }
            set { bdayField.Text = value; }
        }

        public string DateHired
        {
            get { return hiredField.Text; }
            set { hiredField.Text = value; }
        }

        public decimal Salary
        {
            get { return decimal.Parse(salaryAmountField.Text); }
            set { salaryAmountField.Text = value.ToString(); }
        }


        public CashierDetailsScreen()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fnameField_TextChanged(object sender, EventArgs e)
        {

        }

        private void lnameField_TextChanged(object sender, EventArgs e)
        {

        }

        private void contactNumField_TextChanged(object sender, EventArgs e)
        {

        }

        private void bdayField_TextChanged(object sender, EventArgs e)
        {

        }

        private void hiredField_TextChanged(object sender, EventArgs e)
        {

        }

        private void salaryAmountField_TextChanged(object sender, EventArgs e)
        {

        }

        public event EventHandler CashierUpdated;


        private void updateButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CashierId) || string.IsNullOrEmpty(FirstName) || string.IsNullOrEmpty(LastName) ||
                string.IsNullOrEmpty(ContactNumber) || string.IsNullOrEmpty(Birthday) || string.IsNullOrEmpty(DateHired) ||
                Salary == 0)
            {
                MessageBox.Show("Please fill out all fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                dbCon.openConnection();

                SqlDataAdapter sda = new SqlDataAdapter("SELECT cashier_id FROM cashierTable WHERE cashier_id = @cashierId", dbCon.getConnection());
                sda.SelectCommand.Parameters.AddWithValue("@cashierId", CashierId);

                DataTable dataTable = new DataTable();
                sda.Fill(dataTable);

                if (dataTable.Rows.Count != 0)
                {
                    SqlCommand cmd = new SqlCommand("UPDATE cashierTable SET first_name = @firstName, last_name = @lastName, contact_no = @contactNumber, birthday = @birthday, date_hired = @dateHired, salary = @salary WHERE cashier_id = @cashierId", dbCon.getConnection());
                    cmd.Parameters.AddWithValue("@firstName", FirstName);
                    cmd.Parameters.AddWithValue("@lastName", LastName);
                    cmd.Parameters.AddWithValue("@contactNumber", ContactNumber);
                    cmd.Parameters.AddWithValue("@birthday", Birthday);
                    cmd.Parameters.AddWithValue("@dateHired", DateHired);
                    cmd.Parameters.AddWithValue("@salary", Salary);
                    cmd.Parameters.AddWithValue("@cashierId", CashierId);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Cashier details updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CashierUpdated?.Invoke(this, EventArgs.Empty);

                }
                else
                {
                    MessageBox.Show("Cashier not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating.");
            }

            // Clear the field values
            FirstName = string.Empty;
            LastName = string.Empty;
            ContactNumber = string.Empty;
            Birthday = string.Empty;
            DateHired = string.Empty;
            Salary = 0;
            cashierId.Text = string.Empty;
        }



        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CashierId))
            {
                MessageBox.Show("Please provide a cashier ID.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                dbCon.openConnection();

                SqlDataAdapter sda = new SqlDataAdapter("SELECT cashier_id FROM cashierTable WHERE cashier_id = @cashierId", dbCon.getConnection());
                sda.SelectCommand.Parameters.AddWithValue("@cashierId", CashierId);

                DataTable dataTable = new DataTable();
                sda.Fill(dataTable);

                if (dataTable.Rows.Count != 0)
                {
                    DialogResult result = MessageBox.Show("Do you want to delete this Cashier?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        SqlCommand deleteCashierCmd = new SqlCommand("DELETE FROM cashierTable WHERE cashier_id = @cashierId", dbCon.getConnection());
                        deleteCashierCmd.Parameters.AddWithValue("@cashierId", CashierId);
                        deleteCashierCmd.ExecuteNonQuery();

                        SqlCommand deleteUserCmd = new SqlCommand("DELETE FROM usersTable WHERE username = @username", dbCon.getConnection());
                        deleteUserCmd.Parameters.AddWithValue("@username", CashierId);
                        deleteUserCmd.ExecuteNonQuery();

                        MessageBox.Show("Cashier deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CashierUpdated?.Invoke(this, EventArgs.Empty);
                    }
                }
                else
                {
                    MessageBox.Show("Cashier not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while deleting the cashier.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            dbCon.closeConnection();

            // Clear the field values
            FirstName = string.Empty;
            LastName = string.Empty;
            ContactNumber = string.Empty;
            Birthday = string.Empty;
            DateHired = string.Empty;
            Salary = 0;
            cashierId.Text = string.Empty;
        }



    }
}