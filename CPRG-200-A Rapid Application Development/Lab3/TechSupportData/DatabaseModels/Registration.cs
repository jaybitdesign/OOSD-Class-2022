using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TechSupportData.DatabaseModels
{
    public partial class Registration
    {
        [Key]
        [Column("CustomerID")]
        public int CustomerId { get; set; }
        [Key]
        [StringLength(10)]
        [Unicode(false)]
        public string ProductCode { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime RegistrationDate { get; set; }

        [ForeignKey("CustomerId")]
        [InverseProperty("Registrations")]
        public virtual Customer Customer { get; set; } = null!;
        [ForeignKey("ProductCode")]
        [InverseProperty("Registrations")]
        public virtual Product ProductCodeNavigation { get; set; } = null!;
    }
}
