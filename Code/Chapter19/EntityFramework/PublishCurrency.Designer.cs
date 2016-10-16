namespace EntityFramework
{
    partial class PublishCurrency
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
            this.txtCurrency = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtCurrency
            // 
            this.txtCurrency.Location = new System.Drawing.Point(12, 12);
            this.txtCurrency.Multiline = true;
            this.txtCurrency.Name = "txtCurrency";
            this.txtCurrency.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCurrency.Size = new System.Drawing.Size(518, 247);
            this.txtCurrency.TabIndex = 3;
            // 
            // PublishCurrency
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 268);
            this.Controls.Add(this.txtCurrency);
            this.Name = "PublishCurrency";
            this.Text = "PublishCurrency";
            this.Load += new System.EventHandler(this.PublishCurrency_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCurrency;
    }
}