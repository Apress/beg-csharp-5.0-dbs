using System;
using System.Data;
using System.Data.SqlClient;

namespace Chapter12
{
    class ConnectionDisplay
    {
        static void Main()
        {
            // Create connection
            SqlConnection conn = new SqlConnection(@"server = .\sql2012; 
                  integrated security = true;");

            try
            {
                // Open connection
                conn.Open();
                Console.WriteLine("Connection opened.");

                // Display connection properties
                Console.WriteLine("Connection Properties:");
                Console.WriteLine("\tConnection String: {0}", conn.ConnectionString);
                Console.WriteLine("\tDatabase: {0}",conn.Database);
                Console.WriteLine("\tDataSource: {0}",conn.DataSource);
                Console.WriteLine("\tServerVersion: {0}",conn.ServerVersion);
                Console.WriteLine("\tState: {0}",conn.State);
                Console.WriteLine("\tWorkstationId: {0}",conn.WorkstationId);
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
 
