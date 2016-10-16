using System;
using System.Drawing;
using System.Windows.Forms;

namespace Text_and_Binary_Data
{
    public partial class DisplayImages : Form
    {
        Images images = new Images();
        
        public DisplayImages()
        {
            InitializeComponent();
           
            if (images.GetRow())
            {
                this.txtImageName.Text = images.GetFilename();
                this.ptbImage.Image = (Image)images.GetImage();
            }
            else
            {
                this.txtImageName.Text = "DONE";
                this.ptbImage.Image = null;
            }
        }       
     
        private void btnShowImage_Click(object sender, EventArgs e)
        {
            if (images.GetRow())
            {
                this.txtImageName.Text = images.GetFilename();
                this.ptbImage.Image = (Image)images.GetImage();
            }
            else
            {
                this.txtImageName.Text = "DONE";
                this.ptbImage.Image = null;
            }
        }        
    }
}
