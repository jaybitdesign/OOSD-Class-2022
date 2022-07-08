using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ProductsClassLibrary.Models
{
    public partial class State
    {
        public State()
        {
            Customers = new HashSet<Customer>();
        }

        [Key]
        [StringLength(2)]
        public string StateCode { get; set; }
        [Required]
        [StringLength(20)]
        public string StateName { get; set; }

        [InverseProperty(nameof(Customer.StateNavigation))]
        public virtual ICollection<Customer> Customers { get; set; }
    }
}
