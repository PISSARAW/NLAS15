namespace NLAS15
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Admin> Admin { get; set; }
        public virtual DbSet<Benevole> Benevole { get; set; }
        public virtual DbSet<Ligue> Ligue { get; set; }
        public virtual DbSet<Personne> Personne { get; set; }
        public virtual DbSet<Personnel> Personnel { get; set; }
        public virtual DbSet<Stage> Stage { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Visite> Visite { get; set; }
        public virtual DbSet<Visiteur> Visiteur { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Admin>()
                .Property(e => e.Users)
                .IsUnicode(false);

            modelBuilder.Entity<Admin>()
                .Property(e => e.Nom)
                .IsUnicode(false);

            modelBuilder.Entity<Admin>()
                .Property(e => e.Prenom)
                .IsUnicode(false);

            modelBuilder.Entity<Admin>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<Admin>()
                .Property(e => e.Roles)
                .IsUnicode(false);

            modelBuilder.Entity<Admin>()
                .Property(e => e.Permission)
                .IsUnicode(false);

            modelBuilder.Entity<Benevole>()
                .Property(e => e.Association_benevole)
                .IsUnicode(false);

            modelBuilder.Entity<Benevole>()
                .Property(e => e.ligue_id)
                .IsUnicode(false);

            modelBuilder.Entity<Ligue>()
                .Property(e => e.ligue_id)
                .IsUnicode(false);

            modelBuilder.Entity<Personne>()
                .Property(e => e.nom_personne)
                .IsUnicode(false);

            modelBuilder.Entity<Personne>()
                .Property(e => e.prenom_personne)
                .IsUnicode(false);

            modelBuilder.Entity<Personne>()
                .Property(e => e.sexe_personne)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Personne>()
                .Property(e => e.Lieu2naissance_personne)
                .IsUnicode(false);

            modelBuilder.Entity<Personne>()
                .Property(e => e.Telephone_personne)
                .IsUnicode(false);

            modelBuilder.Entity<Personne>()
                .Property(e => e.Email_personne)
                .IsUnicode(false);

            modelBuilder.Entity<Personne>()
                .HasOptional(e => e.Benevole)
                .WithRequired(e => e.Personne);

            modelBuilder.Entity<Personne>()
                .HasOptional(e => e.Personnel)
                .WithRequired(e => e.Personne);

            modelBuilder.Entity<Personne>()
                .HasOptional(e => e.Visiteur)
                .WithRequired(e => e.Personne);

            modelBuilder.Entity<Stage>()
                .Property(e => e.Titre_stage)
                .IsUnicode(false);

            modelBuilder.Entity<Stage>()
                .Property(e => e.Taches_stage)
                .IsUnicode(false);

            modelBuilder.Entity<Stage>()
                .Property(e => e.ligue_id)
                .IsUnicode(false);

            modelBuilder.Entity<Visite>()
                .Property(e => e.Heure2Visite)
                .HasPrecision(2);

            modelBuilder.Entity<Visite>()
                .Property(e => e.ligue_id)
                .IsUnicode(false);
        }
    }
}
