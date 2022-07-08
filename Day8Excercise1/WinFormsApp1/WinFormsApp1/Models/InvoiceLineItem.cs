using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WinFormsApp1.Models
{
    public partial class InvoiceLineItem
    {
        [Key]
        [Column("InvoiceID")]
        public int InvoiceId { get; set; }
        [Key]
        [StringLength(10)]
        public string ProductCode { get; set; }
        [Column(TypeName = "money")]
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        [Column(TypeName = "money")]
        public decimal ItemTotal { get; set; }

        [ForeignKey(nameof(InvoiceId))]
        [InverseProperty("InvoiceLineItems")]
        public virtual Invoice Invoice { get; set; }
        [ForeignKey(nameof(ProductCode))]
        [InverseProperty(nameof(Product.InvoiceLineItems))]
        public virtual Product ProductCodeNavigation { get; set; }
    }
}
