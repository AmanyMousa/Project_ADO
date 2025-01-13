using project.data.Access;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Business
{
    
    public class CategoriesService
    {

        DBContext dbContext = new DBContext();
        //select
        public DataTable GettALL()
        {
            string command = "select CategoryId , CategoryName from Categories";
            return dbContext.Select(command);
        }
        //insert
        public int Add(string categoryName)
        {
            string command = $"INSERT INTO Categories (CategoryName) VALUES ('{categoryName}')";
            return dbContext.ExecuteNonQuert(command);
        }

        //update
        public int Update(int categoryId, string categoryName)
        {
            string command = $"UPDATE Categories SET CategoryName = '{categoryName}' WHERE CategoryId = {categoryId}";
            return dbContext.ExecuteNonQuert(command);
        }

        //delete
        public int Delete(int categoryId)
        {
        
            
            string deleteProductsCommand = $"DELETE FROM Products WHERE CategoryId = {categoryId}";
            dbContext.ExecuteNonQuert(deleteProductsCommand);

            
            string deleteCategoryCommand = $"DELETE FROM Categories WHERE CategoryId = {categoryId}";
            return dbContext.ExecuteNonQuert(deleteCategoryCommand);
        
        }





    }
}

