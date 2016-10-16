using System.Data.SqlClient;
using System.IO;
using System.Drawing;

namespace Text_and_Binary_Data
{
    public class Images
    {
        string imageFilename = null;
        byte[] imageBytes = null;

        SqlConnection imageConnection = null;
        SqlCommand imageCommand = null;
        SqlDataReader imageReader = null;

        // Constructor
        public Images()
        {
            imageConnection = new SqlConnection(@"data source = .\sql2012;integrated security = true;initial catalog = SQL2012db;");

            imageCommand = new SqlCommand(@" select imagefile,imagedata
                                             from ImageTable", imageConnection);

            // Open connection and create data reader
            imageConnection.Open();
            imageReader = imageCommand.ExecuteReader();
        }

        public Bitmap GetImage()
        {
            MemoryStream ms = new MemoryStream(imageBytes);
            Bitmap bmap = new Bitmap(ms);

            return bmap;
        }

        public string GetFilename()
        {
            return imageFilename;
        }

        public bool GetRow()
        {
            if (imageReader.Read())
            {
                imageFilename = (string)imageReader.GetValue(0);
                imageBytes = (byte[])imageReader.GetValue(1);

                return true;
            }
            else
            {
                return false;
            }
        }

        public void EndImages()
        {
            // Close the reader and the connection.
            imageReader.Close();
            imageConnection.Close();
        }
    }
}
