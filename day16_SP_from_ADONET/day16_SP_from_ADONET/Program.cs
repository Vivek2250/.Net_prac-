using System.Data.SqlClient;
using System;
using System.Data;

namespace AdoNetExample
{
    class CasllSP
    {
        public static void Main(string[] args)
        {
            string connectionString = "Data Source=098C01D87E98538;Initial Catalog=Northwind;Integrated Security=true";
            string customerId = "ALFKI";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using(SqlCommand command = new SqlCommand("CustOrderHist", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@CustomerID", customerId);

                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            string productName = reader["ProductName"].ToString();
                            int totalOrders = (int)reader["Total"];


                            Console.WriteLine($"Product Name: {productName}, Total Orders: {totalOrders}");
                        }

                    }

                    else
                    {
                        Console.WriteLine("No data found for the specified customer");
                    }

                    reader.Close();
                    connection.Close();
                }
            }
        }
    }
}
