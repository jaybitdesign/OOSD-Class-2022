using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace InvoiceProducts.DatabaseModels
{
    public partial class InvoiceLineItem
    {
        [Key]
        [Column("InvoiceID")]
        public int InvoiceId { get; set; }
        [Key]
        [StringLength(10)]
        [Unicode(false)]
        public string ProductCode { get; set; } = null!;
        [Column(TypeName = "money")]
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        [Column(TypeName = "money")]
        public decimal ItemTotal { get; set; }

        [ForeignKey("InvoiceId")]
        [InverseProperty("InvoiceLineItems")]
        public virtual Invoice Invoice { get; set; } = null!;
        [ForeignKey("ProductCode")]
        [InverseProperty("InvoiceLineItems")]
        public virtual Product ProductCodeNavigation { get; set; } = null!;
    }
}
