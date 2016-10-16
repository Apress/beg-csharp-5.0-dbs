using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Linq
{
    public partial class LinqToObjects : Form
    {
        public LinqToObjects()
        {
            InitializeComponent();
        }

        private void LinqToObjects_Load(object sender, EventArgs e)
        {
            //Define string array 
            string[] names = { "Life is Beautiful", 
                               "Arshika Agarwal", 
                               "Seven Pounds", 
                               "Rupali Agarwal", 
                               "Pearl Solutions", 
                               "Vamika Agarwal", 
                               "Vidya Vrat Agarwal",
                               "Lionbridge Technologies"
                              };

            //Linq query
            IEnumerable<string> namesOfPeople = from name in names
                                                where name.Length <= 16
                                                select name;
            foreach (var name in namesOfPeople)
            {
                txtDisplay.AppendText(name + "\n");
            }
        }
    }
}
