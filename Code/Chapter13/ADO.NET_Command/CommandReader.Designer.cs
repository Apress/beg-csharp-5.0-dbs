namespace ADO.NET_Command
{
    partial class CommandReader
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
            this.txtReader = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtReader
            // 
            this.txtReader.Location = new System.Drawing.Point(12, 12);
            this.txtReader.Multiline = true;
            this.txtReader.Name = "txtReader";
            this.txtReader.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtReader.Size = new System.Drawing.Size(415, 223);
            this.txtReader.TabIndex = 1;
            // 
            // CommandReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 245);
            this.Controls.Add(this.txtReader);
            this.Name = "CommandReader";
            this.Text = "CommandReader";
            this.Load += new System.EventHandler(this.CommandReader_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtReader;
    }
}