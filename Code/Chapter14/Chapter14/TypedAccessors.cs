using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DataReaderForms
{
    public partial class TypedAccessors : Form
    {
        public TypedAccessors()
        {
            InitializeComponent();
        }

        private void TypedAccessors_Load(object sender, EventArgs e)
        {
            // Connection string
            string connString = @"server=.\sql2012;database=AdventureWorks;Integrated Security=SSPI";

            // Query
            string sql = @"select CardType, CardNumber,ExpMonth,ExpYear from  Sales.CreditCard";

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

                // Fetch data
                while (rdr.Read())
                {
                    
                    // CardType
                    txtTypeAccess.AppendText(rdr.GetString(0).PadRight(30));
                    txtTypeAccess.AppendText("\t");
                    // CardNumber
                    txtTypeAccess.AppendText(rdr.GetString(1));
                    txtTypeAccess.AppendText("\t\t");
                    // ExpMonth
                    txtTypeAccess.AppendText(rdr.GetByte(2).ToString());
                    txtTypeAccess.AppendText("\t\t");
                    // ExpYear
                    txtTypeAccess.AppendText(rdr.GetInt16(3).ToString());
                    txtTypeAccess.AppendText("\n");
                }
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
