using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace DataReaderForms
{
    public partial class MultipleResults : Form
    {
        public MultipleResults()
        {
            InitializeComponent();
        }       

        private void MultipleResults_Load(object sender, EventArgs e)
        {
            // Connection string
            string connString = @"server=.\sql2012;database=AdventureWorks;Integrated Security=SSPI";

            // Query 1
            string sql1 = @"select CountryRegionCode,Name 
                            from Person.CountryRegion
                            where Name like 'A%' ";

            //Query2
            string sql2 = @"select FirstName, LastName
                            from Person.Contact";

            //Combining queries to produce multiple result set
            string sql = sql1 + sql2;

            // Create connection
            SqlConnection conn = new SqlConnection(connString);
            try
            {
                // Open connection
                conn.Open();

                // Create command
                SqlCommand cmd = new SqlCommand(sql, conn);

                // Create data reader
                SqlDataReader rdr = cmd.ExecuteReader();

                // Loop through result sets
                do
                {
                    txtResult.AppendText(rdr.GetName(0));
                    txtResult.AppendText("\t\t");
                    txtResult.AppendText(rdr.GetName(1));
                    txtResult.AppendText("\n");
                    txtResult.AppendText("".PadLeft(30, '='));
                    txtResult.AppendText("\n");                   
                   
                    while (rdr.Read())
                    {
                        // Print one row at a time
                        txtResult.AppendText(rdr[0].ToString());
                        txtResult.AppendText("\t\t\t");
                        txtResult.AppendText(rdr[1].ToString());
                        txtResult.AppendText("\n");                
                    }
                }
                while (rdr.NextResult());

                // Close data reader
                rdr.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace,"Exception Details");
            }
            finally
            {
                // Close connection
                conn.Close();
            }

        }
    }
}

