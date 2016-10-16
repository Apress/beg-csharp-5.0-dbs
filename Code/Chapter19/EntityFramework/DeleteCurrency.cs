using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EntityFramework
{
    public partial class DeleteCurrency : Form
    {
        public DeleteCurrency()
        {
            InitializeComponent();
        }

        private void DeleteCurrency_Load(object sender, EventArgs e)
        {
            Display();
        }

        // for delete records by Currency Code
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var context = new AdventureWorksCurrencyEntities();
                Currency  del = context.Currencies
                                    .First(i => i.CurrencyCode == TxtDelete.Text);

                //record Delete and save to table   
                context.Currencies.DeleteObject(del);
                context.SaveChanges();
                MessageBox.Show("Record Deleted");
                TxtDelete.Text = "";
                
            }
            catch (Exception err)
            {
                MessageBox.Show("you can't delete this row because it is maintaing dependency to other row.");
            }
        }

        //for displaying intial list of data in currency table
        private void Display()
        {
            using (var context = new AdventureWorksCurrencyEntities())
            {
                var curr = context.Currencies

                    .Where(o => o.ModifiedDate > new DateTime(1998, 1, 1));
                foreach (var cr in curr)
                {
                    txtCurrency.AppendText(cr.ModifiedDate.ToString());
                    txtCurrency.AppendText("\t\t");
                    txtCurrency.AppendText(cr.CurrencyCode.ToString());
                    txtCurrency.AppendText("\t\t");
                    txtCurrency.AppendText(cr.Name.ToString());
                    txtCurrency.AppendText("\t");
                    txtCurrency.AppendText("\n");
                }

            }
        }

        private void TxtDelete_Click(object sender, EventArgs e)
        {
            TxtDelete.Text = "";  
        }
    }
}
