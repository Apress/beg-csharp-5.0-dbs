using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class UserInfo : Form
    {
        public UserInfo()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           lstCountry.Items.Add(txtCountry.Text);
           txtCountry.Clear();

            cboState.Items.Add(txtState.Text);
            txtState.Clear();  
        }

        private void btnRemoveCountry_Click(object sender, EventArgs e)
        {
            lstCountry.Items.Remove(lstCountry.SelectedItem);
        }

        private void btnRemoveState_Click(object sender, EventArgs e)
        {
            cboState.Items.Remove(cboState.SelectedItem);
        }

        private void btnShowDetails_Click(object sender, EventArgs e)
        {
            if (chkEmail.Checked == true || chkPostalMail.Checked == true && rdbMale.Checked == true)
            {
                MessageBox.Show("Hello Mr, you will be contacted by either USPS or email", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            else
                if (chkEmail.Checked == true || chkPostalMail.Checked == true && rdbFemale.Checked == true)
                {
                    MessageBox.Show("Hello Mam, you will be contacted by either USPS or email", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }
        }
        
    }
}
