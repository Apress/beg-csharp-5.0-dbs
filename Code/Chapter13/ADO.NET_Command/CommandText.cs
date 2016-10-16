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
    public partial class CommandText : Form
    {
        public CommandText()
        {
            InitializeComponent();
        }

        private void CommandText_Load(object sender, EventArgs e)
        {
            // Create connection
            SqlConnection conn = new SqlConnection(@"server = .\sql2012;integrated security = true; database = AdventureWorks");

            // Create command
            SqlCommand cmd = new SqlCommand();
      
            try
            {
                // Open connection
                conn.Open();

                txtCommandText.AppendText("Connection opened \n" );
               
                txtCommandText.AppendText("Command created.\n");

                cmd.CommandText = @"select Name,ProductNumber
                                   from  Production.Product";

                txtCommandText.AppendText("Ready to execute SQL Statement: \n\t\t\t" + cmd.CommandText);
                
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace,"Exception Details");
            }
            finally
            {
                conn.Close();
                txtCommandText.AppendText("\nConnection Closed.");
            } 
        }
    }
}
