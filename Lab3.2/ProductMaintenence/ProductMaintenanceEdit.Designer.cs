namespace ProductMaintenence
{
    partial class ProductMaintenanceEdit
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
            this.labelProductCode = new System.Windows.Forms.Label();
            this.labelProductName = new System.Windows.Forms.Label();
            this.textBoxProductCode = new System.Windows.Forms.TextBox();
            this.labelProductVersion = new System.Windows.Forms.Label();
            this.labelProductDate = new System.Windows.Forms.Label();
            this.textBoxProductVersion = new System.Windows.Forms.TextBox();
            this.textBoxProductName = new System.Windows.Forms.TextBox();
            this.buttonCancelForm = new System.Windows.Forms.Button();
            this.buttonSubmitForm = new System.Windows.Forms.Button();
            this.datePickerProductDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // labelProductCode
            // 
            this.labelProductCode.AutoSize = true;
            this.labelProductCode.Location = new System.Drawing.Point(12, 15);
            this.labelProductCode.Name = "labelProductCode";
            this.labelProductCode.Size = new System.Drawing.Size(83, 15);
            this.labelProductCode.TabIndex = 0;
            this.labelProductCode.Text = "Product &Code:";
            // 
            // labelProductName
            // 
            this.labelProductName.AutoSize = true;
            this.labelProductName.Location = new System.Drawing.Point(12, 44);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(87, 15);
            this.labelProductName.TabIndex = 1;
            this.labelProductName.Text = "Product &Name:";
            // 
            // textBoxProductCode
            // 
            this.textBoxProductCode.Location = new System.Drawing.Point(113, 12);
            this.textBoxProductCode.Name = "textBoxProductCode";
            this.textBoxProductCode.PlaceholderText = "Product Code";
            this.textBoxProductCode.Size = new System.Drawing.Size(134, 23);
            this.textBoxProductCode.TabIndex = 2;
            // 
            // labelProductVersion
            // 
            this.labelProductVersion.AutoSize = true;
            this.labelProductVersion.Location = new System.Drawing.Point(12, 73);
            this.labelProductVersion.Name = "labelProductVersion";
            this.labelProductVersion.Size = new System.Drawing.Size(93, 15);
            this.labelProductVersion.TabIndex = 3;
            this.labelProductVersion.Text = "Product &Version:";
            // 
            // labelProductDate
            // 
            this.labelProductDate.AutoSize = true;
            this.labelProductDate.Location = new System.Drawing.Point(12, 102);
            this.labelProductDate.Name = "labelProductDate";
            this.labelProductDate.Size = new System.Drawing.Size(79, 15);
            this.labelProductDate.TabIndex = 4;
            this.labelProductDate.Text = "Product &Date:";
            // 
            // textBoxProductVersion
            // 
            this.textBoxProductVersion.Location = new System.Drawing.Point(113, 70);
            this.textBoxProductVersion.Name = "textBoxProductVersion";
            this.textBoxProductVersion.PlaceholderText = "Product Version";
            this.textBoxProductVersion.Size = new System.Drawing.Size(134, 23);
            this.textBoxProductVersion.TabIndex = 6;
            // 
            // textBoxProductName
            // 
            this.textBoxProductName.Location = new System.Drawing.Point(113, 41);
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.PlaceholderText = "Product Name";
            this.textBoxProductName.Size = new System.Drawing.Size(134, 23);
            this.textBoxProductName.TabIndex = 7;
            // 
            // buttonCancelForm
            // 
            this.buttonCancelForm.Location = new System.Drawing.Point(12, 133);
            this.buttonCancelForm.Name = "buttonCancelForm";
            this.buttonCancelForm.Size = new System.Drawing.Size(114, 30);
            this.buttonCancelForm.TabIndex = 8;
            this.buttonCancelForm.Text = "Cancel/Back";
            this.buttonCancelForm.UseVisualStyleBackColor = true;
            this.buttonCancelForm.Click += new System.EventHandler(this.buttonCancelForm_Click);
            // 
            // buttonSubmitForm
            // 
            this.buttonSubmitForm.Location = new System.Drawing.Point(133, 133);
            this.buttonSubmitForm.Name = "buttonSubmitForm";
            this.buttonSubmitForm.Size = new System.Drawing.Size(114, 30);
            this.buttonSubmitForm.TabIndex = 9;
            this.buttonSubmitForm.Text = "Submit";
            this.buttonSubmitForm.UseVisualStyleBackColor = true;
            this.buttonSubmitForm.Click += new System.EventHandler(this.buttonSubmitForm_Click);
            // 
            // datePickerProductDate
            // 
            this.datePickerProductDate.CustomFormat = "mm/dd/yyyy";
            this.datePickerProductDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePickerProductDate.Location = new System.Drawing.Point(113, 102);
            this.datePickerProductDate.Name = "datePickerProductDate";
            this.datePickerProductDate.Size = new System.Drawing.Size(134, 23);
            this.datePickerProductDate.TabIndex = 10;
            this.datePickerProductDate.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // ProductMaintenenceEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(261, 174);
            this.Controls.Add(this.datePickerProductDate);
            this.Controls.Add(this.buttonSubmitForm);
            this.Controls.Add(this.buttonCancelForm);
            this.Controls.Add(this.textBoxProductName);
            this.Controls.Add(this.textBoxProductVersion);
            this.Controls.Add(this.labelProductDate);
            this.Controls.Add(this.labelProductVersion);
            this.Controls.Add(this.textBoxProductCode);
            this.Controls.Add(this.labelProductName);
            this.Controls.Add(this.labelProductCode);
            this.Name = "ProductMaintenenceEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductMaintenenceEdit";
            this.Load += new System.EventHandler(this.ProductMaintenenceEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelProductCode;
        private Label labelProductName;
        private TextBox textBoxProductCode;
        private Label labelProductVersion;
        private Label labelProductDate;
        private TextBox textBoxProductVersion;
        private TextBox textBoxProductName;
        private Button buttonCancelForm;
        private Button buttonSubmitForm;
        private DateTimePicker datePickerProductDate;
    }
}