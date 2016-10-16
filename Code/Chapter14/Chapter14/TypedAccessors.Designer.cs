namespace DataReaderForms
{
    partial class TypedAccessors
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
            this.txtTypeAccess = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtTypeAccess
            // 
            this.txtTypeAccess.Location = new System.Drawing.Point(12, 12);
            this.txtTypeAccess.Multiline = true;
            this.txtTypeAccess.Name = "txtTypeAccess";
            this.txtTypeAccess.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTypeAccess.Size = new System.Drawing.Size(437, 290);
            this.txtTypeAccess.TabIndex = 0;
            // 
            // TypedAccessors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 315);
            this.Controls.Add(this.txtTypeAccess);
            this.Name = "TypedAccessors";
            this.Text = "TypedAccessors";
            this.Load += new System.EventHandler(this.TypedAccessors_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTypeAccess;

    }
}