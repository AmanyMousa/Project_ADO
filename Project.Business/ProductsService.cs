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
    public class ProductsService
    {
        DBContext dbContext= new DBContext();
        

        //select
        public DataTable GettALL()
        {
            string command = @"
            SELECT 
            p.ProductId,
            p.ProductName,
            p.Price,
            p.CategoryId
            FROM Products as p";
            return dbContext.Select(command);
        }
       
        //insert
        public int Add(string productName, decimal price, int categoryId)
        {
            
            string command = $"INSERT INTO Products (ProductName, Price, CategoryId) VALUES ('{productName}', {price}, {categoryId})";

            return dbContext.ExecuteNonQuert(command);
        }


        //update
        public int Update(int productId, string productName, decimal price, int categoryId)
        {
            
            string command = $"UPDATE Products SET ProductName = '{productName}', Price = {price}, CategoryId = {categoryId} WHERE ProductId = {productId}";

            return dbContext.ExecuteNonQuert(command);
        }


        //delete
        public int Delete(int productId)
        {

            string deleteFavoritesCommand = $"DELETE FROM Favorites WHERE ProductId = {productId}";
            dbContext.ExecuteNonQuert(deleteFavoritesCommand);
            string command = $"DELETE FROM Products WHERE ProductId = {productId}";

            return dbContext.ExecuteNonQuert(command);
        }


    }
}
