using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TechSupportData.DatabaseModels
{
    public partial class Customer
    {
        public Customer()
        {
            Incidents = new HashSet<Incident>();
            Registrations = new HashSet<Registration>();
        }

        [Key]
        [Column("CustomerID")]
        public int CustomerId { get; set; }
        [StringLength(50)]
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
        [StringLength(9)]
        [Unicode(false)]
        public string ZipCode { get; set; } = null!;
        [StringLength(20)]
        [Unicode(false)]
        public string? Phone { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? Email { get; set; }

        [ForeignKey("State")]
        [InverseProperty("Customers")]
        public virtual State StateNavigation { get; set; } = null!;
        [InverseProperty("Customer")]
        public virtual ICollection<Incident> Incidents { get; set; }
        [InverseProperty("Customer")]
        public virtual ICollection<Registration> Registrations { get; set; }
    }
}
