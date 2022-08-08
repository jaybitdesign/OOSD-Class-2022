using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace InvoiceProducts.DatabaseModels
{
    public partial class State
    {
        public State()
        {
            Customers = new HashSet<Customer>();
        }

        [Key]
        [StringLength(2)]
        [Unicode(false)]
        public string StateCode { get; set; } = null!;
        [StringLength(20)]
        [Unicode(false)]
        public string StateName { get; set; } = null!;

        [InverseProperty("StateNavigation")]
        public virtual ICollection<Customer> Customers { get; set; }
    }
}
