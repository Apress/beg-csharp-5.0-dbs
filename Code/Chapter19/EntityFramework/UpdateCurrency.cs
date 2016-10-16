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
    public partial class UpdateCurrency : Form
    {
        public UpdateCurrency()
        {
            InitializeComponent();
        }

        private void UpdateCurrency_Load(object sender, EventArgs e)
        {
            Display();
        }

        // data update manipluation
        private void btnUpdate_Click(object sender, EventArgs e)
        {

            try
            {
                var context = new AdventureWorksCurrencyEntities();

                //update by currency code
                Currency depart = context.Currencies
                                    .First(i => i.CurrencyCode == txtCode.Text);

                //update the Department name column data
                depart.Name = TxtUpdate.Text;
                context.SaveChanges();

                MessageBox.Show("Record Updated");
                
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
            finally
            {
                TxtUpdate.Text = "";
                
            }
        }
      
        // List for initials records in the table
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
    }
}
