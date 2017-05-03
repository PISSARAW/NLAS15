namespace NLAS15
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Personne")]
    public partial class Personne
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Personne()
        {
            Stage = new HashSet<Stage>();
            Visite = new HashSet<Visite>();
        }

        [Key]
        public int personne_id { get; set; }

        [StringLength(25)]
        public string nom_personne { get; set; }

        [StringLength(25)]
        public string prenom_personne { get; set; }

        [StringLength(4)]
        public string sexe_personne { get; set; }

        public DateTime? Date2naissance_personne { get; set; }

        [StringLength(25)]
        public string Lieu2naissance_personne { get; set; }

        [StringLength(25)]
        public string Telephone_personne { get; set; }

        [StringLength(25)]
        public string Email_personne { get; set; }

        public virtual Benevole Benevole { get; set; }

        public virtual Personnel Personnel { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Stage> Stage { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Visite> Visite { get; set; }

        public virtual Visiteur Visiteur { get; set; }
    }
}
