namespace Linq
{
    partial class LinqToSql
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
            this.txtLinqtoSql = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtLinqtoSql
            // 
            this.txtLinqtoSql.Location = new System.Drawing.Point(12, 12);
            this.txtLinqtoSql.Multiline = true;
            this.txtLinqtoSql.Name = "txtLinqtoSql";
            this.txtLinqtoSql.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLinqtoSql.Size = new System.Drawing.Size(315, 320);
            this.txtLinqtoSql.TabIndex = 0;
            // 
            // LinqToSql
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 348);
            this.Controls.Add(this.txtLinqtoSql);
            this.Name = "LinqToSql";
            this.Text = "LinqToSql";
            this.Load += new System.EventHandler(this.LinqtoSql_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLinqtoSql;
    }
}