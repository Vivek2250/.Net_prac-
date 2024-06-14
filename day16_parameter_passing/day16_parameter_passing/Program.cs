using System.Data.SqlClient;

namespace day16_para_pass
{
    class program
    {
        public static void Main(string[] args)
        {
            string connectionString = ("Data Source=098C01D87E98538;Initial Catalog=Northwind;Integrated Security=true");

            ////Provide a query string with a parameter placeholder
            //string queryString =
            //    "Select ProductID, UnitPrice, ProductName from dbo.products " 
            //    + " Where UnitPrice > @pricePoint"
            //    + " Order By UnitPrice Desc";

            ////Specify the parameter value
            //int paraValue = 5;

            ////Create and open the connection in a using block.This 
            ////ensures that all resources will be closed and disposed 
            ////when the code exits.
            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{
            //    //Create the command and parameter
            //    SqlCommand command = new SqlCommand(queryString, connection);
            //    command.Parameters.AddWithValue("@pricePoint", paraValue);

            //    //open the connection in a try/catch block
            //    //create and execute the DataReader, writing the result
            //    //set the console window
            //    try
            //    {
            //        connection.Open();
            //        SqlDataReader reader = command.ExecuteReader();
            //        while (reader.Read())
            //        {
            //            Console.WriteLine("\t {0} \t {1} \t {2}",
            //                reader[0], reader[1], reader[2]);
            //        }
            //        reader.Close();
            //    }
            //    catch(Exception ex)
            //    {
            //        Console.WriteLine(ex.Message);
            //    }
            //    Console.ReadLine();
            //}

            //string queryString1 =
            //    "Select OrderID, CustomerID, EmployeeID from dbo.orders "
            //    + " Where ShipName = @shipName";

            //string paraValue1 = "Hanari Carnes";

            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{
            //    SqlCommand command = new SqlCommand(queryString1, connection);
            //    command.Parameters.AddWithValue("@shipName", paraValue1);

            //    try
            //    {
            //        connection.Open();
            //        SqlDataReader reader = command.ExecuteReader();
            //        while (reader.Read())
            //        {
            //            Console.WriteLine("\t {0} \t {1} \t {2}",
            //                reader[0], reader[1], reader[2]);
            //        }
            //        reader.Close();
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine(ex.Message);
            //    }
            //    Console.ReadLine();
            //}

            string queryString2 = "Select * from dbo.customers ";
                

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString2, connection);
                //command.ExecuteQuery();

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    Console.WriteLine("\t Contact Name \t City \t Company Name");
                    Console.WriteLine("\t ------------ \t ---- \t -------------");
                    
                    while (reader.Read())
                    {
                        Console.WriteLine("\t {0} \t {1} \t {2}",
                            reader[2], reader[5], reader[1]);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.ReadLine();
            }
        }
    }
}