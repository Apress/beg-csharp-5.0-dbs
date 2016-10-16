namespace DataReaderForms
{
    partial class SchemaTable
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
            this.txtSchema = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtSchema
            // 
            this.txtSchema.Location = new System.Drawing.Point(12, 12);
            this.txtSchema.Multiline = true;
            this.txtSchema.Name = "txtSchema";
            this.txtSchema.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSchema.Size = new System.Drawing.Size(333, 392);
            this.txtSchema.TabIndex = 0;
            // 
            // SchemaTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 421);
            this.Controls.Add(this.txtSchema);
            this.Name = "SchemaTable";
            this.Text = "SchemaTable";
            this.Load += new System.EventHandler(this.SchemaTable_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSchema;

    }
}