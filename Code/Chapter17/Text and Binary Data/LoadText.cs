using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace Text_and_Binary_Data
{
    public partial class LoadText : Form
    {
        // change this path to the location of text in your computer
        static string fileName =
          @"C:\VidyaVrat\C#2012 and SQL 2012\Chapter17\Code\Text and Binary Data\LoadText.cs";

        SqlConnection conn = null;
        SqlCommand cmd = null;

        public LoadText()
        {
            InitializeComponent();
        }

        private void LoadText_Load(object sender, EventArgs e)
        {
            try
            {
                // Create connection
                conn = new SqlConnection(@"data source = .\sql2012;integrated security = true;initial catalog = SQL2012Db;");

                //Create command
                cmd = new SqlCommand();
                cmd.Connection = conn;

                // Open connection
                conn.Open();                
              
                // Create table
                CreateTextTable();

                // Prepare insert command
                PrepareInsertTextFile();

                // Load text file
                ExecuteInsertTextFile(fileName);

                txtLoadText.AppendText("Loaded "+fileName+" into TextTable.\n");
                
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                // Close connection
                conn.Close();
            }
        }

        private void CreateTextTable()
        {
            ExecuteCommand(@"if exists(select *
                                      from INFORMATION_SCHEMA.TABLES
                                      where TABLE_NAME = 'TextTable')
                             drop table TextTable ");

            ExecuteCommand(@"create table TextTable
                             (
                                 TextFile varchar(255),
                                 TextData varchar(max))");
        }      
      

        private void ExecuteCommand(string commandText)
        {
            //int commandResult;
            cmd.CommandText = commandText;
            //txtLoadText.AppendText("Executing command:\n");
            //Console.WriteLine(cmd.CommandText);
            cmd.ExecuteNonQuery();
            //txtLoadText.AppendText("ExecuteNonQuery returns." + commandResult);
            txtLoadText.AppendText("\n");
        }
        private void PrepareInsertTextFile()
        {
            cmd.CommandText = @"insert into TextTable
                                values (@textfile, @textdata)";

            cmd.Parameters.Add("@textfile", SqlDbType.NVarChar, 30);
            cmd.Parameters.Add("@textdata", SqlDbType.Text, 1000000);
        }

        private void ExecuteInsertTextFile(string textFile)
        {
            string textData = GetTextFile(textFile);
            cmd.Parameters["@textfile"].Value = textFile;
            cmd.Parameters["@textdata"].Value = textData;
            ExecuteCommand(cmd.CommandText);
        }

        private string GetTextFile(string textFile)
        {
            string textBytes = null;
            txtLoadText.AppendText("Loading File: " + textFile);

            FileStream fs = new FileStream(textFile, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            textBytes = sr.ReadToEnd();

            txtLoadText.AppendText("TextBytes has length" + textBytes.Length + " bytes.\n");

            return textBytes;
        }
    }
}
