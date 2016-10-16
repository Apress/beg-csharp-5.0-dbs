using System;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient; 

namespace DataReaderForms
{
    public partial class DataLooper : Form
    {
        public DataLooper()
        {
            InitializeComponent();
        }

        private void DataLooper_Load(object sender, EventArgs e)
        {
            // Connection string
            string connString = @"server=.\sql2012;database=AdventureWorks;Integrated Security=SSPI";
            
            // Query
            string sql = @"select Name from Production.Product";  

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

                // Loop through result set
                while (rdr.Read())
                {
                    // Print one row at a time
                    lbxProduct.Items.Add(rdr[0]);
                }

                // Close data reader
                rdr.Close();
            }

            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            
            finally
            {
                conn.Close();
            } 
        }
    }
}
