using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace InvoiceProducts.DatabaseModels
{
    public partial class Customer
    {
        public Customer()
        {
            Invoices = new HashSet<Invoice>();
        }

        [Key]
        [Column("CustomerID")]
        public int CustomerId { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string Name { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string Address { get; set; } = null!;
        [StringLength(20)]
        [Unicode(false)]
        public string City { get; set; } = null!;
        [StringLength(2)]
        [Unicode(false)]
        public string State { get; set; } = null!;
        [StringLength(15)]
        [Unicode(false)]
        public string ZipCode { get; set; } = null!;

        [ForeignKey("State")]
        [InverseProperty("Customers")]
        public virtual State StateNavigation { get; set; } = null!;
        [InverseProperty("Customer")]
        public virtual ICollection<Invoice> Invoices { get; set; }
    }
}
