using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;

namespace SplashScreenLadera
{
    public partial class BackupManagement : Form
    {
        public BackupManagement()
        {
            InitializeComponent();
        }

        Connection dbCon = new Connection();

        private void locationButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Backup Files (*.bak)|*.bak";
            saveFileDialog.FileName = "littlekoreabackup.bak";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                pathField.Text = saveFileDialog.FileName;
            }
        }

        private void backupButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (pathField.Text == string.Empty)
                {
                    MessageBox.Show("Please select a file path.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //change this
                    string dbName = @"D:\VISUALPROJECTS\IPT\SPLASHSCREEN\SAMPLEDB.MDF";
                    dbCon.openConnection();
                    string query = "backup database "+'"'+ dbName +'"'+" to disk = '" + pathField.Text +"'";
                    SqlCommand cmd = new SqlCommand(query, dbCon.getConnection());

                    cmd.ExecuteNonQuery();

                    dbCon.closeConnection();

                    MessageBox.Show("Database backup successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    pathField.Text = "";
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
