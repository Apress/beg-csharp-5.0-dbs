namespace ADO.NET_Command
{
    partial class CommandStoredProcedure
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
            this.gbDeleteCurrency = new System.Windows.Forms.GroupBox();
            this.lblDeleteStatus = new System.Windows.Forms.Label();
            this.btnLoadCurrency = new System.Windows.Forms.Button();
            this.btnDeleteCurrency = new System.Windows.Forms.Button();
            this.lstCurrency = new System.Windows.Forms.ListBox();
            this.gbDeleteCurrency.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDeleteCurrency
            // 
            this.gbDeleteCurrency.Controls.Add(this.lblDeleteStatus);
            this.gbDeleteCurrency.Controls.Add(this.btnLoadCurrency);
            this.gbDeleteCurrency.Controls.Add(this.btnDeleteCurrency);
            this.gbDeleteCurrency.Controls.Add(this.lstCurrency);
            this.gbDeleteCurrency.Location = new System.Drawing.Point(12, 12);
            this.gbDeleteCurrency.Name = "gbDeleteCurrency";
            this.gbDeleteCurrency.Size = new System.Drawing.Size(248, 201);
            this.gbDeleteCurrency.TabIndex = 2;
            this.gbDeleteCurrency.TabStop = false;
            this.gbDeleteCurrency.Text = "Delete Currency";
            // 
            // lblDeleteStatus
            // 
            this.lblDeleteStatus.Location = new System.Drawing.Point(16, 165);
            this.lblDeleteStatus.Name = "lblDeleteStatus";
            this.lblDeleteStatus.Size = new System.Drawing.Size(218, 21);
            this.lblDeleteStatus.TabIndex = 9;
            // 
            // btnLoadCurrency
            // 
            this.btnLoadCurrency.Location = new System.Drawing.Point(118, 45);
            this.btnLoadCurrency.Name = "btnLoadCurrency";
            this.btnLoadCurrency.Size = new System.Drawing.Size(116, 23);
            this.btnLoadCurrency.TabIndex = 2;
            this.btnLoadCurrency.Text = "Load Currency List";
            this.btnLoadCurrency.UseVisualStyleBackColor = true;
            this.btnLoadCurrency.Click += new System.EventHandler(this.btnLoadCurrency_Click);
            // 
            // btnDeleteCurrency
            // 
            this.btnDeleteCurrency.Location = new System.Drawing.Point(118, 100);
            this.btnDeleteCurrency.Name = "btnDeleteCurrency";
            this.btnDeleteCurrency.Size = new System.Drawing.Size(116, 23);
            this.btnDeleteCurrency.TabIndex = 1;
            this.btnDeleteCurrency.Text = "Delete Currency";
            this.btnDeleteCurrency.UseVisualStyleBackColor = true;
            this.btnDeleteCurrency.Click += new System.EventHandler(this.btnDeleteCurrency_Click);
            // 
            // lstCurrency
            // 
            this.lstCurrency.FormattingEnabled = true;
            this.lstCurrency.Location = new System.Drawing.Point(19, 29);
            this.lstCurrency.Name = "lstCurrency";
            this.lstCurrency.ScrollAlwaysVisible = true;
            this.lstCurrency.Size = new System.Drawing.Size(85, 121);
            this.lstCurrency.TabIndex = 0;
            // 
            // CommandStoredProcedure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 229);
            this.Controls.Add(this.gbDeleteCurrency);
            this.Name = "CommandStoredProcedure";
            this.Text = "CommandStoredProcedure";
            this.gbDeleteCurrency.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDeleteCurrency;
        private System.Windows.Forms.Label lblDeleteStatus;
        private System.Windows.Forms.Button btnLoadCurrency;
        private System.Windows.Forms.Button btnDeleteCurrency;
        private System.Windows.Forms.ListBox lstCurrency;
    }
}