using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Text;
using System.Windows.Forms;

namespace Linq
{
    public partial class LinqToSql : Form
    {
        public LinqToSql()
        {
            InitializeComponent();
        }

        [Table(Name = "Person.Contact")]
        public class Contact
        {
            [Column]
            public string Title;
            [Column]
            public string FirstName;         
            [Column]
            public string LastName;
        }

        private void LinqtoSql_Load(object sender, EventArgs e)
        {
            // connection string
            string connString = @"server = .\sql2012;integrated security = true;database = AdventureWorks";        
            
            try 
            {

                // create data context 
                DataContext db = new DataContext(connString);

                // create typed table 
                Table<Contact> contacts = db.GetTable<Contact>();

                // query database
                var contactDetails =
                   from c in contacts
                   where c.Title == "Mr."
                   orderby c.FirstName
                   select c;

                // display departments
                foreach (var c in contactDetails)
                {
                    txtLinqtoSql.AppendText(c.Title);
                    txtLinqtoSql.AppendText("\t");
                    txtLinqtoSql.AppendText(c.FirstName);
                    txtLinqtoSql.AppendText("\t\t");
                    txtLinqtoSql.AppendText(c.LastName);
                    txtLinqtoSql.AppendText("\n");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
   
}
