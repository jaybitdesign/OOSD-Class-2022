using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ProductsClassLibrary.Models
{
    public partial class Product
    {
        public Product()
        {
            InvoiceLineItems = new HashSet<InvoiceLineItem>();
        }

        [Key]
        [StringLength(10)]
        public string ProductCode { get; set; }
        [Required]
        [StringLength(50)]
        public string Description { get; set; }
        [Column(TypeName = "money")]
        public decimal UnitPrice { get; set; }
        public int OnHandQuantity { get; set; }

        [InverseProperty(nameof(InvoiceLineItem.ProductCodeNavigation))]
        public virtual ICollection<InvoiceLineItem> InvoiceLineItems { get; set; }
    }
}
