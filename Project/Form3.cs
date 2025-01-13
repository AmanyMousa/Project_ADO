using Project.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Registr : Form
    {
        public Registr()
        {
            InitializeComponent();
        }


        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtemail.Text))
            {
                MessageBox.Show("Please enter your email!" + MessageBoxButtons.OK);
                e.Cancel = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login loginform = new Login();
            loginform.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtname.Text;
            string password = txtpass.Text;
            string confirmPassword = txtconfpass.Text;
            string email = txtemail.Text;
            int age = 0;

            string address = txtaddress.Text;
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Please enter a username.");
                return;
            }

            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter a password.");
                return;
            }
            if (string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Please confirm your password.");
                return;
            }

            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please enter an email.");
                return;
            }

            if (string.IsNullOrEmpty(address))
            {
                MessageBox.Show("Please enter an address.");
                return;
            }
            if (password != confirmPassword)
            {
                MessageBox.Show("Password and Confpassord Not Equal.");
                return;
            }
            if (!int.TryParse(txtage.Text, out age))
            {
                MessageBox.Show("Please enter a valid age.");
                return;
            }

            string role = "User";
            try
            {
                UsersService usersService = new UsersService();


                int result = usersService.AddUser(username, password, email, age, address, role);


                if (result > 0)
                {
                    MessageBox.Show("Registration successful.");
                    Login loginform = new Login();
                    loginform.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Registration failed. Please try again.");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show($"You login with this befor ");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtpass.PasswordChar = '\0';
                txtconfpass.PasswordChar = '\0';
            }
            else
            {
                txtpass.PasswordChar = '*';
                txtconfpass.PasswordChar = '*';

            }
        }
    }
}
    
