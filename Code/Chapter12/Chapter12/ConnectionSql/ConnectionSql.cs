using System;
using System.Data;
using System.Data.SqlClient;

namespace Chapter12
{
    class ConnectionSql
    {
        static void Main(string[] args)
        {
            // Connection string
            string connString = @"addr = .\sql2012; integrated security = true;";

            // Create connection
            SqlConnection conn = new SqlConnection(connString);

            try
            {
                // Open connection
                conn.Open();
                Console.WriteLine("Connection opened.");
            }
            catch (SqlException ex)
            {
                // Display error
                Console.WriteLine("Error: " + ex.Message + ex.StackTrace);
            }
            finally
            {
                // Close connection
                conn.Close();
                Console.WriteLine("Connection closed.");
            }

            Console.ReadLine();
        }
    }
}
