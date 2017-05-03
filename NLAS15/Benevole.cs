namespace NLAS15
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Benevole")]
    public partial class Benevole
    {
        public DateTime? Date2Debut_benevole { get; set; }

        public DateTime? Date2Fin_benevole { get; set; }

        [StringLength(25)]
        public string Association_benevole { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int personne_id { get; set; }

        [StringLength(25)]
        public string ligue_id { get; set; }

        public virtual Ligue Ligue { get; set; }

        public virtual Personne Personne { get; set; }
    }
}
