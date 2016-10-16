using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ADO.NET_Command
{
    public partial class CommandStoredProcedure : Form
    {
        public CommandStoredProcedure()
        {
            InitializeComponent();
        }

        private void btnLoadCurrency_Click(object sender, EventArgs e)
        {
            // Create connection
            SqlConnection conn = new SqlConnection(@"server = .\sql2012;
                                                    integrated security = true;
                                                    database = AdventureWorks");

            // Select query
            string sqlSelect = @"select CurrencyCode 
                                 from Sales.Currency";

            SqlCommand cmd = new SqlCommand(sqlSelect, conn);

            try
            {
                // Open connection
                conn.Open();
                // Execute query via ExecuteReader
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    lstCurrency.Items.Add(rdr[0]);
                }
            }

            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace, "Exception Details");
            }
            finally
            {
                conn.Close();
            }

        }

        private void btnDeleteCurrency_Click(object sender, EventArgs e)
        {
            // Create connection
            SqlConnection conn = new SqlConnection(@"server = .\sql2012;
                                                    integrated security = true;
                                                    database = AdventureWorks");

            // Create command object with Stored Procedure name
            SqlCommand cmd = new SqlCommand("sp_DeleteCurrency", conn);

            
            try
            {
                //Set command object for Stored Procedure execution
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("currCode", SqlDbType.NVarChar, 3));
                cmd.Parameters["currCode"].Value = lstCurrency.SelectedItem.ToString();

                // Open connection
                conn.Open();
                
                // Execute command associated with StoredProcedure                           
                cmd.ExecuteNonQuery();
                lblDeleteStatus.Text = "Currency is Deleted Successfully!!";
            }

            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace, "Exception Details");
            }

           catch (NullReferenceException ex)
           {
             MessageBox.Show("Either Load the list or Select a Currency in the list first" + ex.StackTrace, "Exception Details");
           }

            finally
            {
                conn.Close();
            }
        }
    }
}
