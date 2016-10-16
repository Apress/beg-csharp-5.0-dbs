namespace ADO.NET_Command
{
    partial class CommandText
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
            this.txtCommandText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtCommandText
            // 
            this.txtCommandText.Location = new System.Drawing.Point(12, 12);
            this.txtCommandText.Multiline = true;
            this.txtCommandText.Name = "txtCommandText";
            this.txtCommandText.Size = new System.Drawing.Size(244, 106);
            this.txtCommandText.TabIndex = 0;
            // 
            // CommandTextL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 138);
            this.Controls.Add(this.txtCommandText);
            this.Name = "CommandTextL";
            this.Text = "CommandText";
            this.Load += new System.EventHandler(this.CommandText_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCommandText;
    }
}