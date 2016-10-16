using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Drawing;
using System.Windows.Forms;


namespace DataSetandDataAdapter
{
    public partial class ModifyDataTable : Form
    {
        public ModifyDataTable()
        {
            InitializeComponent();
        }

        private void ModifyDataTable_Load(object sender, EventArgs e)
        {
            // Connection string
            string connString = @"server=.\sql2012;database=AdventureWorks;Integrated Security=true";

            // Query
            string sql = @"select  AddressLine2,City,StateProvinceID,PostalCode
                            from Person.Address
                            where City = 'Bothell'";

            // Create connection
            SqlConnection conn = new SqlConnection(connString);

            try
            {
                // Create Data Adapter
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = new SqlCommand(sql, conn);

                // Create and Fill Dataset
                DataSet ds = new DataSet();
                da.Fill(ds, "Person.Address");

                // Get data table reference
                DataTable dt = ds.Tables["Person.Address"];

                // AddressLine2 column should be nullable
                dt.Columns["AddressLine2"].AllowDBNull = true;

                // Modify City in first row
                dt.Rows[0]["City"] = "Wilmington";

                // Add a row
                DataRow newRow = dt.NewRow();
                
                newRow["PostalCode"] = "111111";
                newRow["StateProvinceID"] = "80";
                newRow["City"] = "Birmingham";
                dt.Rows.Add(newRow);

                // Display Rows
                gvAddress.DataSource = dt;
                gvAddress.Columns[0].Visible = false;
                gvAddress.Rows[0].DefaultCellStyle.BackColor  =  Color.Red; 
              
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
