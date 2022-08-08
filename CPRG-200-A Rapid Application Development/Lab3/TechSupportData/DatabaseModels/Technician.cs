using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TechSupportData.DatabaseModels
{
    public partial class Technician
    {
        public Technician()
        {
            Incidents = new HashSet<Incident>();
        }

        [Key]
        [Column("TechID")]
        public int TechId { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string Name { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string Email { get; set; } = null!;
        [StringLength(20)]
        [Unicode(false)]
        public string Phone { get; set; } = null!;

        [InverseProperty("Tech")]
        public virtual ICollection<Incident> Incidents { get; set; }
    }
}
