using project.data.Access;
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

namespace Project.presentation
{
    public partial class User : Form
    {
        int id;
        public User()
        {
            InitializeComponent();
        }

        public User(int id)
        {
            this.id = id;
            InitializeComponent();
        }
        private void User_Load(object sender, EventArgs e)
        {
            btnAdd.Visible = false;
            btnremov.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnAdd.Visible = true;
            btnremov.Visible = false;
            ProductsService Products = new ProductsService();
            DataTable dataTable = Products.GettALL();

            dtgr.DataSource = dataTable;

        }

        private void btnremov_Click(object sender, EventArgs e)
        {
            string productName = "";
            if (dtgr.SelectedRows.Count > 0)
            {

                productName = dtgr.SelectedRows[0].Cells["ProductName"].Value.ToString();


            }


            FavoritesService favort = new FavoritesService();
            int productId = favort.GetProductIdByName(productName);

            int result = favort.Delete(id, productId);
            if (result > 0)
            {
                MessageBox.Show("Product delete successfully!");
                FavoritesService favort1 = new FavoritesService();
                DataTable dataTable = favort1.GettALL(id);
                dtgr.DataSource = dataTable;
            }
            else
            {
                MessageBox.Show("Failed to delete product.");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            btnAdd.Visible = false;
            btnremov.Visible = true;
            FavoritesService favort = new FavoritesService();
            DataTable dataTable = favort.GettALL(id);

            dtgr.DataSource = dataTable;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (dtgr.CurrentRow != null)
            {
                try
                {

                    int productId = Convert.ToInt32(dtgr.CurrentRow.Cells["ProductId"].Value);


                    FavoritesService favorites = new FavoritesService();
                    favorites.Add(id, productId);

                    MessageBox.Show("Product add successfully!");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("You Add this before .");
                }
            }
            else
            {
                MessageBox.Show("Please select a valid row.");
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Login logform= new Login();
            logform.Show();
            this.Hide();
        }
    }
}
