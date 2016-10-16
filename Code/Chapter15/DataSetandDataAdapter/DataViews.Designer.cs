namespace DataSetandDataAdapter
{
    partial class DataViews
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
            this.gvContact = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gvContact)).BeginInit();
            this.SuspendLayout();
            // 
            // gvContact
            // 
            this.gvContact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvContact.Location = new System.Drawing.Point(12, 12);
            this.gvContact.Name = "gvContact";
            this.gvContact.Size = new System.Drawing.Size(262, 298);
            this.gvContact.TabIndex = 1;
            // 
            // DataViews
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 321);
            this.Controls.Add(this.gvContact);
            this.Name = "DataViews";
            this.Text = "DataViews";
            this.Load += new System.EventHandler(this.DataViews_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvContact)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gvContact;


    }
}