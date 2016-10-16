namespace Text_and_Binary_Data
{
    partial class LoadImages
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtLoadImages = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtLoadImages
            // 
            this.txtLoadImages.Location = new System.Drawing.Point(12, 12);
            this.txtLoadImages.Multiline = true;
            this.txtLoadImages.Name = "txtLoadImages";
            this.txtLoadImages.Size = new System.Drawing.Size(401, 117);
            this.txtLoadImages.TabIndex = 0;
            // 
            // LoadImages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 140);
            this.Controls.Add(this.txtLoadImages);
            this.Name = "LoadImages";
            this.Text = "LoadImages";
            this.Load += new System.EventHandler(this.LoadImages_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLoadImages;


    }
}