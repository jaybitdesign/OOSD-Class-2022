namespace ElectricityBill
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblKWHUsed = new System.Windows.Forms.Label();
            this.lblAccountNumber = new System.Windows.Forms.Label();
            this.lblBillAmount = new System.Windows.Forms.Label();
            this.boxData = new System.Windows.Forms.GroupBox();
            this.txtBillAmount = new System.Windows.Forms.TextBox();
            this.txtAccountNumber = new System.Windows.Forms.TextBox();
            this.txtKWHUsed = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.boxDetails = new System.Windows.Forms.GroupBox();
            this.txtTotalKWHUsed = new System.Windows.Forms.TextBox();
            this.txtAverageBillAmount = new System.Windows.Forms.TextBox();
            this.lblAverageBillAmount = new System.Windows.Forms.Label();
            this.lblTotalKWHUsed = new System.Windows.Forms.Label();
            this.CustomerListBox = new System.Windows.Forms.ListBox();
            this.lblCustomersProcessed = new System.Windows.Forms.Label();
            this.txtCustomersProcessed = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.boxData.SuspendLayout();
            this.boxDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFirstName.Location = new System.Drawing.Point(32, 68);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(147, 36);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLastName.Location = new System.Drawing.Point(32, 134);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(143, 36);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "Last Name";
            // 
            // lblKWHUsed
            // 
            this.lblKWHUsed.AutoSize = true;
            this.lblKWHUsed.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblKWHUsed.Location = new System.Drawing.Point(32, 192);
            this.lblKWHUsed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKWHUsed.Name = "lblKWHUsed";
            this.lblKWHUsed.Size = new System.Drawing.Size(145, 36);
            this.lblKWHUsed.TabIndex = 2;
            this.lblKWHUsed.Text = "KWH Used";
            // 
            // lblAccountNumber
            // 
            this.lblAccountNumber.AutoSize = true;
            this.lblAccountNumber.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAccountNumber.Location = new System.Drawing.Point(32, 254);
            this.lblAccountNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAccountNumber.Name = "lblAccountNumber";
            this.lblAccountNumber.Size = new System.Drawing.Size(223, 36);
            this.lblAccountNumber.TabIndex = 3;
            this.lblAccountNumber.Text = "Account Number";
            // 
            // lblBillAmount
            // 
            this.lblBillAmount.AutoSize = true;
            this.lblBillAmount.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBillAmount.Location = new System.Drawing.Point(32, 316);
            this.lblBillAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBillAmount.Name = "lblBillAmount";
            this.lblBillAmount.Size = new System.Drawing.Size(160, 36);
            this.lblBillAmount.TabIndex = 4;
            this.lblBillAmount.Text = "Bill Amount";
            // 
            // boxData
            // 
            this.boxData.Controls.Add(this.txtBillAmount);
            this.boxData.Controls.Add(this.txtAccountNumber);
            this.boxData.Controls.Add(this.txtKWHUsed);
            this.boxData.Controls.Add(this.txtLastName);
            this.boxData.Controls.Add(this.txtFirstName);
            this.boxData.Controls.Add(this.lblFirstName);
            this.boxData.Controls.Add(this.lblBillAmount);
            this.boxData.Controls.Add(this.lblLastName);
            this.boxData.Controls.Add(this.lblAccountNumber);
            this.boxData.Controls.Add(this.lblKWHUsed);
            this.boxData.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.boxData.Location = new System.Drawing.Point(22, 77);
            this.boxData.Margin = new System.Windows.Forms.Padding(6);
            this.boxData.Name = "boxData";
            this.boxData.Padding = new System.Windows.Forms.Padding(6);
            this.boxData.Size = new System.Drawing.Size(626, 450);
            this.boxData.TabIndex = 5;
            this.boxData.TabStop = false;
            this.boxData.Text = "Enter New Customer Details";
            // 
            // txtBillAmount
            // 
            this.txtBillAmount.Location = new System.Drawing.Point(243, 316);
            this.txtBillAmount.Margin = new System.Windows.Forms.Padding(6);
            this.txtBillAmount.Name = "txtBillAmount";
            this.txtBillAmount.ReadOnly = true;
            this.txtBillAmount.Size = new System.Drawing.Size(238, 39);
            this.txtBillAmount.TabIndex = 9;
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.Location = new System.Drawing.Point(243, 247);
            this.txtAccountNumber.Margin = new System.Windows.Forms.Padding(6);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Size = new System.Drawing.Size(238, 39);
            this.txtAccountNumber.TabIndex = 8;
            this.txtAccountNumber.Tag = "Account Number";
            this.txtAccountNumber.TextChanged += new System.EventHandler(this.txtAccountNumber_TextChanged);
            // 
            // txtKWHUsed
            // 
            this.txtKWHUsed.Location = new System.Drawing.Point(243, 190);
            this.txtKWHUsed.Margin = new System.Windows.Forms.Padding(6);
            this.txtKWHUsed.Name = "txtKWHUsed";
            this.txtKWHUsed.Size = new System.Drawing.Size(238, 39);
            this.txtKWHUsed.TabIndex = 7;
            this.txtKWHUsed.Tag = "KWH Used";
            this.txtKWHUsed.TextChanged += new System.EventHandler(this.txtKWHUsed_TextChanged);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(243, 130);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(6);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(238, 39);
            this.txtLastName.TabIndex = 6;
            this.txtLastName.Tag = "Last Name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(243, 68);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(6);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(238, 39);
            this.txtFirstName.TabIndex = 5;
            this.txtFirstName.Tag = "First Name";
            this.txtFirstName.TextChanged += new System.EventHandler(this.txtFirstName_TextChanged);
            // 
            // boxDetails
            // 
            this.boxDetails.Controls.Add(this.txtTotalKWHUsed);
            this.boxDetails.Controls.Add(this.txtAverageBillAmount);
            this.boxDetails.Controls.Add(this.lblAverageBillAmount);
            this.boxDetails.Controls.Add(this.lblTotalKWHUsed);
            this.boxDetails.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.boxDetails.Location = new System.Drawing.Point(22, 602);
            this.boxDetails.Margin = new System.Windows.Forms.Padding(6);
            this.boxDetails.Name = "boxDetails";
            this.boxDetails.Padding = new System.Windows.Forms.Padding(6);
            this.boxDetails.Size = new System.Drawing.Size(626, 326);
            this.boxDetails.TabIndex = 10;
            this.boxDetails.TabStop = false;
            this.boxDetails.Text = "Bill Details";
            this.boxDetails.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtTotalKWHUsed
            // 
            this.txtTotalKWHUsed.Location = new System.Drawing.Point(295, 194);
            this.txtTotalKWHUsed.Margin = new System.Windows.Forms.Padding(6);
            this.txtTotalKWHUsed.Name = "txtTotalKWHUsed";
            this.txtTotalKWHUsed.ReadOnly = true;
            this.txtTotalKWHUsed.Size = new System.Drawing.Size(238, 39);
            this.txtTotalKWHUsed.TabIndex = 7;
            // 
            // txtAverageBillAmount
            // 
            this.txtAverageBillAmount.Location = new System.Drawing.Point(295, 132);
            this.txtAverageBillAmount.Margin = new System.Windows.Forms.Padding(6);
            this.txtAverageBillAmount.Name = "txtAverageBillAmount";
            this.txtAverageBillAmount.ReadOnly = true;
            this.txtAverageBillAmount.Size = new System.Drawing.Size(238, 39);
            this.txtAverageBillAmount.TabIndex = 6;
            // 
            // lblAverageBillAmount
            // 
            this.lblAverageBillAmount.AutoSize = true;
            this.lblAverageBillAmount.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAverageBillAmount.Location = new System.Drawing.Point(32, 134);
            this.lblAverageBillAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAverageBillAmount.Name = "lblAverageBillAmount";
            this.lblAverageBillAmount.Size = new System.Drawing.Size(266, 36);
            this.lblAverageBillAmount.TabIndex = 1;
            this.lblAverageBillAmount.Text = "Average Bill Amount";
            // 
            // lblTotalKWHUsed
            // 
            this.lblTotalKWHUsed.AutoSize = true;
            this.lblTotalKWHUsed.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalKWHUsed.Location = new System.Drawing.Point(32, 194);
            this.lblTotalKWHUsed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalKWHUsed.Name = "lblTotalKWHUsed";
            this.lblTotalKWHUsed.Size = new System.Drawing.Size(212, 36);
            this.lblTotalKWHUsed.TabIndex = 2;
            this.lblTotalKWHUsed.Text = "Total KWH Used";
            // 
            // CustomerListBox
            // 
            this.CustomerListBox.FormattingEnabled = true;
            this.CustomerListBox.ItemHeight = 32;
            this.CustomerListBox.Location = new System.Drawing.Point(713, 77);
            this.CustomerListBox.Margin = new System.Windows.Forms.Padding(6);
            this.CustomerListBox.Name = "CustomerListBox";
            this.CustomerListBox.Size = new System.Drawing.Size(1173, 900);
            this.CustomerListBox.TabIndex = 11;
            this.CustomerListBox.SelectedIndexChanged += new System.EventHandler(this.CustomerListBox_SelectedIndexChanged);
            // 
            // lblCustomersProcessed
            // 
            this.lblCustomersProcessed.AutoSize = true;
            this.lblCustomersProcessed.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCustomersProcessed.Location = new System.Drawing.Point(22, 945);
            this.lblCustomersProcessed.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCustomersProcessed.Name = "lblCustomersProcessed";
            this.lblCustomersProcessed.Size = new System.Drawing.Size(270, 36);
            this.lblCustomersProcessed.TabIndex = 12;
            this.lblCustomersProcessed.Text = "Customers Processed";
            this.lblCustomersProcessed.Click += new System.EventHandler(this.lblCustomersProcessed_Click);
            // 
            // txtCustomersProcessed
            // 
            this.txtCustomersProcessed.Location = new System.Drawing.Point(290, 932);
            this.txtCustomersProcessed.Margin = new System.Windows.Forms.Padding(6);
            this.txtCustomersProcessed.Name = "txtCustomersProcessed";
            this.txtCustomersProcessed.ReadOnly = true;
            this.txtCustomersProcessed.Size = new System.Drawing.Size(182, 39);
            this.txtCustomersProcessed.TabIndex = 13;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSubmit.Location = new System.Drawing.Point(22, 1026);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(6);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(139, 49);
            this.btnSubmit.TabIndex = 14;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExit.Location = new System.Drawing.Point(329, 1026);
            this.btnExit.Margin = new System.Windows.Forms.Padding(6);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(139, 49);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnReset.Location = new System.Drawing.Point(173, 1026);
            this.btnReset.Margin = new System.Windows.Forms.Padding(6);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(139, 49);
            this.btnReset.TabIndex = 16;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1901, 1120);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtCustomersProcessed);
            this.Controls.Add(this.lblCustomersProcessed);
            this.Controls.Add(this.CustomerListBox);
            this.Controls.Add(this.boxDetails);
            this.Controls.Add(this.boxData);
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.boxData.ResumeLayout(false);
            this.boxData.PerformLayout();
            this.boxDetails.ResumeLayout(false);
            this.boxDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblKWHUsed;
        private System.Windows.Forms.Label lblAccountNumber;
        private System.Windows.Forms.Label lblBillAmount;
        private System.Windows.Forms.GroupBox boxData;
        private System.Windows.Forms.GroupBox boxDetails;
        private System.Windows.Forms.TextBox txtTotalKWHUsed;
        private System.Windows.Forms.TextBox txtAverageBillAmount;
        private System.Windows.Forms.Label lblAverageBillAmount;
        private System.Windows.Forms.Label lblTotalKWHUsed;
        private System.Windows.Forms.TextBox txtBillAmount;
        private System.Windows.Forms.TextBox txtAccountNumber;
        private System.Windows.Forms.TextBox txtKWHUsed;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.ListBox CustomerListBox;
        private System.Windows.Forms.Label lblCustomersProcessed;
        private System.Windows.Forms.TextBox txtCustomersProcessed;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReset;
    }
}
