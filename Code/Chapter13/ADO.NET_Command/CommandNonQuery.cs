using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace ADO.NET_Command
{
    public partial class CommandNonQuery : Form
    {
        public CommandNonQuery()
        {
            InitializeComponent();
        }

        private void btnInsertCurrency_Click(object sender, EventArgs e)
        {
            // Create connection
            SqlConnection conn = new SqlConnection(@"server = .\sql2012;
                                                    integrated security = true;
                                                    database = AdventureWorks");

            // Insert Query
            string sqlIns = "Insert Into Sales.Currency(CurrencyCode,Name,ModifiedDate)" +
                            "Values(" + "'" + txtCurrencyCode.Text + "','" + 
                                   txtName.Text + "','" + dtpModifiedDate.Value.ToString() + "')";

            // Create command 
            SqlCommand cmd = new SqlCommand(sqlIns, conn);

            try
            {
                // Open connection
                conn.Open();

                cmd.ExecuteNonQuery();

                lblInsertStatus.Text = "New Currency Added Successfully!!";
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
        
    }
}
