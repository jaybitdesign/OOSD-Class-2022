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
            this.components = new System.ComponentModel.Container();
            this.labelProductCode = new System.Windows.Forms.Label();
            this.labelProductName = new System.Windows.Forms.Label();
            this.textBoxProductCode = new System.Windows.Forms.TextBox();
            this.labelProductVersion = new System.Windows.Forms.Label();
            this.labelProductDate = new System.Windows.Forms.Label();
            this.textBoxProductVersion = new System.Windows.Forms.TextBox();
            this.textBoxProductName = new System.Windows.Forms.TextBox();
            this.buttonCancelForm = new System.Windows.Forms.Button();
            this.buttonSubmitForm = new System.Windows.Forms.Button();
            this.textBoxProductDate = new System.Windows.Forms.TextBox();
            this.errorProviderProductCode = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderProductName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderProductDate = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderProductVersion = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderProductCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderProductName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderProductDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderProductVersion)).BeginInit();
            this.SuspendLayout();
            // 
            // labelProductCode
            // 
            this.labelProductCode.AutoSize = true;
            this.labelProductCode.Location = new System.Drawing.Point(3, 9);
            this.labelProductCode.Name = "labelProductCode";
            this.labelProductCode.Size = new System.Drawing.Size(83, 15);
            this.labelProductCode.TabIndex = 0;
            this.labelProductCode.Text = "Product &Code:";
            // 
            // labelProductName
            // 
            this.labelProductName.AutoSize = true;
            this.labelProductName.Location = new System.Drawing.Point(3, 38);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(87, 15);
            this.labelProductName.TabIndex = 1;
            this.labelProductName.Text = "Product &Name:";
            this.labelProductName.Click += new System.EventHandler(this.labelProductName_Click);
            // 
            // textBoxProductCode
            // 
            this.textBoxProductCode.Location = new System.Drawing.Point(104, 6);
            this.textBoxProductCode.Name = "textBoxProductCode";
            this.textBoxProductCode.PlaceholderText = "Product Code";
            this.textBoxProductCode.Size = new System.Drawing.Size(245, 23);
            this.textBoxProductCode.TabIndex = 0;
            this.textBoxProductCode.Tag = "textBoxProductCode";
            // 
            // labelProductVersion
            // 
            this.labelProductVersion.AutoSize = true;
            this.labelProductVersion.Location = new System.Drawing.Point(3, 67);
            this.labelProductVersion.Name = "labelProductVersion";
            this.labelProductVersion.Size = new System.Drawing.Size(93, 15);
            this.labelProductVersion.TabIndex = 3;
            this.labelProductVersion.Text = "Product &Version:";
            // 
            // labelProductDate
            // 
            this.labelProductDate.AutoSize = true;
            this.labelProductDate.Location = new System.Drawing.Point(3, 96);
            this.labelProductDate.Name = "labelProductDate";
            this.labelProductDate.Size = new System.Drawing.Size(79, 15);
            this.labelProductDate.TabIndex = 4;
            this.labelProductDate.Text = "Product &Date:";
            // 
            // textBoxProductVersion
            // 
            this.textBoxProductVersion.Location = new System.Drawing.Point(104, 64);
            this.textBoxProductVersion.Name = "textBoxProductVersion";
            this.textBoxProductVersion.PlaceholderText = "Product Version";
            this.textBoxProductVersion.Size = new System.Drawing.Size(245, 23);
            this.textBoxProductVersion.TabIndex = 2;
            this.textBoxProductVersion.Tag = "textBoxProductVersion";
            // 
            // textBoxProductName
            // 
            this.textBoxProductName.Location = new System.Drawing.Point(104, 35);
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.PlaceholderText = "Product Name";
            this.textBoxProductName.Size = new System.Drawing.Size(245, 23);
            this.textBoxProductName.TabIndex = 1;
            this.textBoxProductName.Tag = "textBoxProductName";
            this.textBoxProductName.TextChanged += new System.EventHandler(this.textBoxProductName_TextChanged);
            // 
            // buttonCancelForm
            // 
            this.buttonCancelForm.Location = new System.Drawing.Point(3, 122);
            this.buttonCancelForm.Name = "buttonCancelForm";
            this.buttonCancelForm.Size = new System.Drawing.Size(168, 30);
            this.buttonCancelForm.TabIndex = 5;
            this.buttonCancelForm.Text = "Cancel / Back";
            this.buttonCancelForm.UseVisualStyleBackColor = true;
            this.buttonCancelForm.Click += new System.EventHandler(this.buttonCancelForm_Click);
            // 
            // buttonSubmitForm
            // 
            this.buttonSubmitForm.Location = new System.Drawing.Point(181, 122);
            this.buttonSubmitForm.Name = "buttonSubmitForm";
            this.buttonSubmitForm.Size = new System.Drawing.Size(168, 30);
            this.buttonSubmitForm.TabIndex = 4;
            this.buttonSubmitForm.Text = "Submit";
            this.buttonSubmitForm.UseVisualStyleBackColor = true;
            this.buttonSubmitForm.Click += new System.EventHandler(this.buttonSubmitForm_Click);
            // 
            // textBoxProductDate
            // 
            this.textBoxProductDate.Location = new System.Drawing.Point(104, 93);
            this.textBoxProductDate.Name = "textBoxProductDate";
            this.textBoxProductDate.PlaceholderText = "Product Release Date";
            this.textBoxProductDate.Size = new System.Drawing.Size(245, 23);
            this.textBoxProductDate.TabIndex = 3;
            this.textBoxProductDate.Tag = "textBoxProductDate";
            // 
            // errorProviderProductCode
            // 
            this.errorProviderProductCode.ContainerControl = this;
            // 
            // errorProviderProductName
            // 
            this.errorProviderProductName.ContainerControl = this;
            // 
            // errorProviderProductDate
            // 
            this.errorProviderProductDate.ContainerControl = this;
            // 
            // errorProviderProductVersion
            // 
            this.errorProviderProductVersion.ContainerControl = this;
            // 
            // ProductMaintenanceEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(357, 155);
            this.Controls.Add(this.textBoxProductDate);
            this.Controls.Add(this.buttonSubmitForm);
            this.Controls.Add(this.buttonCancelForm);
            this.Controls.Add(this.textBoxProductName);
            this.Controls.Add(this.textBoxProductVersion);
            this.Controls.Add(this.labelProductDate);
            this.Controls.Add(this.labelProductVersion);
            this.Controls.Add(this.textBoxProductCode);
            this.Controls.Add(this.labelProductName);
            this.Controls.Add(this.labelProductCode);
            this.Name = "ProductMaintenanceEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductMaintenenceEdit";
            this.Load += new System.EventHandler(this.ProductMaintenenceEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderProductCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderProductName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderProductDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderProductVersion)).EndInit();
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
        private TextBox textBoxProductDate;
        private ErrorProvider errorProviderProductCode;
        private ErrorProvider errorProviderProductName;
        private ErrorProvider errorProviderProductDate;
        private ErrorProvider errorProviderProductVersion;
    }
}