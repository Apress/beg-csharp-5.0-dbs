namespace EntityFramework
{
    partial class UpdateCurrency
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
            this.lblName = new System.Windows.Forms.Label();
            this.TxtUpdate = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.lblCode = new System.Windows.Forms.Label();
            this.lblHeadName = new System.Windows.Forms.Label();
            this.lblHeadCode = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCurrency
            // 
            this.txtCurrency.Location = new System.Drawing.Point(62, 53);
            this.txtCurrency.Multiline = true;
            this.txtCurrency.Name = "txtCurrency";
            this.txtCurrency.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCurrency.Size = new System.Drawing.Size(518, 197);
            this.txtCurrency.TabIndex = 4;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(136, 311);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(110, 13);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "Enter Updated  Name";
            // 
            // TxtUpdate
            // 
            this.TxtUpdate.Location = new System.Drawing.Point(252, 308);
            this.TxtUpdate.Name = "TxtUpdate";
            this.TxtUpdate.Size = new System.Drawing.Size(138, 20);
            this.TxtUpdate.TabIndex = 6;
            this.TxtUpdate.Text = "Enter the Updated value";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(408, 305);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(97, 23);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update This";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(252, 273);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(138, 20);
            this.txtCode.TabIndex = 8;
            this.txtCode.Text = "ARS";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(136, 270);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(108, 13);
            this.lblCode.TabIndex = 9;
            this.lblCode.Text = "Enter  Currency Code";
            // 
            // lblHeadName
            // 
            this.lblHeadName.AutoSize = true;
            this.lblHeadName.Location = new System.Drawing.Point(352, 22);
            this.lblHeadName.Name = "lblHeadName";
            this.lblHeadName.Size = new System.Drawing.Size(38, 13);
            this.lblHeadName.TabIndex = 10;
            this.lblHeadName.Text = " Name";
            // 
            // lblHeadCode
            // 
            this.lblHeadCode.AutoSize = true;
            this.lblHeadCode.Location = new System.Drawing.Point(236, 22);
            this.lblHeadCode.Name = "lblHeadCode";
            this.lblHeadCode.Size = new System.Drawing.Size(77, 13);
            this.lblHeadCode.TabIndex = 11;
            this.lblHeadCode.Text = "Currency Code";
            // 
            // UpdateCurrency
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 340);
            this.Controls.Add(this.lblHeadCode);
            this.Controls.Add(this.lblHeadName);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.TxtUpdate);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtCurrency);
            this.Name = "UpdateCurrency";
            this.Text = "UpdateCurrency";
            this.Load += new System.EventHandler(this.UpdateCurrency_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCurrency;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox TxtUpdate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblHeadName;
        private System.Windows.Forms.Label lblHeadCode;
    }
}