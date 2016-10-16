namespace Text_and_Binary_Data
{
    partial class DisplayImages
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
            this.ptbImage = new System.Windows.Forms.PictureBox();
            this.txtImageName = new System.Windows.Forms.TextBox();
            this.btnShowImage = new System.Windows.Forms.Button();
            this.lblImageName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbImage
            // 
            this.ptbImage.Location = new System.Drawing.Point(44, 61);
            this.ptbImage.Name = "ptbImage";
            this.ptbImage.Size = new System.Drawing.Size(220, 221);
            this.ptbImage.TabIndex = 5;
            this.ptbImage.TabStop = false;
            // 
            // txtImageName
            // 
            this.txtImageName.Location = new System.Drawing.Point(85, 22);
            this.txtImageName.Name = "txtImageName";
            this.txtImageName.Size = new System.Drawing.Size(126, 20);
            this.txtImageName.TabIndex = 4;
            // 
            // btnShowImage
            // 
            this.btnShowImage.Location = new System.Drawing.Point(227, 22);
            this.btnShowImage.Name = "btnShowImage";
            this.btnShowImage.Size = new System.Drawing.Size(75, 23);
            this.btnShowImage.TabIndex = 3;
            this.btnShowImage.Text = "Show Image";
            this.btnShowImage.UseVisualStyleBackColor = true;
            this.btnShowImage.Click += new System.EventHandler(this.btnShowImage_Click);
            // 
            // lblImageName
            // 
            this.lblImageName.AutoSize = true;
            this.lblImageName.Location = new System.Drawing.Point(12, 22);
            this.lblImageName.Name = "lblImageName";
            this.lblImageName.Size = new System.Drawing.Size(67, 13);
            this.lblImageName.TabIndex = 6;
            this.lblImageName.Text = "Image Name";
            // 
            // DisplayImages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 294);
            this.Controls.Add(this.lblImageName);
            this.Controls.Add(this.ptbImage);
            this.Controls.Add(this.txtImageName);
            this.Controls.Add(this.btnShowImage);
            this.Name = "DisplayImages";
            this.Text = "DisplayImages";
           ((System.ComponentModel.ISupportInitialize)(this.ptbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbImage;
        private System.Windows.Forms.TextBox txtImageName;
        private System.Windows.Forms.Button btnShowImage;
        private System.Windows.Forms.Label lblImageName;
    }
}