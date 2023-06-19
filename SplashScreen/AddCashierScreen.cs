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
    public partial class AddCashierScreen : Form
    {
        Connection dbCon = new Connection();
        public event EventHandler CashierAdded;



        public AddCashierScreen()
        {
            InitializeComponent();
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(fnameField.Text) || string.IsNullOrEmpty(lnameField.Text) ||
                string.IsNullOrEmpty(contactNumField.Text) || string.IsNullOrEmpty(bdayField.Text) ||
                string.IsNullOrEmpty(hiredField.Text) || string.IsNullOrEmpty(salaryAmountField.Text))
            {
                MessageBox.Show("Please fill out all fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                dbCon.openConnection();

                // Insert the cashier account in the usersTable
                string password = GeneratePassword(8);
                string query1 = "INSERT INTO usersTable (username, password, role, status) VALUES (@username, @password, 'Cashier', 'Active')";
                SqlCommand cmd1 = new SqlCommand(query1, dbCon.getConnection());
                cmd1.Parameters.AddWithValue("@username", fnameField.Text);
                cmd1.Parameters.AddWithValue("@password", password);
                cmd1.ExecuteNonQuery();

                int userId = 0;

                // Retrieve the user_id of the new cashier
                string query2 = "SELECT user_id FROM usersTable WHERE username = @username";
                SqlCommand cmd2 = new SqlCommand(query2, dbCon.getConnection());
                cmd2.Parameters.AddWithValue("@username", fnameField.Text);
                using (SqlDataReader reader = cmd2.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        userId = reader.GetInt32(0);
                    }
                }

                decimal salary;
                if (decimal.TryParse(salaryAmountField.Text, out salary))
                {
                    // Insert the cashier information and user_id in the cashierTable
                    string query3 = "INSERT INTO cashierTable (first_name, last_name, contact_no, birthday, date_hired, salary, user_id) " +
                        "VALUES (@firstName, @lastName, @contactNumber, @birthday, @dateHired, @salary, @userId)";
                    SqlCommand cmd3 = new SqlCommand(query3, dbCon.getConnection());
                    cmd3.Parameters.AddWithValue("@firstName", fnameField.Text);
                    cmd3.Parameters.AddWithValue("@lastName", lnameField.Text);
                    cmd3.Parameters.AddWithValue("@contactNumber", contactNumField.Text);
                    cmd3.Parameters.AddWithValue("@birthday", bdayField.Text);
                    cmd3.Parameters.AddWithValue("@dateHired", hiredField.Text);
                    cmd3.Parameters.AddWithValue("@salary", salary);
                    cmd3.Parameters.AddWithValue("@userId", userId);
                    cmd3.ExecuteNonQuery();

                    MessageBox.Show("Cashier added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CashierAdded?.Invoke(this, EventArgs.Empty);
                }
                else
                {
                    MessageBox.Show("Invalid salary value. Please enter a valid decimal number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while adding the cashier: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            dbCon.closeConnection();

            // Clear the field values
            fnameField.Text = string.Empty;
            lnameField.Text = string.Empty;
            contactNumField.Text = string.Empty;
            bdayField.Text = string.Empty;
            hiredField.Text = string.Empty;
            salaryAmountField.Text = string.Empty;
        }

        // Generate a random password of a specified length
        private string GeneratePassword(int length)
        {
            const string validChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder password = new StringBuilder();
            Random random = new Random();

            while (0 < length--)
            {
                password.Append(validChars[random.Next(validChars.Length)]);
            }

            return password.ToString();
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

        private void cashierId_TextChanged(object sender, EventArgs e)
        {

        }

        private void fnameField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Cancels the keypress event
            }

        }

        private void lnameField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Cancels the keypress event
            }

        }

        private void contactNumField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Cancels the keypress event
            }
        }

        private void salaryAmountField_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is a digit, decimal point, or control key
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Ignore the key press
            }

            // Allow only one decimal point
            if (e.KeyChar == '.' && ((Guna2TextBox)sender).Text.Contains("."))
            {
                e.Handled = true; // Ignore the key press
            }
        }
    }
}
