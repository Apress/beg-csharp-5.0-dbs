namespace Text_and_Binary_Data
{
    partial class LoadText
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
            this.txtLoadText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtLoadText
            // 
            this.txtLoadText.Location = new System.Drawing.Point(12, 12);
            this.txtLoadText.Multiline = true;
            this.txtLoadText.Name = "txtLoadText";
            this.txtLoadText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLoadText.Size = new System.Drawing.Size(456, 135);
            this.txtLoadText.TabIndex = 0;
            // 
            // LoadText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 158);
            this.Controls.Add(this.txtLoadText);
            this.Name = "LoadText";
            this.Text = "LoadText";
            this.Load += new System.EventHandler(this.LoadText_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLoadText;
    }
}