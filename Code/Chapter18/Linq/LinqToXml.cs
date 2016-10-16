using System;
using System.Linq;
using System.Xml.Linq;
using System.Windows.Forms;

namespace Linq
{
    public partial class LinqToXml : Form
    {
        public LinqToXml()
        {
            InitializeComponent();
        }

        private void LinqToXml_Load(object sender, EventArgs e)
        {
            //Load the productstable.xml in memory
            XElement doc = XElement.Load(@"C:\VidyaVrat\C#2012 and SQL 2012\Chapter18\Code\Linq\productstable.xml");

            //Query xml doc
            var products = from prodname in doc.Descendants("products")
                           select prodname.Value;

            //Display details
            foreach (var prodname in products)
            {
                txtLinqToXml.AppendText("Product's Detail= ");
                txtLinqToXml.AppendText(prodname);
                txtLinqToXml.AppendText("\n");
            }
        }
    }
}
