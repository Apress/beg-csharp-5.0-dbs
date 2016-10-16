namespace EntityFramework
{
    partial class DeleteCurrency
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.TxtDelete = new System.Windows.Forms.TextBox();
            this.lblHeadDate = new System.Windows.Forms.Label();
            this.lblHeadCode = new System.Windows.Forms.Label();
            this.lblHeadName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCurrency
            // 
            this.txtCurrency.Location = new System.Drawing.Point(12, 61);
            this.txtCurrency.Multiline = true;
            this.txtCurrency.Name = "txtCurrency";
            this.txtCurrency.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCurrency.Size = new System.Drawing.Size(488, 148);
            this.txtCurrency.TabIndex = 5;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(379, 224);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(99, 23);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(25, 229);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(163, 13);
            this.lblName.TabIndex = 10;
            this.lblName.Text = "Enter  Currency Code (for Delete)";
            // 
            // TxtDelete
            // 
            this.TxtDelete.Location = new System.Drawing.Point(212, 226);
            this.TxtDelete.Name = "TxtDelete";
            this.TxtDelete.Size = new System.Drawing.Size(138, 20);
            this.TxtDelete.TabIndex = 9;
            this.TxtDelete.Text = "Name only!!!!";
            this.TxtDelete.Click += new System.EventHandler(this.TxtDelete_Click);
            // 
            // lblHeadDate
            // 
            this.lblHeadDate.AutoSize = true;
            this.lblHeadDate.Location = new System.Drawing.Point(25, 35);
            this.lblHeadDate.Name = "lblHeadDate";
            this.lblHeadDate.Size = new System.Drawing.Size(73, 13);
            this.lblHeadDate.TabIndex = 11;
            this.lblHeadDate.Text = "Modified Date";
            // 
            // lblHeadCode
            // 
            this.lblHeadCode.AutoSize = true;
            this.lblHeadCode.Location = new System.Drawing.Point(167, 35);
            this.lblHeadCode.Name = "lblHeadCode";
            this.lblHeadCode.Size = new System.Drawing.Size(77, 13);
            this.lblHeadCode.TabIndex = 12;
            this.lblHeadCode.Text = "Currency Code";
            // 
            // lblHeadName
            // 
            this.lblHeadName.AutoSize = true;
            this.lblHeadName.Location = new System.Drawing.Point(294, 35);
            this.lblHeadName.Name = "lblHeadName";
            this.lblHeadName.Size = new System.Drawing.Size(35, 13);
            this.lblHeadName.TabIndex = 13;
            this.lblHeadName.Text = "Name";
            // 
            // DeleteCurrency
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 318);
            this.Controls.Add(this.lblHeadName);
            this.Controls.Add(this.lblHeadCode);
            this.Controls.Add(this.lblHeadDate);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.TxtDelete);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtCurrency);
            this.Name = "DeleteCurrency";
            this.Text = "DeleteCurrency";
            this.Load += new System.EventHandler(this.DeleteCurrency_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCurrency;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox TxtDelete;
        private System.Windows.Forms.Label lblHeadDate;
        private System.Windows.Forms.Label lblHeadCode;
        private System.Windows.Forms.Label lblHeadName;
    }
}