using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace DataSetandDataAdapter
{
    public partial class WriteXML : Form
    {
        public WriteXML()
        {
            InitializeComponent();
        }

        private void btnXML_Click(object sender, EventArgs e)
        {
            // Connection string
            string connString = @" server=.\sql2012; database=AdventureWorks;Integrated Security=true";
            
            // Query
            string qry = @"select Name ,ProductNumber
                           from Production.Product";

            // Create connection
            SqlConnection conn = new SqlConnection(connString);

            try
            {
                // Create Data Adapter
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = new SqlCommand(qry, conn);

                // Open connection
                conn.Open();

                // Create and Fill Dataset
                DataSet ds = new DataSet();
                da.Fill(ds, "Production.Product");

                // Extract dataset to XML file
                ds.WriteXml(@"c:\productstable.xml"); 

                MessageBox.Show("The XML file is Created");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }

            finally
            {
                // Connection close
                conn.Close();
            } 
        }
    }
}
