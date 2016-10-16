using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace DataSetandDataAdapter
{
    public partial class FilterSort : Form
    {
        public FilterSort()
        {
            InitializeComponent();
        }

        private void FilterSort_Load(object sender, EventArgs e)
        {
            // Connection string
            string connString = @"server=.\sql2012; database=AdventureWorks; Integrated Security=true";

            // Query1 
            string sql1 = @" select *
                           from Production.Product
                           where Name Like 'Mountain%'";

            // Query2 
            string sql2 = @" select *
                           from Production.Location
                           where CostRate > 10.0 ";

            // Combine queries
            string sql = sql1 + sql2;

            // Create connection
            SqlConnection conn = new SqlConnection(connString);

            try
            {
                // Create Data Adapter
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = new SqlCommand(sql, conn);

                // Create and Fill Data Set
                DataSet ds = new DataSet();
                da.Fill(ds, "Production.Product");

                // Get the data tables collection
                DataTableCollection dtc = ds.Tables;

                // Display data from first data table
                //
                // Display output header
                txtSort.AppendText("Results from Product table:\n");
                txtSort.AppendText("***************************************************\n");
                txtSort.AppendText("Name\t\t\t\tProductNumber\n");

                txtSort.AppendText("_________________________________________\n");
                // set display filter
                string fl = "Color = 'Black'";

                // Set sort
                string srt = "ProductNumber asc";

                // display filtered and sorted data
                foreach (DataRow row in dtc["Production.Product"].Select(fl, srt))
                {
                    txtSort.AppendText(row["Name"].ToString().PadRight(25));
                    txtSort.AppendText("\t\t");
                    txtSort.AppendText(row["ProductNumber"].ToString());
                    txtSort.AppendText(Environment.NewLine);
                }

                txtSort.AppendText("============================================\n");
                // Display data from second data table

                // Display output header

                txtSort.AppendText("Results from Location table:\n");
                txtSort.AppendText("***********************************************\n");
                txtSort.AppendText("Name\t\t\tCostRate\n");
                txtSort.AppendText("__________________________________________\n");

                // Display data
                foreach (DataRow row in dtc[1].Rows)
                {
                    txtSort.AppendText(row["Name"].ToString().PadRight(25));
                    txtSort.AppendText("\t");
                    txtSort.AppendText(row["CostRate"].ToString());
                    txtSort.AppendText(Environment.NewLine);
                }
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
