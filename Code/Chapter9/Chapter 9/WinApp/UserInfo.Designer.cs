namespace WindowsApplication1
{
    partial class UserInfo
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
            this.lblCountry = new System.Windows.Forms.Label();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lstCountry = new System.Windows.Forms.ListBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.lblState = new System.Windows.Forms.Label();
            this.cboState = new System.Windows.Forms.ComboBox();
            this.chkPostalMail = new System.Windows.Forms.CheckBox();
            this.chkEmail = new System.Windows.Forms.CheckBox();
            this.rdbMale = new System.Windows.Forms.RadioButton();
            this.rdbFemale = new System.Windows.Forms.RadioButton();
            this.btnRemoveCountry = new System.Windows.Forms.Button();
            this.btnRemoveState = new System.Windows.Forms.Button();
            this.btnShowDetails = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(12, 26);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(71, 13);
            this.lblCountry.TabIndex = 0;
            this.lblCountry.Text = "Enter Country";
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(97, 19);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(129, 20);
            this.txtCountry.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 165);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lstCountry
            // 
            this.lstCountry.FormattingEnabled = true;
            this.lstCountry.Location = new System.Drawing.Point(280, 12);
            this.lstCountry.Name = "lstCountry";
            this.lstCountry.Size = new System.Drawing.Size(129, 82);
            this.lstCountry.TabIndex = 3;
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(97, 58);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(129, 20);
            this.txtState.TabIndex = 5;
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(12, 65);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(60, 13);
            this.lblState.TabIndex = 4;
            this.lblState.Text = "Enter State";
            // 
            // cboState
            // 
            this.cboState.FormattingEnabled = true;
            this.cboState.Location = new System.Drawing.Point(280, 117);
            this.cboState.Name = "cboState";
            this.cboState.Size = new System.Drawing.Size(129, 21);
            this.cboState.TabIndex = 6;
            // 
            // chkPostalMail
            // 
            this.chkPostalMail.AutoSize = true;
            this.chkPostalMail.Location = new System.Drawing.Point(15, 107);
            this.chkPostalMail.Name = "chkPostalMail";
            this.chkPostalMail.Size = new System.Drawing.Size(77, 17);
            this.chkPostalMail.TabIndex = 7;
            this.chkPostalMail.Text = "Postal Mail";
            this.chkPostalMail.UseVisualStyleBackColor = true;
            // 
            // chkEmail
            // 
            this.chkEmail.AutoSize = true;
            this.chkEmail.Location = new System.Drawing.Point(15, 130);
            this.chkEmail.Name = "chkEmail";
            this.chkEmail.Size = new System.Drawing.Size(55, 17);
            this.chkEmail.TabIndex = 8;
            this.chkEmail.Text = "E-Mail";
            this.chkEmail.UseVisualStyleBackColor = true;
            // 
            // rdbMale
            // 
            this.rdbMale.AutoSize = true;
            this.rdbMale.Location = new System.Drawing.Point(141, 107);
            this.rdbMale.Name = "rdbMale";
            this.rdbMale.Size = new System.Drawing.Size(48, 17);
            this.rdbMale.TabIndex = 9;
            this.rdbMale.TabStop = true;
            this.rdbMale.Text = "Male";
            this.rdbMale.UseVisualStyleBackColor = true;
            // 
            // rdbFemale
            // 
            this.rdbFemale.AutoSize = true;
            this.rdbFemale.Location = new System.Drawing.Point(141, 131);
            this.rdbFemale.Name = "rdbFemale";
            this.rdbFemale.Size = new System.Drawing.Size(59, 17);
            this.rdbFemale.TabIndex = 10;
            this.rdbFemale.TabStop = true;
            this.rdbFemale.Text = "Female";
            this.rdbFemale.UseVisualStyleBackColor = true;
            // 
            // btnRemoveCountry
            // 
            this.btnRemoveCountry.Location = new System.Drawing.Point(105, 165);
            this.btnRemoveCountry.Name = "btnRemoveCountry";
            this.btnRemoveCountry.Size = new System.Drawing.Size(95, 23);
            this.btnRemoveCountry.TabIndex = 11;
            this.btnRemoveCountry.Text = "Remove Country";
            this.btnRemoveCountry.UseVisualStyleBackColor = true;
            this.btnRemoveCountry.Click += new System.EventHandler(this.btnRemoveCountry_Click);
            // 
            // btnRemoveState
            // 
            this.btnRemoveState.Location = new System.Drawing.Point(220, 165);
            this.btnRemoveState.Name = "btnRemoveState";
            this.btnRemoveState.Size = new System.Drawing.Size(86, 23);
            this.btnRemoveState.TabIndex = 12;
            this.btnRemoveState.Text = "Remove State";
            this.btnRemoveState.UseVisualStyleBackColor = true;
            this.btnRemoveState.Click += new System.EventHandler(this.btnRemoveState_Click);
            // 
            // btnShowDetails
            // 
            this.btnShowDetails.Location = new System.Drawing.Point(327, 165);
            this.btnShowDetails.Name = "btnShowDetails";
            this.btnShowDetails.Size = new System.Drawing.Size(100, 23);
            this.btnShowDetails.TabIndex = 13;
            this.btnShowDetails.Text = "Show Details";
            this.btnShowDetails.UseVisualStyleBackColor = true;
            this.btnShowDetails.Click += new System.EventHandler(this.btnShowDetails_Click);
            // 
            // UserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 213);
            this.Controls.Add(this.btnShowDetails);
            this.Controls.Add(this.btnRemoveState);
            this.Controls.Add(this.btnRemoveCountry);
            this.Controls.Add(this.rdbFemale);
            this.Controls.Add(this.rdbMale);
            this.Controls.Add(this.chkEmail);
            this.Controls.Add(this.chkPostalMail);
            this.Controls.Add(this.cboState);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.lstCountry);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.lblCountry);
            this.Name = "UserInfo";
            this.Text = "User Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lstCountry;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.ComboBox cboState;
        private System.Windows.Forms.CheckBox chkPostalMail;
        private System.Windows.Forms.CheckBox chkEmail;
        private System.Windows.Forms.RadioButton rdbMale;
        private System.Windows.Forms.RadioButton rdbFemale;
        private System.Windows.Forms.Button btnRemoveCountry;
        private System.Windows.Forms.Button btnRemoveState;
        private System.Windows.Forms.Button btnShowDetails;
    }
}