namespace NLAS15
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Admin")]
    public partial class Admin
    {
        [Key]
        [StringLength(25)]
        public string Users { get; set; }

        [StringLength(25)]
        public string Nom { get; set; }

        [StringLength(25)]
        public string Prenom { get; set; }

        [StringLength(25)]
        public string Password { get; set; }

        [StringLength(25)]
        public string Roles { get; set; }

        [StringLength(25)]
        public string Permission { get; set; }
    }
}
