using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Chapter11
{
    public partial class FileHandling : Form
    {
        public FileHandling()
        {
            InitializeComponent();
        }        

        private void btnWriteToFile_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(txtFileWritePath.Text, true);
            sw.WriteLine(txtFileText.Text);
            sw.Close();
        }

        private void btnReadFile_Click(object sender, EventArgs e)
        {
            StreamReader sr = null;

            try
            {
                sr = new StreamReader(txtFileReadPath.Text);
                txtFileContent.Text = sr.ReadToEnd();
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message + " " + "Please provide valid Filename", "File Read Error");
            }

            catch (DirectoryNotFoundException ex)
            {
                MessageBox.Show(ex.Message + " " + "Please provide valid Directory name", "File Read Error");
            }

            finally
            {
                if (sr != null)
                {
                    sr.Close();
                }
            }       
            
        }
    }
}
