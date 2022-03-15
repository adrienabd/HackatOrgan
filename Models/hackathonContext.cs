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
        public virtual DbSet<Participantevenement> Participantevenements { get; set; }
        public virtual DbSet<Participation> Participations { get; set; }
        public virtual DbSet<Typeevenement> Typeevenements { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning /*To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.*/
                optionsBuilder.UseMySQL("server=127.0.0.7;port=3307;user=root;database=hackathon;sslmode=none;convert zero datetime=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Evenement>(entity =>
            {
                entity.HasKey(e => e.IdEvenement)
                    .HasName("PRIMARY");

                entity.ToTable("evenement");

                entity.HasIndex(e => e.IdHackathon, "Evenement_ibfk_1");

                entity.HasIndex(e => e.IdTypeEvenement, "IdTypeEvenement");

                entity.Property(e => e.IdEvenement).HasColumnType("int(30)");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.IdHackathon).HasColumnType("int(30)");

                entity.Property(e => e.IdTypeEvenement).HasColumnType("int(30)");

                entity.Property(e => e.Theme)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.HasOne(d => d.IdHackathonNavigation)
                    .WithMany(p => p.Evenements)
                    .HasForeignKey(d => d.IdHackathon)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Evenement_ibfk_1");

                entity.HasOne(d => d.IdTypeEvenementNavigation)
                    .WithMany(p => p.Evenements)
                    .HasForeignKey(d => d.IdTypeEvenement)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Evenement_ibfk_2");
            });

            modelBuilder.Entity<Hackathon>(entity =>
            {
                entity.HasKey(e => e.IdHackathon)
                    .HasName("PRIMARY");

                entity.ToTable("hackathon");

                entity.Property(e => e.IdHackathon).HasColumnType("int(30)");

                entity.Property(e => e.CodePostal)
                    .HasMaxLength(5)
                    .HasDefaultValueSql("'NULL'")
                    .IsFixedLength(true);

                entity.Property(e => e.DateDebut).HasColumnType("date");

                entity.Property(e => e.DateFin)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DateLimite)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.HeureDebut).HasDefaultValueSql("'NULL'");

                entity.Property(e => e.HeureFin).HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Image)
                    .HasMaxLength(256)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Lieu)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NbPlaces)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Rue)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Theme)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Ville)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<Participant>(entity =>
            {
                entity.HasKey(e => e.IdParticipant)
                    .HasName("PRIMARY");

                entity.ToTable("participant");

                entity.Property(e => e.IdParticipant).HasColumnType("int(30)");

                entity.Property(e => e.DateDeNaissance).HasColumnType("date");

                entity.Property(e => e.LienPortfolio)
                    .HasMaxLength(256)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Mail)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Mdp)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.Nom)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Prenom)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Telephone)
                    .HasColumnType("int(10)")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<Participantevenement>(entity =>
            {
                entity.ToTable("participantevenement");

                entity.HasIndex(e => e.IdEvenement, "IdEvenement");

                entity.Property(e => e.Id).HasColumnType("int(30)");

                entity.Property(e => e.IdEvenement).HasColumnType("int(30)");

                entity.Property(e => e.Mail)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Nom)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.Prenom)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.HasOne(d => d.IdEvenementNavigation)
                    .WithMany(p => p.Participantevenements)
                    .HasForeignKey(d => d.IdEvenement)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ParticipantEvenement_ibfk_1");
            });

            modelBuilder.Entity<Participation>(entity =>
            {
                entity.HasKey(e => e.IdParticipation)
                    .HasName("PRIMARY");

                entity.ToTable("participation");

                entity.HasIndex(e => e.IdParticipant, "IdParticipant");

                entity.HasIndex(e => e.IdHackathon, "Participation_ibfk_1");

                entity.Property(e => e.IdParticipation).HasColumnType("int(30)");

                entity.Property(e => e.DateInscription).HasColumnType("date");

                entity.Property(e => e.IdHackathon)
                    .HasColumnType("int(30)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.IdParticipant).HasColumnType("int(30)");

                entity.HasOne(d => d.IdHackathonNavigation)
                    .WithMany(p => p.Participations)
                    .HasForeignKey(d => d.IdHackathon)
                    .HasConstraintName("Participation_ibfk_1");

                entity.HasOne(d => d.IdParticipantNavigation)
                    .WithMany(p => p.Participations)
                    .HasForeignKey(d => d.IdParticipant)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Participation_ibfk_2");
            });

            modelBuilder.Entity<Typeevenement>(entity =>
            {
                entity.HasKey(e => e.IdType)
                    .HasName("PRIMARY");

                entity.ToTable("typeevenement");

                entity.Property(e => e.IdType).HasColumnType("int(30)");

                entity.Property(e => e.NomType)
                    .IsRequired()
                    .HasMaxLength(256)
                    .HasColumnName("Nom type");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
