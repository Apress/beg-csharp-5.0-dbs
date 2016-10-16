﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace ADO.NET_Command
{
    public partial class CommandScalar : Form
    {
        public CommandScalar()
        {
            InitializeComponent();
        }        

        private void btnRowCount_Click(object sender, EventArgs e)
        {
            // Create connection
            SqlConnection conn = new SqlConnection(@"server = .\sql2012;
                                                    integrated security = true;
                                                    database = AdventureWorks");

            // Create Scalar query
            string sql = @"select count(*) 
                           from Production.Product";

            // Create command 
            SqlCommand cmd = new SqlCommand(sql, conn);
            txtScalar.AppendText("Command created and connected.\n");

            try
            {
                // Open connection
                conn.Open();

                txtScalar.AppendText("Number of Product is :");

                // Execute Scalar query with ExecuteScalar method
                txtScalar.AppendText(cmd.ExecuteScalar().ToString());
                txtScalar.AppendText("\n");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace, "Exception Details");
            }
            finally
            {
                conn.Close();
                txtScalar.AppendText("Connection Closed.");
            } 
        }
    }
}
