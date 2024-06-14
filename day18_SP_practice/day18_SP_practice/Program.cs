using System.Data.SqlClient;
using System;
using System.Data;

namespace AdoNetExample
{
    class CasllSP
    {
        public static void Main(string[] args)
        {
            string connectionString = "Data Source=098C01D87E98538;Initial Catalog=Example;Integrated Security=true";

            //calling Inserting Procedure
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("INSERTING", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        //Add parameters for the stored procedure
                        command.Parameters.AddWithValue("@FirstName", "Monkey");
                        command.Parameters.AddWithValue("@LastName", "Luffy");
                        command.Parameters.AddWithValue("@JobTitle", "Pirate");
                        command.Parameters.AddWithValue("@HireDate", "1990-01-01");

                        int rowsAffected = command.ExecuteNonQuery();
                        Console.WriteLine($"Rows Affected : {rowsAffected}");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    connection.Close();
                }

            }

            //calling updating procedure
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("UPDATING", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        //Add parameters for the stored procedure
                        command.Parameters.AddWithValue("EmployeeID", 2);
                        command.Parameters.AddWithValue("@FirstName", "Monkey");
                        command.Parameters.AddWithValue("@LastName", "Garp");
                        command.Parameters.AddWithValue("@JobTitle", "Marine");
                        command.Parameters.AddWithValue("@HireDate", "1976-01-01");

                        int rowsAffected = command.ExecuteNonQuery();
                        Console.WriteLine($"Rows Affected : {rowsAffected}");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    connection.Close();
                }

            }

            //calling reading procedure using DataSet
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("readTable", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        SqlDataAdapter adapter = new SqlDataAdapter(command);

                        // Create DataSet to hold the data
                        DataSet dataSet = new DataSet();

                        // Fill the DataSet with data from the stored procedure
                        adapter.Fill(dataSet);

                        // Check if the DataSet contains any tables
                        if (dataSet.Tables.Count > 0)
                        {
                            // Retrieve the first table from the DataSet
                            DataTable dataTable = dataSet.Tables[0];

                            // Iterate through each row in the table
                            foreach (DataRow row in dataTable.Rows)
                            {
                                // Read data from the row
                                string firstName = row["FirstName"].ToString();
                                string lastName = row["LastName"].ToString();
                                string jobTitle = row["JobTitle"].ToString();
                                DateTime hireDate = Convert.ToDateTime(row["HireDate"]);

                                // Process the data (you can print or use it as needed)
                                Console.WriteLine($"FirstName: {firstName}, LastName: {lastName}, JobTitle: {jobTitle}, HireDate: {hireDate}");
                            }

                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
                //calling deleting procedure 
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand("DELETING", connection))
                        {
                            command.CommandType = CommandType.StoredProcedure;

                            //Add parameters for the stored procedure
                            command.Parameters.AddWithValue("EmployeeID", 3);
                          
                            int rowsAffected = command.ExecuteNonQuery();
                            Console.WriteLine($"Rows Affected : {rowsAffected}");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    finally
                    {
                        connection.Close();
                    }
                 }

            //calling reading procedure using DataReader
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    int EmployeeID = 12;
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("READING", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@EmployeeID", EmployeeID);

                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                Console.WriteLine($"{reader[1]}\t {reader[2]}\t {reader[3]}\t {reader[4]}");
                            }
                        }

                        reader.Close();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }
    }
}