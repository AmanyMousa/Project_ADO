using Microsoft.Data.SqlClient;
using project.data.Access;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Business
{
    public class UsersService
    {
        DBContext dbContext = new DBContext();
        //select
        public DataTable GetAllUsers()
        {
            string command = @"SELECT UserId,Username,Password, Email, Age,Address, Role FROM Users";
            return dbContext.Select(command);
        }
        //insert 

        public int ret(string username)
        {
            int userId = 0;
            string connectionString = "server=.;Database=Project;Trusted_Connection=true;Trust Server Certificate=true";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                
                    conn.Open();
                    string query = "SELECT UserId FROM Users WHERE Username = @Username";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);

                        object result = cmd.ExecuteScalar(); 
                        if (result != null)
                        {
                            userId = Convert.ToInt32(result); 
                        }
                    }
                


              
            }
            return userId;
        }
  public int AddUser(string username, string password, string email, int age, string address, string role )
        {
            string command = $@"INSERT INTO Users (Username, Password, Email, Age, Address, Role) 
            VALUES ('{username}', '{password}', '{email}', {age}, '{address}', '{role}')";

            return dbContext.ExecuteNonQuert(command);
        }

        //ubdate
        public int UpdateUser(int userId, string username, string password, string email, int age, string address, string role)
        {
            string command = $@"
            UPDATE Users 
            SET 
            Username = '{username}', 
            Password = '{password}', 
            Email = '{email}', 
            Age = {age}, 
            Address = '{address}', 
            Role = '{role}'
            WHERE UserId = {userId}";

            return dbContext.ExecuteNonQuert(command);
        }

        //delete
        public int Delete(int UserId)
        {
            string deleteFavoritesCommand = $"DELETE FROM Favorites WHERE UserId = {UserId}";
            dbContext.ExecuteNonQuert(deleteFavoritesCommand);


            string command = $"DELETE FROM Users WHERE UserId = {UserId}";

            return dbContext.ExecuteNonQuert(command);
        }

    }
}
