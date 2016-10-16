namespace ADO.NET_Command
{
    partial class CommandScalar
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
            this.txtScalar = new System.Windows.Forms.TextBox();
            this.lblRowCount = new System.Windows.Forms.Label();
            this.btnRowCount = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtScalar
            // 
            this.txtScalar.Location = new System.Drawing.Point(97, 12);
            this.txtScalar.Multiline = true;
            this.txtScalar.Name = "txtScalar";
            this.txtScalar.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtScalar.Size = new System.Drawing.Size(164, 65);
            this.txtScalar.TabIndex = 1;
            // 
            // lblRowCount
            // 
            this.lblRowCount.AutoSize = true;
            this.lblRowCount.Location = new System.Drawing.Point(4, 35);
            this.lblRowCount.Name = "lblRowCount";
            this.lblRowCount.Size = new System.Drawing.Size(87, 13);
            this.lblRowCount.TabIndex = 2;
            this.lblRowCount.Text = "Total Row Count";
            // 
            // btnRowCount
            // 
            this.btnRowCount.Location = new System.Drawing.Point(269, 30);
            this.btnRowCount.Name = "btnRowCount";
            this.btnRowCount.Size = new System.Drawing.Size(88, 23);
            this.btnRowCount.TabIndex = 3;
            this.btnRowCount.Text = "Count Rows";
            this.btnRowCount.UseVisualStyleBackColor = true;
            this.btnRowCount.Click += new System.EventHandler(this.btnRowCount_Click);
            // 
            // CommandScalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 88);
            this.Controls.Add(this.btnRowCount);
            this.Controls.Add(this.lblRowCount);
            this.Controls.Add(this.txtScalar);
            this.Name = "CommandScalar";
            this.Text = "CommandScalar";            
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtScalar;
        private System.Windows.Forms.Label lblRowCount;
        private System.Windows.Forms.Button btnRowCount;
    }
}