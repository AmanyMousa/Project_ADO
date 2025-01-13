using Microsoft.Data.SqlClient;
using project.data.Access;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Business
{
    public class FavoritesService
    {
        DBContext dbContext = new DBContext();
        //select
        public DataTable GettALL(int userId)
        {
            string command = $" SELECT p.ProductName FROM Products AS p INNER JOIN Favorites AS f ON p.ProductId = f.ProductId WHERE f.UserId = {userId}";
            return dbContext.Select(command);


        }




        //insert
        public int Add(int userId, int productId)
        {
            string command = $"insert into Favorites values ({userId},{productId})";

            return dbContext.ExecuteNonQuert(command);
        }

        //delete
        public int Delete(int UsertId, int productId)
        {

            string command = $"DELETE FROM Favorites   WHERE UserId = {UsertId} and ProductId={productId} ";

            return dbContext.ExecuteNonQuert(command);
        }
        public int GetProductIdByName(string productName)
        {
            int productId = -1;

            string connectionString = "server=.;Database=Project;Trusted_Connection=true;Trust Server Certificate=true";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();


                string query = "SELECT ProductId FROM Products WHERE ProductName = @productName";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {

                    cmd.Parameters.AddWithValue("@productName", productName);

                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        productId = Convert.ToInt32(result);
                    }
                }
            }

            return productId;
        }


    }
}
