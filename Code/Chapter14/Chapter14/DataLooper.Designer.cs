namespace DataReaderForms
{
    partial class DataLooper
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
            this.lbxProduct = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbxProduct
            // 
            this.lbxProduct.FormattingEnabled = true;
            this.lbxProduct.Location = new System.Drawing.Point(21, 22);
            this.lbxProduct.Name = "lbxProduct";
            this.lbxProduct.Size = new System.Drawing.Size(281, 394);
            this.lbxProduct.TabIndex = 1;
            // 
            // DataLooper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 438);
            this.Controls.Add(this.lbxProduct);
            this.Name = "DataLooper";
            this.Text = "DataLooper";
            this.Load += new System.EventHandler(this.DataLooper_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbxProduct;
    }
}