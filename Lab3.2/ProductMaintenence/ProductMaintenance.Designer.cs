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
            this.SuspendLayout();
            // 
            // productsListBox
            // 
            this.productsListBox.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.productsListBox.FormattingEnabled = true;
            this.productsListBox.ItemHeight = 18;
            this.productsListBox.Location = new System.Drawing.Point(117, 12);
            this.productsListBox.Name = "productsListBox";
            this.productsListBox.Size = new System.Drawing.Size(571, 256);
            this.productsListBox.TabIndex = 0;
            this.productsListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.productsListBox_MouseDoubleClick);
            // 
            // buttonAddProduct
            // 
            this.buttonAddProduct.Location = new System.Drawing.Point(12, 131);
            this.buttonAddProduct.Name = "buttonAddProduct";
            this.buttonAddProduct.Size = new System.Drawing.Size(99, 30);
            this.buttonAddProduct.TabIndex = 2;
            this.buttonAddProduct.Text = "Add Product";
            this.buttonAddProduct.UseVisualStyleBackColor = true;
            this.buttonAddProduct.Click += new System.EventHandler(this.buttonAddProduct_Click);
            // 
            // buttonDeleteProduct
            // 
            this.buttonDeleteProduct.Location = new System.Drawing.Point(12, 203);
            this.buttonDeleteProduct.Name = "buttonDeleteProduct";
            this.buttonDeleteProduct.Size = new System.Drawing.Size(99, 30);
            this.buttonDeleteProduct.TabIndex = 3;
            this.buttonDeleteProduct.Text = "Delete Product";
            this.buttonDeleteProduct.UseVisualStyleBackColor = true;
            this.buttonDeleteProduct.Click += new System.EventHandler(this.buttonDeleteProduct_Click);
            // 
            // buttonEditProduct
            // 
            this.buttonEditProduct.Location = new System.Drawing.Point(12, 167);
            this.buttonEditProduct.Name = "buttonEditProduct";
            this.buttonEditProduct.Size = new System.Drawing.Size(99, 30);
            this.buttonEditProduct.TabIndex = 4;
            this.buttonEditProduct.Text = "Edit Product";
            this.buttonEditProduct.UseVisualStyleBackColor = true;
            this.buttonEditProduct.Click += new System.EventHandler(this.buttonEditProduct_Click);
            // 
            // buttonShowProduct
            // 
            this.buttonShowProduct.Location = new System.Drawing.Point(12, 95);
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
            this.labelTotalProductsNumber.Location = new System.Drawing.Point(19, 25);
            this.labelTotalProductsNumber.Name = "labelTotalProductsNumber";
            this.labelTotalProductsNumber.Size = new System.Drawing.Size(81, 37);
            this.labelTotalProductsNumber.TabIndex = 7;
            this.labelTotalProductsNumber.Text = "9999";
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(12, 238);
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
            this.label1.Location = new System.Drawing.Point(19, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Total Products";
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAuthor.Location = new System.Drawing.Point(542, 271);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(146, 19);
            this.labelAuthor.TabIndex = 9;
            this.labelAuthor.Text = "James Buchanan 2022";
            // 
            // ProductMaintenence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 299);
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
            this.Name = "ProductMaintenence";
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
    }
}