using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Text_and_Binary_Data
{
    public partial class RetrieveText : Form
    {
        string textFile = null;
        char[] textChars = null;
        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataReader dr = null;

        public RetrieveText()
        {
            InitializeComponent();

            // Create connection
            conn = new SqlConnection(@"data source = .\sql2012;integrated security = true;initial catalog = SQL2012Db;");

            // Create command
            cmd = new SqlCommand(@"select textfile, textdata
                                   from TextTable", conn);

            // Open connection
            conn.Open();

            // Create data reader
            dr = cmd.ExecuteReader();
        }

        public void RetrieveText_Load(object sender, EventArgs e)
        {
            try
            {
               while (GetRow() == true)
                {
                    txtRetrieveText.AppendText ("----- end of file\n");
                    txtRetrieveText.AppendText(textFile);
                    txtRetrieveText.AppendText("\n======================================\n");
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.ToString());
            }

            finally
            {
                // Close the reader and the connection. 
                dr.Close();
                conn.Close();
            }
        }

        public bool GetRow()
        {
            long textSize;
            int bufferSize = 100;
            long charsRead;
            textChars = new Char[bufferSize];

            if (dr.Read())
            {
                // Get file name
                textFile = dr.GetString(0);
                txtRetrieveText.AppendText("------ start of file\n");
                txtRetrieveText.AppendText(textFile);
                txtRetrieveText.AppendText("\n");
                textSize = dr.GetChars(1, 0, null, 0, 0);
                txtRetrieveText.AppendText("--- size of text: " + textSize + " characters -----");

                txtRetrieveText.AppendText("\n--- first 100 characters in text -----\n");
                charsRead = dr.GetChars(1, 0, textChars, 0, 100);
                txtRetrieveText.AppendText(new String(textChars));
                txtRetrieveText.AppendText("\n");
                txtRetrieveText.AppendText("\n--- last 100 characters in text -----\n");
                charsRead = dr.GetChars(1, textSize - 100, textChars, 0, 100);
                txtRetrieveText.AppendText(new String(textChars));

                return true;
            }
            else
            {
                return false;
            }
        }        
    }
}
