using Microsoft.IdentityModel.Tokens;
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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Project.presentation
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            btnAddPro.Visible = false;
            btnDeletePro.Visible = false;
            btnUpdatePro.Visible = false;
            btnAddCat.Visible = false;
            btnDeleteCat.Visible = false;
            btnUpdateCat.Visible = false;
            btnAddUser.Visible = false;
            btnDeleteUser.Visible = false;
            btnUbdateUser.Visible = false;
            txtCatId.Visible = false;
            txtId.Visible = false;
            txtName.Visible = false;
            txtPrice.Visible = false;
            txtAge.Visible = false;
            txtAddress.Visible = false;
            comRole.Visible = false;
            labCatId.Visible = false;
            labId.Visible = false;
            labRole.Visible = false;
            labAdress.Visible = false;
            labAge.Visible = false;
            labName.Visible = false;
            labPrice.Visible = false;
            checkBox1.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtPrice.PasswordChar = '\0';
            btnAddPro.Visible = true;
            btnDeletePro.Visible = true;
            btnUpdatePro.Visible = true;
            btnAddCat.Visible = false;
            btnDeleteCat.Visible = false;
            btnUpdateCat.Visible = false;
            btnAddUser.Visible = false;
            btnDeleteUser.Visible = false;
            btnUbdateUser.Visible = false;
            txtCatId.Visible = true;
            txtCatId.Text = "";
            txtId.Visible = true;
            txtId.Text = "";
            txtName.Visible = true;
            txtName.Text = "";
            txtPrice.Visible = true;
            txtPrice.Text = "";
            txtAge.Visible = false;
            txtAddress.Visible = false;
            comRole.Visible = false;
            labCatId.Visible = true;
            labCatId.Text = "CategoryId";
            labId.Visible = true;
            labId.Text = "ProductId";
            labRole.Visible = false;
            labAdress.Visible = false;
            labAge.Visible = false;
            labName.Visible = true;
            labName.Text = "ProductName";
            labPrice.Visible = true;
            labPrice.Text = "Price";
            checkBox1.Visible = false;

            ProductsService Products = new ProductsService();
            DataTable dataTable = Products.GettALL();

            dtgr.DataSource = dataTable;

        }

        private void btnAddPro_Click(object sender, EventArgs e)
        {
            string productName = txtName.Text;
            decimal price = Convert.ToDecimal(txtPrice.Text);
            int categoryId = 0;

            if (!decimal.TryParse(txtPrice.Text, out price) && price <= 0)
            {
                MessageBox.Show("Please enter a valid price (greater than zero).");
                return;
            }

            if (string.IsNullOrEmpty(productName))
            {
                MessageBox.Show("Please enter a productName.");
                return;
            }
            if (!int.TryParse(txtCatId.Text, out categoryId))
            {
                MessageBox.Show("Please enter a valid age.");
                return;
            }
            ProductsService productsService = new ProductsService();


            int result = productsService.Add(productName, price, categoryId);


            if (result > 0)
            {
                MessageBox.Show("Product added successfully!");
                txtCatId.Text = "";
                txtId.Text = "";
                txtName.Text = "";
                txtPrice.Text = "";

                ProductsService Products = new ProductsService();
                DataTable dataTable = Products.GettALL();

                dtgr.DataSource = dataTable;
            }
            else
            {
                MessageBox.Show("Failed to add product.");
            }

        }


        private void dtgr_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {




            DataGridViewRow selectedRow;
            if (dtgr.SelectedRows.Count > 0)
            {
                selectedRow = dtgr.SelectedRows[0];
            }
            else
            {
                MessageBox.Show("No row is selected. Please select a row.");
                return;
            }

            try
            {
                if (btnAddPro.Visible)
                {


                    txtCatId.Text = selectedRow.Cells["CategoryId"].Value?.ToString();
                    txtId.Text = selectedRow.Cells["ProductId"].Value?.ToString();
                    txtName.Text = selectedRow.Cells["ProductName"].Value?.ToString();
                    txtPrice.Text = selectedRow.Cells["Price"].Value?.ToString();
                }
                else if (btnAddCat.Visible)
                {

                    txtId.Text = selectedRow.Cells["CategoryId"].Value?.ToString();
                    txtName.Text = selectedRow.Cells["CategoryName"].Value?.ToString();
                }
                else if (btnAddUser.Visible)
                {

                    txtId.Text = selectedRow.Cells["UserId"].Value?.ToString();
                    txtName.Text = selectedRow.Cells["Username"].Value?.ToString();
                    txtPrice.Text = selectedRow.Cells["Password"].Value?.ToString();
                    txtCatId.Text = selectedRow.Cells["Email"].Value?.ToString();
                    txtAge.Text = selectedRow.Cells["Age"].Value?.ToString();
                    txtAddress.Text = selectedRow.Cells["Address"].Value?.ToString();
                    comRole.SelectedItem = selectedRow.Cells["Role"].Value?.ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }





        private void btnUpdatePro_Click(object sender, EventArgs e)
        {
            int productId = 0;
            string productName = txtName.Text;
            decimal price = 0;
            int categoryId = 0;


            if (!int.TryParse(txtId.Text, out productId) || productId <= 0)
            {
                MessageBox.Show("Please enter a valid product ID.");
                return;
            }

            if (string.IsNullOrEmpty(productName))
            {
                MessageBox.Show("Please enter a product name.");
                return;
            }


            if (!decimal.TryParse(txtPrice.Text, out price) && price <= 0)
            {
                MessageBox.Show("Please enter a valid price (greater than zero).");
                return;
            }


            if (!int.TryParse(txtCatId.Text, out categoryId) || categoryId <= 0)
            {
                MessageBox.Show("Please enter a valid category ID.");
                return;
            }


            ProductsService productsService = new ProductsService();


            int result = productsService.Update(productId, productName, price, categoryId);


            if (result > 0)
            {
                MessageBox.Show("Product updated successfully!");
                txtCatId.Text = "";
                txtId.Text = "";
                txtName.Text = "";
                txtPrice.Text = "";
                ProductsService Products = new ProductsService();
                DataTable dataTable = Products.GettALL();

                dtgr.DataSource = dataTable;
            }
            else
            {
                MessageBox.Show("Failed to update product.");
            }
        }

        private void btnDeletePro_Click(object sender, EventArgs e)
        {

            int productId = 0;


            if (!int.TryParse(txtId.Text, out productId) || productId <= 0)
            {
                MessageBox.Show("Please enter a valid product ID.");
                return;
            }


            ProductsService productsService = new ProductsService();


            int result = productsService.Delete(productId);


            if (result > 0)
            {
                MessageBox.Show("Product deleted successfully!");
                txtCatId.Text = "";
                txtId.Text = "";
                txtName.Text = "";
                txtPrice.Text = "";

                ProductsService Products = new ProductsService();
                DataTable dataTable = Products.GettALL();

                dtgr.DataSource = dataTable;
            }
            else
            {
                MessageBox.Show("Failed to delete product.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //dtgr.Rows.Clear();
            txtPrice.PasswordChar = '\0';
            btnAddPro.Visible = false;
            btnDeletePro.Visible = false;
            btnUpdatePro.Visible = false;
            btnAddCat.Visible = true;
            btnDeleteCat.Visible = true;
            btnUpdateCat.Visible = true;
            btnAddUser.Visible = false;
            btnDeleteUser.Visible = false;
            btnUbdateUser.Visible = false;
            txtCatId.Visible = false;
            txtAge.Visible = false;
            txtAddress.Visible = false;
            comRole.Visible = false;
            txtPrice.Visible = false;
            labCatId.Visible = false;
            labRole.Visible = false;
            labAdress.Visible = false;
            labAge.Visible = false;
            labPrice.Visible = false;
            labId.Text = "CategoryId";
            labName.Text = "CategoryName";
            checkBox1.Visible = false;
            labId.Visible = true;
            labName.Visible = true;
            txtId.Visible = true;
            txtId.Text = "";
            txtName.Visible = true;
            txtName.Text = "";

            CategoriesService categoriestab = new CategoriesService();
            DataTable dataTable = categoriestab.GettALL();

            dtgr.DataSource = dataTable;
        }

        private void btnAddCat_Click(object sender, EventArgs e)
        {

            string categoryName = txtName.Text;


            if (string.IsNullOrEmpty(categoryName))
            {
                MessageBox.Show("Please enter a category name.");
                return;
            }


            CategoriesService categoriesService = new CategoriesService();


            int result = categoriesService.Add(categoryName);


            if (result > 0)
            {
                MessageBox.Show("Category added successfully!");
                txtId.Text = "";
                txtName.Text = "";

                CategoriesService categoriestab = new CategoriesService();
                DataTable dataTable = categoriestab.GettALL();

                dtgr.DataSource = dataTable;
            }
            else
            {
                MessageBox.Show("Failed to add category.");
            }

        }

        private void btnUpdateCat_Click(object sender, EventArgs e)
        {

            int categoryId = 0;
            string categoryName = txtName.Text;

            if (!int.TryParse(txtId.Text, out categoryId) || categoryId <= 0)
            {
                MessageBox.Show("Please enter a valid category ID.");
                return;
            }


            if (string.IsNullOrEmpty(categoryName))
            {
                MessageBox.Show("Please enter a category name.");
                return;
            }


            CategoriesService categoriesService = new CategoriesService();


            int result = categoriesService.Update(categoryId, categoryName);


            if (result > 0)
            {
                MessageBox.Show("Category updated successfully!");
                txtId.Text = "";
                txtName.Text = "";

                CategoriesService categoriestab = new CategoriesService();
                DataTable dataTable = categoriestab.GettALL();

                dtgr.DataSource = dataTable;
            }
            else
            {
                MessageBox.Show("Failed to update category.");
            }
        }


        private void btnDeleteCat_Click(object sender, EventArgs e)
        {

            int categoryId = 0;


            if (!int.TryParse(txtId.Text, out categoryId) || categoryId <= 0)
            {
                MessageBox.Show("Please enter a valid category ID.");
                return;
            }

            CategoriesService categoriesService = new CategoriesService();


            int result = categoriesService.Delete(categoryId);


            if (result > 0)
            {
                MessageBox.Show("Category deleted successfully!");
                txtId.Text = "";
                txtName.Text = "";

                CategoriesService categoriestab = new CategoriesService();
                DataTable dataTable = categoriestab.GettALL();

                dtgr.DataSource = dataTable;
            }
            else
            {
                MessageBox.Show("Failed to delete category.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //dtgr.Rows.Clear();
            checkBox1.Visible = true;
            btnAddPro.Visible = false;
            btnDeletePro.Visible = false;
            btnUpdatePro.Visible = false;
            btnAddCat.Visible = false;
            btnDeleteCat.Visible = false;
            btnUpdateCat.Visible = false;
            btnAddUser.Visible = true;
            btnDeleteUser.Visible = true;
            btnUbdateUser.Visible = true;
            labAdress.Visible = true;
            labAge.Visible = true;
            labRole.Visible = true;
            txtAge.Text = "";
            txtAge.Visible = true;
            txtAddress.Text = "";
            txtAddress.Visible = true;
            comRole.Visible = true;
            labName.Text = "Username";
            txtName.Text = "";
            txtName.Visible = true;
            labName.Visible = true;
            labPrice.Text = "Password";
            txtPrice.PasswordChar = '*';
            txtPrice.Text = "";
            txtPrice.Visible = true;
            labPrice.Visible = true;
            labCatId.Text = "Email";
            txtCatId.Text = "";
            txtCatId.Visible = true;
            labCatId.Visible = true;
            labId.Text = "UserId";
            labId.Visible = true;
            txtId.Visible = true;
            txtId.Text = "";

            UsersService user = new UsersService();
            DataTable dataTable = user.GetAllUsers();
            dtgr.DataSource = dataTable;
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {

            string username = txtName.Text;
            string password = txtPrice.Text;
            string email = txtCatId.Text;
            int age = 0;
            string address = txtAddress.Text;
            string role = comRole.SelectedItem?.ToString();


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

            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please enter an email.");
                return;
            }

            if (!int.TryParse(txtAge.Text, out age) || age <= 0)
            {
                MessageBox.Show("Please enter a valid age.");
                return;
            }

            if (string.IsNullOrEmpty(address))
            {
                MessageBox.Show("Please enter an address.");
                return;
            }

            if (string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Please select a role.");
                return;
            }


            UsersService usersService = new UsersService();


            int result = usersService.AddUser(username, password, email, age, address, role);


            if (result > 0)
            {
                MessageBox.Show("User added successfully!");
                txtCatId.Text = "";
                txtId.Text = "";
                txtName.Text = "";
                txtPrice.Text = "";
                txtId.Text = "";
                txtName.Text = "";
                UsersService user = new UsersService();
                DataTable dataTable = user.GetAllUsers();
                dtgr.DataSource = dataTable;

            }
            else
            {
                MessageBox.Show("Failed to add user.");
            }
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {

            int userId = 0;
            if (!int.TryParse(txtId.Text, out userId) || userId <= 0)
            {
                MessageBox.Show("Please enter a valid User ID.");
                return;
            }


            string username = txtName.Text;
            string password = txtPrice.Text;
            string email = txtCatId.Text;
            int age = 0;
            string address = txtAddress.Text;
            string role = comRole.SelectedItem?.ToString();

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

            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please enter an email.");
                return;
            }

            if (!int.TryParse(txtAge.Text, out age) || age <= 0)
            {
                MessageBox.Show("Please enter a valid age.");
                return;
            }

            if (string.IsNullOrEmpty(address))
            {
                MessageBox.Show("Please enter an address.");
                return;
            }

            if (string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Please select a role.");
                return;
            }


            UsersService usersService = new UsersService();


            int result = usersService.UpdateUser(userId, username, password, email, age, address, role);


            if (result > 0)
            {
                MessageBox.Show("User updated successfully!");
                txtCatId.Text = "";
                txtId.Text = "";
                txtName.Text = "";
                txtPrice.Text = "";
                txtId.Text = "";
                txtName.Text = "";
                UsersService user = new UsersService();
                DataTable dataTable = user.GetAllUsers();
                dtgr.DataSource = dataTable;
            }
            else
            {
                MessageBox.Show("Failed to update user.");
            }

        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            try
            {
                int userId = 0;


                if (!int.TryParse(txtId.Text, out userId) && userId <= 0)
                {
                    MessageBox.Show("Please enter a valid category ID.");
                    return;
                }

                UsersService users = new UsersService();


                int result = users.Delete(userId);

                if (result > 0)
                {
                    MessageBox.Show("User deleted successfully!");
                    txtCatId.Text = "";
                    txtId.Text = "";
                    txtName.Text = "";
                    txtPrice.Text = "";
                    txtId.Text = "";
                    txtName.Text = "";
                    UsersService user = new UsersService();
                    DataTable dataTable = user.GetAllUsers();
                    dtgr.DataSource = dataTable;
                }
                else
                {
                    MessageBox.Show("Failed to delete user.");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"An error occurred: {ex.Message}\n{ex.StackTrace}");
            }
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Login loginform = new Login();
            loginform.Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtPrice.PasswordChar = '\0';
            }
            else
            {
                txtPrice.PasswordChar = '*';
            }
        }
    }
}
