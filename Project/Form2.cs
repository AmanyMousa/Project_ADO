using Microsoft.Data.SqlClient;
using Microsoft.Win32;
using Project.Business;
using Project.presentation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Project
{

    public partial class Login : Form
    {
        public int lo;

        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Registr registrform = new Registr();
            registrform.Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtPass.PasswordChar = '\0';
            }
            else
            {
                txtPass.PasswordChar = '*';
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtname.Text;
            string password = txtPass.Text;
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
            string connectionString = "server=.;Database=Project;Trusted_Connection=true;Trust Server Certificate =true";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "select role from users where Username = @Username and Password = @Password";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Password", password);

                        object role = cmd.ExecuteScalar();
                        if (role != null && role.ToString() == "Admin")
                        {
                            Admin adminform = new Admin();
                            adminform.Show();
                            this.Hide();
                        }
                        else if (role != null && role.ToString() == "User")
                        {
                            UsersService user = new UsersService();



                            User us = new User(user.ret(username));
                            us.Show();




                            this.Hide();

                        }
                        else
                        {
                            MessageBox.Show("invalid password or username" + MessageBoxButtons.OK);

                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("error happend ");
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
