using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace Text_and_Binary_Data
{
    public partial class LoadImages : Form
    {
        public LoadImages()
        {
            InitializeComponent();
        }

        // change this path to the location of image in your computer
        string imageFileLocation = @"C:\VidyaVrat\C#2012 and SQL 2012\Chapter17\Code\";
        
        string imageFilePrefix = "SpaceNeedle";
        string imageFileType = ".jpg";
        
        int numberImageFiles = 1;
        int maxImageSize = 10000;

        SqlConnection conn = null;
        SqlCommand cmd = null;
     
        private void LoadImages_Load(object sender, EventArgs e)
        {
           try
            {
                // Create connection
                conn = new SqlConnection(@"server = .\sql2012;integrated security = true;database = SQL2012Db");

                // Open connection
                conn.Open();
               //Create command
               cmd = new SqlCommand();
               cmd.Connection = conn;

                // Create table
                CreateImageTable();

                // Prepare insert
                PrepareInsertImages();

                // Loop for Inserting images             
                for (int i = 1; i <= numberImageFiles; i++)
                {
                    ExecuteInsertImages(i);
                }
               
            }

            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }

            finally
            {
                // Close connection
                conn.Close();
                txtLoadImages.AppendText(Environment.NewLine);
                txtLoadImages.AppendText("Connection Closed.");
            }
        }        
       
        private void ExecuteCommand(string cmdText)
        {
            int cmdResult;
            cmd.CommandText = cmdText;
            cmdResult = cmd.ExecuteNonQuery();
        }

        // Create table to load images
        private void CreateImageTable()
        {
            ExecuteCommand(@"if exists
                              (select * from
                                INFORMATION_SCHEMA.TABLES
                                 where TABLE_NAME = 'ImageTable')
              
                               drop table ImageTable  
                               
                               create table ImageTable
                               (
                                   ImageFile nvarchar(20),
                                   ImageData varbinary(max)
                               )");
        }

        // Prepare command to insert images
        private void PrepareInsertImages()
        {
            cmd.CommandText = @"insert into imagetable
                               values (@ImageFile, @ImageData)";

            cmd.Parameters.Add("@imagefile", SqlDbType.NVarChar, 20);
            cmd.Parameters.Add("@imagedata", SqlDbType.Image, 1000000);

            cmd.Prepare();
        }

        private void ExecuteInsertImages(int imageFileNumber)
        {
            string imageFileName = null;
            byte[] imageImageData = null;

            imageFileName = imageFilePrefix + imageFileNumber.ToString() + imageFileType;
            imageImageData = LoadImageFile(imageFileName, imageFileLocation, maxImageSize);

            cmd.Parameters["@ImageFile"].Value = imageFileName;
            cmd.Parameters["@ImageData"].Value = imageImageData;

            ExecuteCommand(cmd.CommandText);
        }

        private byte[] LoadImageFile(string fileName,string fileLocation,int maxImageSize)
        {
            byte[] imagebytes = null;
            string fullpath = fileLocation + fileName;
            txtLoadImages.AppendText("Loading File:");
            txtLoadImages.AppendText(Environment.NewLine);
            txtLoadImages.AppendText(fullpath);
            FileStream fs = new FileStream(fullpath, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            imagebytes = br.ReadBytes(maxImageSize);
            txtLoadImages.AppendText(Environment.NewLine);

            txtLoadImages.AppendText("Imagebytes has length " + imagebytes.GetLength(0).ToString() + " bytes.");
             
            return imagebytes;
        }
    }
}
