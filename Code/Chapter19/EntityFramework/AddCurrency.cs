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
    public partial class AddCurrency : Form
    {
        public AddCurrency()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var context = new AdventureWorksCurrencyEntities();

                //adding new rows in currency table
                Currency curr = new Currency
                {
                    Name = txtName.Text,
                    CurrencyCode  = txtCode.Text,
                    ModifiedDate = new DateTime(1998, 1, 1)
                };

                //add and change save in the table
                context.Currencies.AddObject(curr);
                context.SaveChanges();
                MessageBox.Show("Record Inserted");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
            finally
            {
                txtName.Text = "";
                txtCode.Text = "";
            }
        }
    }
}
