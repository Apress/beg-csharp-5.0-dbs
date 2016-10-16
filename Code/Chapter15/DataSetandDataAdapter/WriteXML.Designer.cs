namespace DataSetandDataAdapter
{
    partial class WriteXML
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
            this.btnXML = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnXML
            // 
            this.btnXML.Location = new System.Drawing.Point(74, 30);
            this.btnXML.Name = "btnXML";
            this.btnXML.Size = new System.Drawing.Size(128, 23);
            this.btnXML.TabIndex = 0;
            this.btnXML.Text = "Generate XML";
            this.btnXML.UseVisualStyleBackColor = true;
            this.btnXML.Click += new System.EventHandler(this.btnXML_Click);
            // 
            // WriteXML
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 86);
            this.Controls.Add(this.btnXML);
            this.Name = "WriteXML";
            this.Text = "WriteXML";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnXML;
    }
}