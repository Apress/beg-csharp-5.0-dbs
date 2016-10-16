﻿using System;
using System.Data;
using System.Linq;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DataReaderForms
{
    public partial class ResultSetInfo : Form
    {
        public ResultSetInfo()
        {
            InitializeComponent();
        }

        private void ResultSetInfo_Load(object sender, EventArgs e)
        {
            // Connection string
            string connString = @"server=.\sql2012;database=AdventureWorks;Integrated Security=SSPI";
            
            // Query 
            string sql = @" select FirstName,LastName from Person.Contact
                             order by LastName";

            // Create connection
            SqlConnection conn = new SqlConnection(connString);

            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataReader rdr = cmd.ExecuteReader();

                // Get column names
                lbltype1.Text = rdr.GetName(0);
                lblType2.Text = rdr.GetName(1);

                //Get column data types
                lbltype1.Text += "\n"+  rdr.GetDataTypeName(0).ToString();
                lblType2.Text += "\n"+ rdr.GetDataTypeName(1).ToString();

                // Get number of columns
                lblType3.Text = "Number of columns in a row::" + rdr.FieldCount.ToString();

                // Get info about each column 
                lblType4.Text = rdr.GetName(0).ToString() + " is at index::" + 
                                rdr.GetOrdinal("FirstName").ToString()  +
                                " and its type is::" + rdr.GetFieldType(0).ToString();
                
                lblType5.Text = rdr.GetName(1).ToString() + " is at index:: "+ 
                               rdr.GetOrdinal("LastName").ToString()  + 
                               " and its type is::" + rdr.GetFieldType(1).ToString();

                while (rdr.Read())
                {
                  // Get column values for all rows
                    txtResultSet.AppendText("\t");
                    txtResultSet.AppendText(rdr[0].ToString());
                    txtResultSet.AppendText("\t\t\t");  
                    txtResultSet.AppendText(rdr[1].ToString() );
                    txtResultSet.AppendText("\n");  
                }
                
                //Close reader
                rdr.Close();

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace,"Exception Details");
            }
            
            finally
            {
                //Clsoe connection
                conn.Close();
            } 
        }
      
    }
}
