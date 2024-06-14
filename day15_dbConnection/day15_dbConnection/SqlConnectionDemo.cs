using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;

namespace day15_dbConnection
{
   public class Connection
    {
        SqlConnection conn;
        public Connection()
        {
            //1. Instantiate the connection
            conn = new SqlConnection("Data Source=098C01D87E98538;Initial Catalog=Northwind;Integrated Security=SSPI");
        }
        public void ReadData() { 

            SqlDataReader rdr = null;
            try
            {
                //2. Open the connection
                conn.Open();

                //3. Pass the connection to a command object
                SqlCommand cmd = new SqlCommand("Select CategoryName from Categories", conn);

                //4. Get query result
                rdr = cmd.ExecuteReader();

                //5. Print the customer ID of each record
                while (rdr.Read())
                    Console.WriteLine(rdr[0]);
            }

            catch
            {
                Console.WriteLine("There is an error occured!");
            }

            finally
            {
                if (rdr != null)
                    rdr.Close();

                if (conn != null)
                    conn.Close();
            }
        }

        public void InsertData()
        {
            SqlDataReader rdr = null;
            try
            {
                conn.Open();
                string insertData = @"insert into categories (CategoryName, Description) values ('Miscellaneous','Whatever does not fit else')";
                SqlCommand cmd = new SqlCommand(insertData, conn);

                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                    Console.WriteLine(rdr[0]);
            }

            catch
            {
                Console.WriteLine("There is an error occured!");
            }

            finally
            {
                if (rdr != null)
                    rdr.Close();

                if (conn != null)
                    conn.Close();
            }
        }

        public void UpdateData()
        {
            SqlDataReader rdr = null;
            try
            {
                conn.Open();
                string updateData = @"update Categories
                                      set CategoryName = 'Others'
                                      where CategoryName = 'Miscellaneous'";
                SqlCommand cmd = new SqlCommand(updateData, conn);

                cmd.ExecuteNonQuery();
            }

            catch
            {
                Console.WriteLine("There is an error occured!");
            }

            finally
            {
                if (rdr != null)
                    rdr.Close();

                if (conn != null)
                    conn.Close();
            }
        }

        public void DeleteData()
        {
            SqlDataReader rdr = null;
            try
            {
                conn.Open();
                string deleteData = @"delete from Categories
                                      where CategoryName = 'Others'";
                SqlCommand cmd = new SqlCommand(deleteData, conn);

                cmd.ExecuteNonQuery();
            }

            catch
            {
                Console.WriteLine("There is an error occured!");
            }

            finally
            {
                if (rdr != null)
                    rdr.Close();

                if (conn != null)
                    conn.Close();
            }
        }
    }
}
