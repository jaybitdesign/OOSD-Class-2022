using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TechSupportData.DatabaseModels
{
    public partial class Product
    {
        public Product()
        {
            Incidents = new HashSet<Incident>();
            Registrations = new HashSet<Registration>();
        }

        [Key]
        [StringLength(10)]
        [Unicode(false)]
        public string ProductCode { get; set; } = null!;

        [StringLength(50)]
        [Unicode(false)]
        public string Name { get; set; } = null!;

        [Column(TypeName = "decimal(18, 1)")]
        public decimal Version { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime ReleaseDate { get; set; }

        [InverseProperty("ProductCodeNavigation")]
        public virtual ICollection<Incident> Incidents { get; set; }

        [InverseProperty("ProductCodeNavigation")]
        public virtual ICollection<Registration> Registrations { get; set; }

        public override string ToString()
        {
            return 
                ProductCode.PadRight(10) + "| " + 
                Name.PadRight(50) + "| " + 
                Version.ToString().PadRight(18) + "| " + 
                ReleaseDate;
        }
    }
}
