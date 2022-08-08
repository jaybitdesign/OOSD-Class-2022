using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace InvoiceProducts.DatabaseModels
{
    public partial class Invoice
    {
        public Invoice()
        {
            InvoiceLineItems = new HashSet<InvoiceLineItem>();
        }

        [Key]
        [Column("InvoiceID")]
        public int InvoiceId { get; set; }
        [Column("CustomerID")]
        public int CustomerId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime InvoiceDate { get; set; }
        [Column(TypeName = "money")]
        public decimal ProductTotal { get; set; }
        [Column(TypeName = "money")]
        public decimal SalesTax { get; set; }
        [Column(TypeName = "money")]
        public decimal Shipping { get; set; }
        [Column(TypeName = "money")]
        public decimal InvoiceTotal { get; set; }

        [ForeignKey("CustomerId")]
        [InverseProperty("Invoices")]
        public virtual Customer Customer { get; set; } = null!;
        [InverseProperty("Invoice")]
        public virtual ICollection<InvoiceLineItem> InvoiceLineItems { get; set; }
    }
}
