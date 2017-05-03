namespace NLAS15
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Visite")]
    public partial class Visite
    {
        [Key]
        public int visite_id { get; set; }

        public DateTime? Date2Visite { get; set; }

        public TimeSpan? Heure2Visite { get; set; }

        public int? personne_id { get; set; }

        [StringLength(25)]
        public string ligue_id { get; set; }

        public virtual Ligue Ligue { get; set; }

        public virtual Personne Personne { get; set; }
    }
}
