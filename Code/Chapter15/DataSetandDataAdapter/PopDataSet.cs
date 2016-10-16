using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;


namespace DataSetandDataAdapter
{
    public partial class PopDataSet : Form
    {
        public PopDataSet()
        {
            InitializeComponent();
        }

        private void PopDataSet_Load(object sender, EventArgs e)
        {
            // Connection string
            string connString = @" server=.\sql2012;database=AdventureWorks;Integrated Security=true";
            
            // Query
            string sql = @"select Name,ProductNumber
                           from Production.Product
                           where SafetyStockLevel > 600";

            // Create connection
            SqlConnection conn = new SqlConnection(connString);

            try
            {
                // Open connection
                conn.Open();

                // Create Data Adapter
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);

                // Create Dataset
                DataSet ds = new DataSet();

                // Fill Dataset
                da.Fill(ds, "Production.Product");

               
                // Display data
                gvProduct.DataSource = ds.Tables["Production.Product"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.StackTrace);
            }
            finally
            {
                //connection close
                conn.Close();
            } 

        }       
    }
}
