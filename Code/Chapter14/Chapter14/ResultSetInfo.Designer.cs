namespace DataReaderForms
{
    partial class ResultSetInfo
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
            this.lblDataType = new System.Windows.Forms.Label();
            this.lbltype1 = new System.Windows.Forms.Label();
            this.lblType2 = new System.Windows.Forms.Label();
            this.txtResultSet = new System.Windows.Forms.TextBox();
            this.lblType3 = new System.Windows.Forms.Label();
            this.lblType4 = new System.Windows.Forms.Label();
            this.lblType5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDataType
            // 
            this.lblDataType.AutoSize = true;
            this.lblDataType.Location = new System.Drawing.Point(3, 31);
            this.lblDataType.Name = "lblDataType";
            this.lblDataType.Size = new System.Drawing.Size(57, 13);
            this.lblDataType.TabIndex = 0;
            this.lblDataType.Text = "Data Type";
            // 
            // lbltype1
            // 
            this.lbltype1.Location = new System.Drawing.Point(80, 21);
            this.lbltype1.Name = "lbltype1";
            this.lbltype1.Size = new System.Drawing.Size(101, 34);
            this.lbltype1.TabIndex = 1;
            // 
            // lblType2
            // 
            this.lblType2.Location = new System.Drawing.Point(222, 21);
            this.lblType2.Name = "lblType2";
            this.lblType2.Size = new System.Drawing.Size(101, 34);
            this.lblType2.TabIndex = 2;
            // 
            // txtResultSet
            // 
            this.txtResultSet.Location = new System.Drawing.Point(32, 58);
            this.txtResultSet.Multiline = true;
            this.txtResultSet.Name = "txtResultSet";
            this.txtResultSet.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResultSet.Size = new System.Drawing.Size(341, 234);
            this.txtResultSet.TabIndex = 5;
            // 
            // lblType3
            // 
            this.lblType3.Location = new System.Drawing.Point(38, 317);
            this.lblType3.Name = "lblType3";
            this.lblType3.Size = new System.Drawing.Size(335, 13);
            this.lblType3.TabIndex = 1;
            // 
            // lblType4
            // 
            this.lblType4.Location = new System.Drawing.Point(38, 352);
            this.lblType4.Name = "lblType4";
            this.lblType4.Size = new System.Drawing.Size(335, 13);
            this.lblType4.TabIndex = 2;
            // 
            // lblType5
            // 
            this.lblType5.Location = new System.Drawing.Point(38, 381);
            this.lblType5.Name = "lblType5";
            this.lblType5.Size = new System.Drawing.Size(335, 13);
            this.lblType5.TabIndex = 3;
            // 
            // ResultSetInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 422);
            this.Controls.Add(this.lblType5);
            this.Controls.Add(this.txtResultSet);
            this.Controls.Add(this.lblType4);
            this.Controls.Add(this.lblType3);
            this.Controls.Add(this.lblType2);
            this.Controls.Add(this.lbltype1);
            this.Controls.Add(this.lblDataType);
            this.Name = "ResultSetInfo";
            this.Text = "ResultSetInfo";
            this.Load += new System.EventHandler(this.ResultSetInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDataType;
        private System.Windows.Forms.Label lbltype1;
        private System.Windows.Forms.Label lblType2;
        private System.Windows.Forms.TextBox txtResultSet;
        private System.Windows.Forms.Label lblType3;
        private System.Windows.Forms.Label lblType4;
        private System.Windows.Forms.Label lblType5;

    }
}