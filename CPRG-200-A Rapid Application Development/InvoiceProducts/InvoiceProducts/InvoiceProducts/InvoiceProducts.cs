using InvoiceProducts.DatabaseModels;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceProducts
{
    public partial class InvoiceProducts : Form
    {
        public InvoiceProducts()
        {
            InitializeComponent();
        }

        private void InvoiceProducts_Load(object sender, EventArgs e)
        {
            using (MMABooksContext database = new MMABooksContext())
            {
                var invoiceData = (
                    from invoice in database.Invoices
                        join invoiceItems in database.InvoiceLineItems
                            on invoice.InvoiceId equals invoiceItems.InvoiceId
                        join products in database.Products
                            on invoiceItems.ProductCode equals products.ProductCode
                        orderby invoice.InvoiceId
                            select new
                            {
                                invoice.InvoiceId,
                                invoice.CustomerId,
                                invoice.InvoiceDate,
                                products.ProductCode,
                                products.Description
                             }).ToList();

                Console.WriteLine(invoiceData);

                dataGridViewInvoiceProducts.DataSource = invoiceData;
                
                dataGridViewInvoiceProducts.AutoResizeColumns();
            
            }
        }
    }
}
