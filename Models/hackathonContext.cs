using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace HackatOrgan.Models
{
    public partial class hackathonContext : DbContext
    {
        public hackathonContext()
        {
        }

        public hackathonContext(DbContextOptions<hackathonContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Evenement> Evenements { get; set; }
        public virtual DbSet<Hackathon> Hackathons { get; set; }
        public virtual DbSet<Participant> Participants { get; set; }
        public virtual DbSet<ParticipantEvenement> ParticipantEvenements { get; set; }
        public virtual DbSet<Participation> Participations { get; set; }
        public virtual DbSet<TypeEvenement> TypeEvenements { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySQL("server=127.0.0.1;port=3307;user=root;password=;database=hackathon;sslmode=none");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Evenement>(entity =>
            {
                entity.HasKey(e => e.IdEvenement)
                    .HasName("PRIMARY");

                entity.ToTable("evenement");

                entity.HasIndex(e => e.IdHackathon, "id_hackathon");

                entity.HasIndex(e => e.IdTypeEvenement, "id_type_evenement");

                entity.Property(e => e.IdEvenement)
                    .HasColumnType("int(30)")
                    .HasColumnName("id_evenement");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasColumnName("date");

                entity.Property(e => e.HeureDebut).HasColumnName("heure_debut");

                entity.Property(e => e.HeureFin).HasColumnName("heure_fin");

                entity.Property(e => e.IdHackathon)
                    .HasColumnType("int(30)")
                    .HasColumnName("id_hackathon");

                entity.Property(e => e.IdTypeEvenement)
                    .HasColumnType("int(30)")
                    .HasColumnName("id_type_evenement");

                entity.Property(e => e.Theme)
                    .IsRequired()
                    .HasMaxLength(256)
                    .HasColumnName("theme");

                entity.HasOne(d => d.IdHackathonNavigation)
                    .WithMany(p => p.Evenements)
                    .HasForeignKey(d => d.IdHackathon)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("evenement_ibfk_1");

                entity.HasOne(d => d.IdTypeEvenementNavigation)
                    .WithMany(p => p.Evenements)
                    .HasForeignKey(d => d.IdTypeEvenement)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("evenement_ibfk_2");
            });

            modelBuilder.Entity<Hackathon>(entity =>
            {
                entity.HasKey(e => e.IdHackathon)
                    .HasName("PRIMARY");

                entity.ToTable("hackathon");

                entity.Property(e => e.IdHackathon)
                    .HasColumnType("int(30)")
                    .HasColumnName("id_hackathon");

                entity.Property(e => e.CodePostal)
                    .HasMaxLength(5)
                    .HasColumnName("code_postal")
                    .HasDefaultValueSql("'NULL'")
                    .IsFixedLength(true);

                entity.Property(e => e.DateDebut)
                    .HasColumnType("date")
                    .HasColumnName("date_debut");

                entity.Property(e => e.DateFin)
                    .HasColumnType("date")
                    .HasColumnName("date_fin")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DateLimite)
                    .HasColumnType("date")
                    .HasColumnName("date_limite")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.HeureDebut)
                    .HasColumnName("heure_debut")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.HeureFin)
                    .HasColumnName("heure_fin")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Image)
                    .HasMaxLength(256)
                    .HasColumnName("image")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Lieu)
                    .HasMaxLength(255)
                    .HasColumnName("lieu")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NbPlaces)
                    .HasColumnType("int(11)")
                    .HasColumnName("nb_places")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Rue)
                    .HasMaxLength(255)
                    .HasColumnName("rue")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Theme)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("theme");

                entity.Property(e => e.Ville)
                    .HasMaxLength(255)
                    .HasColumnName("ville")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<Participant>(entity =>
            {
                entity.HasKey(e => e.IdParticipant)
                    .HasName("PRIMARY");

                entity.ToTable("participant");

                entity.Property(e => e.IdParticipant)
                    .HasColumnType("int(30)")
                    .HasColumnName("id_participant");

                entity.Property(e => e.DateDeNaissance)
                    .HasColumnType("date")
                    .HasColumnName("date_de_naissance");

                entity.Property(e => e.LienPortfolio)
                    .HasMaxLength(256)
                    .HasColumnName("lien_portfolio")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Mail)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("mail");

                entity.Property(e => e.Mdp)
                    .IsRequired()
                    .HasMaxLength(256)
                    .HasColumnName("mdp");

                entity.Property(e => e.Nom)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("nom");

                entity.Property(e => e.Prenom)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("prenom");

                entity.Property(e => e.Téléphone)
                    .HasColumnType("int(10)")
                    .HasColumnName("téléphone")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<ParticipantEvenement>(entity =>
            {
                entity.ToTable("participant_evenement");

                entity.Property(e => e.ParticipantEvenementId)
                    .HasColumnType("int(30)")
                    .HasColumnName("participant_evenement_id");

                entity.Property(e => e.ParticipantEvenementEvenementId)
                    .HasColumnType("int(30)")
                    .HasColumnName("participant_evenement_evenement_id");

                entity.Property(e => e.ParticipantEvenementMail)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("participant_evenement_mail");

                entity.Property(e => e.ParticipantEvenementNom)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("participant_evenement_nom");

                entity.Property(e => e.ParticipantEvenementPrenom)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("participant_evenement_prenom");
            });

            modelBuilder.Entity<Participation>(entity =>
            {
                entity.HasKey(e => e.IdParticipation)
                    .HasName("PRIMARY");

                entity.ToTable("participation");

                entity.HasIndex(e => e.IdHackathon, "id_hackathon");

                entity.HasIndex(e => e.IdParticipant, "id_participant");

                entity.Property(e => e.IdParticipation)
                    .HasColumnType("int(30)")
                    .HasColumnName("id_participation");

                entity.Property(e => e.DateInscription)
                    .HasColumnType("date")
                    .HasColumnName("date_inscription");

                entity.Property(e => e.IdEvenement)
                    .HasColumnType("int(30)")
                    .HasColumnName("id_evenement")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.IdHackathon)
                    .HasColumnType("int(30)")
                    .HasColumnName("id_hackathon")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.IdParticipant)
                    .HasColumnType("int(30)")
                    .HasColumnName("id_participant");

                entity.HasOne(d => d.IdEvenementNavigation)
                    .WithMany(p => p.Participations)
                    .HasForeignKey(d => d.IdEvenement)
                    .HasConstraintName("participation_ibfk_3");

                entity.HasOne(d => d.IdHackathonNavigation)
                    .WithMany(p => p.Participations)
                    .HasForeignKey(d => d.IdHackathon)
                    .HasConstraintName("participation_ibfk_1");

                entity.HasOne(d => d.IdParticipantNavigation)
                    .WithMany(p => p.Participations)
                    .HasForeignKey(d => d.IdParticipant)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("participation_ibfk_2");
            });

            modelBuilder.Entity<TypeEvenement>(entity =>
            {
                entity.HasKey(e => e.IdType)
                    .HasName("PRIMARY");

                entity.ToTable("type_evenement");

                entity.Property(e => e.IdType)
                    .HasColumnType("int(30)")
                    .HasColumnName("id_type");

                entity.Property(e => e.NomType)
                    .IsRequired()
                    .HasMaxLength(256)
                    .HasColumnName("nom type");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
