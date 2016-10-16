using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient ;
using System.Text;
using System.Windows.Forms;

namespace ADO.NET_Command
{
    public partial class CommandReader : Form
    {
        public CommandReader()
        {
            InitializeComponent();
        }

        private void CommandReader_Load(object sender, EventArgs e)
        {
            // Create connection
            SqlConnection conn = new SqlConnection(@"
                                 server = .\sql2012;
                                 integrated security = true;
                                 database = AdventureWorks");

            // Create command
            string sql = @"select Name,ProductNumber
                          from Production.Product";

            SqlCommand cmd = new SqlCommand(sql, conn);
            txtReader.AppendText("Command created and connected.\n\n");

            try
            {
                // Open connection
                conn.Open();

                // Execute query via ExecuteReader
                SqlDataReader rdr = cmd.ExecuteReader();
               
                while (rdr.Read())
                {
                    txtReader.AppendText("\nProduct: ");
                    txtReader.AppendText(rdr.GetValue(1) + "\t\t" + rdr.GetValue(0));
                    txtReader.AppendText("\n");
                }
            }

            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace, "Exception Details");
            }

            finally
            {
                conn.Close();
                txtReader.AppendText("Connection Closed.");
            } 
        }
    }
}
