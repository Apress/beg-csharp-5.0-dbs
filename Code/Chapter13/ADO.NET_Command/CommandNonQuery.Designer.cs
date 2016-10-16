namespace ADO.NET_Command
{
    partial class CommandNonQuery
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
            this.gbInsertCurrency = new System.Windows.Forms.GroupBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCurrencyCode = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCurrencyCode = new System.Windows.Forms.Label();
            this.lblInsertStatus = new System.Windows.Forms.Label();
            this.btnInsertCurrency = new System.Windows.Forms.Button();
            this.dtpModifiedDate = new System.Windows.Forms.DateTimePicker();
            this.lblModifiedDate = new System.Windows.Forms.Label();
            this.gbInsertCurrency.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbInsertCurrency
            // 
            this.gbInsertCurrency.Controls.Add(this.lblInsertStatus);
            this.gbInsertCurrency.Controls.Add(this.btnInsertCurrency);
            this.gbInsertCurrency.Controls.Add(this.dtpModifiedDate);
            this.gbInsertCurrency.Controls.Add(this.txtName);
            this.gbInsertCurrency.Controls.Add(this.txtCurrencyCode);
            this.gbInsertCurrency.Controls.Add(this.lblModifiedDate);
            this.gbInsertCurrency.Controls.Add(this.lblName);
            this.gbInsertCurrency.Controls.Add(this.lblCurrencyCode);
            this.gbInsertCurrency.Location = new System.Drawing.Point(21, 22);
            this.gbInsertCurrency.Name = "gbInsertCurrency";
            this.gbInsertCurrency.Size = new System.Drawing.Size(240, 201);
            this.gbInsertCurrency.TabIndex = 0;
            this.gbInsertCurrency.TabStop = false;
            this.gbInsertCurrency.Text = "Insert Currency";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(99, 64);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(128, 20);
            this.txtName.TabIndex = 4;
            // 
            // txtCurrencyCode
            // 
            this.txtCurrencyCode.Location = new System.Drawing.Point(99, 30);
            this.txtCurrencyCode.Name = "txtCurrencyCode";
            this.txtCurrencyCode.Size = new System.Drawing.Size(128, 20);
            this.txtCurrencyCode.TabIndex = 3;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(19, 64);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // lblCurrencyCode
            // 
            this.lblCurrencyCode.AutoSize = true;
            this.lblCurrencyCode.Location = new System.Drawing.Point(16, 30);
            this.lblCurrencyCode.Name = "lblCurrencyCode";
            this.lblCurrencyCode.Size = new System.Drawing.Size(77, 13);
            this.lblCurrencyCode.TabIndex = 0;
            this.lblCurrencyCode.Text = "Currency Code";
            // 
            // lblInsertStatus
            // 
            this.lblInsertStatus.Location = new System.Drawing.Point(22, 168);
            this.lblInsertStatus.Name = "lblInsertStatus";
            this.lblInsertStatus.Size = new System.Drawing.Size(205, 21);
            this.lblInsertStatus.TabIndex = 8;
            // 
            // btnInsertCurrency
            // 
            this.btnInsertCurrency.Location = new System.Drawing.Point(56, 133);
            this.btnInsertCurrency.Name = "btnInsertCurrency";
            this.btnInsertCurrency.Size = new System.Drawing.Size(128, 23);
            this.btnInsertCurrency.TabIndex = 7;
            this.btnInsertCurrency.Text = "Insert Currency";
            this.btnInsertCurrency.UseVisualStyleBackColor = true;
            this.btnInsertCurrency.Click += new System.EventHandler(this.btnInsertCurrency_Click);
            // 
            // dtpModifiedDate
            // 
            this.dtpModifiedDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpModifiedDate.Location = new System.Drawing.Point(99, 97);
            this.dtpModifiedDate.Name = "dtpModifiedDate";
            this.dtpModifiedDate.Size = new System.Drawing.Size(128, 20);
            this.dtpModifiedDate.TabIndex = 6;
            // 
            // lblModifiedDate
            // 
            this.lblModifiedDate.AutoSize = true;
            this.lblModifiedDate.Location = new System.Drawing.Point(19, 97);
            this.lblModifiedDate.Name = "lblModifiedDate";
            this.lblModifiedDate.Size = new System.Drawing.Size(73, 13);
            this.lblModifiedDate.TabIndex = 2;
            this.lblModifiedDate.Text = "Modified Date";
            // 
            // CommandNonQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 239);
            this.Controls.Add(this.gbInsertCurrency);
            this.Name = "CommandNonQuery";
            this.Text = "CommandNonQuery";
            this.gbInsertCurrency.ResumeLayout(false);
            this.gbInsertCurrency.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbInsertCurrency;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCurrencyCode;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCurrencyCode;
        private System.Windows.Forms.Label lblInsertStatus;
        private System.Windows.Forms.Button btnInsertCurrency;
        private System.Windows.Forms.DateTimePicker dtpModifiedDate;
        private System.Windows.Forms.Label lblModifiedDate;

    }
}