using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExLab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // user name (text and spaces)
        private bool ValidUserName(string username)
        {
            Regex myRegex = new Regex(@"^([A-Z][a-z]+)\s([A-Z][a-z]+)$");
            return myRegex.IsMatch(username);
        }

        // address (numbers, text and spaces)
        private bool ValidAddress(string address)
        {
            Regex myRegex = new Regex(@"^(\d)+\s([a-zA-Z]+)\s([a-zA-Z0-9]+)$");
            return myRegex.IsMatch(address);
        }

        // city (text and spaces),
        private bool ValidCity(string city)
        {
            Regex myRegex = new Regex(@"^([A-Z][a-z]+)$|^([A-Z][a-z]+)\s([A-Z][a-z]+)$");
            return myRegex.IsMatch(city);
        }

        // province (text and spaces),
        private bool ValidProvince(string province)
        {
            Regex myRegex = new Regex(@"^([A-Z]{2})$");
            return myRegex.IsMatch(province);
        }

        // postal code (Uppercase letters, numbers and/or space or dash)
        private bool ValidPostalCode(string code)
        {
            Regex myRegex = new Regex(@"^([A-Z]\d[A-Z]\d[A-Z]\d)$|^(\d{5})$|^([0-9]{5}[\-][0-9]{3})$");
            return myRegex.IsMatch(code);
        }

        // telephone number (numbers and spaces or dashes)
        private bool ValidPhone(string phone)
        {
            Regex myRegex = new Regex(@"^(\d{3}[\-][\d]{3}[\-][\d]{4})$|^(\d{3}[\s][\d]{3}[\s][\d]{4})$");
            return myRegex.IsMatch(phone);
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo).ToString() == "Yes")
            {
                Close();
            }
        }


        private void confirm_Click(object sender, EventArgs e)
        {
            if (ValidUserName(boxName.Text) == false)
            {
                MessageBox.Show("Format incorrect for User Name. Must be 'Xxxx Xxxx'", "User name incorrect", MessageBoxButtons.OK);
                boxName.Focus();
            }
            if (ValidAddress(boxAddress.Text) == false)
            {
                MessageBox.Show("Format incorrect for address. Must be '000 Xxxx Xxxx'", "Address incorrect", MessageBoxButtons.OK);
                boxAddress.Focus();
            }
            if (ValidCity(boxCity.Text) == false)
            {
                MessageBox.Show("Format incorrect for city. Must be 'Xxxx' or 'Xxxx Xxxx'", "City incorrect", MessageBoxButtons.OK);
                boxCity.Focus();
            }
            if (ValidProvince(boxProvince.Text) == false)
            {
                MessageBox.Show("Format incorrect for province. Must be the abbreviation 'XX'", "Province incorrect", MessageBoxButtons.OK);
                boxProvince.Focus();
            } 
            if (ValidPostalCode(boxPostalcode.Text) == false)
            {
                MessageBox.Show("Format incorrect for postal code. Must be 'X0X0X0' or '00000' or '00000-000'", "Postal Code incorrect", MessageBoxButtons.OK);
                boxPostalcode.Focus();
            }
            if (ValidPhone(boxPhone.Text) == false)
            {
                MessageBox.Show("Format incorrect for phone. Must be 000-000-000 or 000 000 0000", "Phone incorrect", MessageBoxButtons.OK);
                boxPhone.Focus();
            } 
            else { 

                MessageBox.Show(string.Format(" Username: {0} \n Address: {1} \n City: {2} \n Province: {3} \n Postal Code: {4} \n Phone: {5}", boxName.Text, boxAddress.Text, boxCity.Text, boxProvince.Text, boxPostalcode.Text, boxPhone.Text));
            }
        }
    }

}
