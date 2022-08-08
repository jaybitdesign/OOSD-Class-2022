namespace InvoiceProducts
{
    partial class InvoiceProducts
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
            this.dataGridViewInvoiceProducts = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInvoiceProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewInvoiceProducts
            // 
            this.dataGridViewInvoiceProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInvoiceProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewInvoiceProducts.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewInvoiceProducts.Name = "dataGridViewInvoiceProducts";
            this.dataGridViewInvoiceProducts.RowTemplate.Height = 25;
            this.dataGridViewInvoiceProducts.Size = new System.Drawing.Size(615, 286);
            this.dataGridViewInvoiceProducts.TabIndex = 0;
            // 
            // InvoiceProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(615, 286);
            this.Controls.Add(this.dataGridViewInvoiceProducts);
            this.Name = "InvoiceProducts";
            this.Text = "InvoiceProducts";
            this.Load += new System.EventHandler(this.InvoiceProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInvoiceProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridViewInvoiceProducts;
    }
}