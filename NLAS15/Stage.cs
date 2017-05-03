namespace NLAS15
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Stage")]
    public partial class Stage
    {
        [Key]
        public int stage_id { get; set; }

        public DateTime? Date2DebutStage { get; set; }

        public DateTime? Date2FinStage { get; set; }

        [StringLength(25)]
        public string Titre_stage { get; set; }

        [StringLength(25)]
        public string Taches_stage { get; set; }

        public int? personne_id { get; set; }

        [StringLength(25)]
        public string ligue_id { get; set; }

        public virtual Ligue Ligue { get; set; }

        public virtual Personne Personne { get; set; }
    }
}
