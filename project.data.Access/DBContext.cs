using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.data.Access
{
   
    public class DBContext
    {
        SqlConnection con= new SqlConnection("server=.;Database=project;Trusted_Connection=true;Trust Server Certificate =true");


        //   Select Function
        public DataTable Select(string commendText)
        {
            //disconnectedMode
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dt = new DataTable();

            //define command 
            SqlCommand command = new SqlCommand(commendText, con);
            adapter.SelectCommand = command;
            dt.Clear();
            adapter.Fill(dt);
            return dt;


        }


        // insert update delete 

        public int ExecuteNonQuert(string commandText)
        {
            SqlCommand command = new SqlCommand(commandText, con);
            int rowsAffected = -1;
            try
            {
                con.Open();
                rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("You  did it before");
            }
            finally
            {
                con.Close();
            }
            

            return rowsAffected;


        }













    }

}
