namespace NLAS15
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Visiteur")]
    public partial class Visiteur
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int personne_id { get; set; }

        public virtual Personne Personne { get; set; }
    }
}
