using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ProductsClassLibrary.Models
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
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [Required]
        [StringLength(50)]
        public string Address { get; set; }
        [Required]
        [StringLength(20)]
        public string City { get; set; }
        [Required]
        [StringLength(2)]
        public string State { get; set; }
        [Required]
        [StringLength(15)]
        public string ZipCode { get; set; }

        [ForeignKey(nameof(State))]
        [InverseProperty("Customers")]
        public virtual State StateNavigation { get; set; }
        [InverseProperty(nameof(Invoice.Customer))]
        public virtual ICollection<Invoice> Invoices { get; set; }
    }
}
