using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SplashScreenLadera
{
    public partial class CashierDetails : Form
    {
        public CashierDetails(string firstName, string lastName, string contactNumber, string birthday, string dateHired, decimal salary)
        {
            InitializeComponent();
            this.fname.Text = firstName;
            this.lname.Text = lastName;
            this.contactno.Text = contactNumber;
            this.bday.Text = birthday;
            this.date.Text = dateHired;
            this.salary.Text = salary.ToString("C");


        }
    }
}
