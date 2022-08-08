using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FishTracker
{
    public partial class Catch
    {
        [StringLength(50)]
        [Unicode(false)]
        public string CatchSpecies { get; set; } = null!;
        [Column(TypeName = "smalldatetime")]
        public DateTime CatchDate { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string? CatchLocation { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string? CatchTackle { get; set; }
        [Unicode(false)]
        public string? CatchNotes { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal? CatchWeight { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal? CatchLength { get; set; }
        [Unicode(false)]
        public string? CatchPhoto { get; set; }
        [Key]
        [Column("CatchID")]
        public int CatchId { get; set; }
    }
}
