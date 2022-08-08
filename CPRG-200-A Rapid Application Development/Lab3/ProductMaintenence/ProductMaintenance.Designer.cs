namespace ProductMaintenence
{
    partial class ProductMaintenance
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
            this.productsListBox = new System.Windows.Forms.ListBox();
            this.buttonAddProduct = new System.Windows.Forms.Button();
            this.buttonDeleteProduct = new System.Windows.Forms.Button();
            this.buttonEditProduct = new System.Windows.Forms.Button();
            this.buttonShowProduct = new System.Windows.Forms.Button();
            this.labelTotalProductsNumber = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.labelHint = new System.Windows.Forms.Label();
            this.labelCode = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // productsListBox
            // 
            this.productsListBox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.productsListBox.FormattingEnabled = true;
            this.productsListBox.Location = new System.Drawing.Point(119, 23);
            this.productsListBox.Name = "productsListBox";
            this.productsListBox.Size = new System.Drawing.Size(572, 251);
            this.productsListBox.TabIndex = 0;
            this.productsListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.productsListBox_MouseDoubleClick);
            // 
            // buttonAddProduct
            // 
            this.buttonAddProduct.Location = new System.Drawing.Point(14, 137);
            this.buttonAddProduct.Name = "buttonAddProduct";
            this.buttonAddProduct.Size = new System.Drawing.Size(99, 30);
            this.buttonAddProduct.TabIndex = 2;
            this.buttonAddProduct.Text = "Add Product";
            this.buttonAddProduct.UseVisualStyleBackColor = true;
            this.buttonAddProduct.Click += new System.EventHandler(this.buttonAddProduct_Click);
            // 
            // buttonDeleteProduct
            // 
            this.buttonDeleteProduct.Location = new System.Drawing.Point(14, 209);
            this.buttonDeleteProduct.Name = "buttonDeleteProduct";
            this.buttonDeleteProduct.Size = new System.Drawing.Size(99, 30);
            this.buttonDeleteProduct.TabIndex = 3;
            this.buttonDeleteProduct.Text = "Delete Product";
            this.buttonDeleteProduct.UseVisualStyleBackColor = true;
            this.buttonDeleteProduct.Click += new System.EventHandler(this.buttonDeleteProduct_Click);
            // 
            // buttonEditProduct
            // 
            this.buttonEditProduct.Location = new System.Drawing.Point(14, 173);
            this.buttonEditProduct.Name = "buttonEditProduct";
            this.buttonEditProduct.Size = new System.Drawing.Size(99, 30);
            this.buttonEditProduct.TabIndex = 4;
            this.buttonEditProduct.Text = "Edit Product";
            this.buttonEditProduct.UseVisualStyleBackColor = true;
            this.buttonEditProduct.Click += new System.EventHandler(this.buttonEditProduct_Click);
            // 
            // buttonShowProduct
            // 
            this.buttonShowProduct.Location = new System.Drawing.Point(14, 101);
            this.buttonShowProduct.Name = "buttonShowProduct";
            this.buttonShowProduct.Size = new System.Drawing.Size(99, 30);
            this.buttonShowProduct.TabIndex = 5;
            this.buttonShowProduct.Text = "Show Product";
            this.buttonShowProduct.UseVisualStyleBackColor = true;
            this.buttonShowProduct.Click += new System.EventHandler(this.buttonShowProduct_Click);
            // 
            // labelTotalProductsNumber
            // 
            this.labelTotalProductsNumber.AutoSize = true;
            this.labelTotalProductsNumber.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTotalProductsNumber.Location = new System.Drawing.Point(50, 32);
            this.labelTotalProductsNumber.Name = "labelTotalProductsNumber";
            this.labelTotalProductsNumber.Size = new System.Drawing.Size(33, 37);
            this.labelTotalProductsNumber.TabIndex = 7;
            this.labelTotalProductsNumber.Text = "0";
            this.labelTotalProductsNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(14, 244);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(99, 30);
            this.buttonExit.TabIndex = 8;
            this.buttonExit.Text = "Exit Program";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Total Products";
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAuthor.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelAuthor.Location = new System.Drawing.Point(376, 283);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(234, 13);
            this.labelAuthor.TabIndex = 9;
            this.labelAuthor.Text = "James Buchanan / Hilmi Abou-Hishmeh 2022";
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(616, 277);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(75, 23);
            this.buttonRefresh.TabIndex = 10;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // labelHint
            // 
            this.labelHint.AutoSize = true;
            this.labelHint.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelHint.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelHint.Location = new System.Drawing.Point(14, 280);
            this.labelHint.Name = "labelHint";
            this.labelHint.Size = new System.Drawing.Size(316, 19);
            this.labelHint.TabIndex = 11;
            this.labelHint.Text = "Tip: Double-click to display a products information";
            // 
            // labelCode
            // 
            this.labelCode.AutoSize = true;
            this.labelCode.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCode.Location = new System.Drawing.Point(119, 3);
            this.labelCode.Name = "labelCode";
            this.labelCode.Size = new System.Drawing.Size(43, 17);
            this.labelCode.TabIndex = 12;
            this.labelCode.Text = "CODE";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelName.Location = new System.Drawing.Point(192, 3);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(46, 17);
            this.labelName.TabIndex = 13;
            this.labelName.Text = "NAME";
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelVersion.Location = new System.Drawing.Point(500, 3);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(63, 17);
            this.labelVersion.TabIndex = 14;
            this.labelVersion.Text = "VERSION";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDate.Location = new System.Drawing.Point(625, 3);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(41, 17);
            this.labelDate.TabIndex = 15;
            this.labelDate.Text = "DATE";
            // 
            // ProductMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 305);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelCode);
            this.Controls.Add(this.labelHint);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.labelAuthor);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.labelTotalProductsNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonShowProduct);
            this.Controls.Add(this.buttonEditProduct);
            this.Controls.Add(this.buttonDeleteProduct);
            this.Controls.Add(this.buttonAddProduct);
            this.Controls.Add(this.productsListBox);
            this.MaximizeBox = false;
            this.Name = "ProductMaintenance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Maintenence";
            this.Load += new System.EventHandler(this.ProductMaintenence_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox productsListBox;
        private Button buttonAddProduct;
        private Button buttonDeleteProduct;
        private Button buttonEditProduct;
        private Button buttonShowProduct;
        private Label labelTotalProductsNumber;
        private Button buttonExit;
        private Label label1;
        private Label labelAuthor;
        private Button buttonRefresh;
        private Label labelHint;
        private Label labelCode;
        private Label labelName;
        private Label labelVersion;
        private Label labelDate;
    }
}