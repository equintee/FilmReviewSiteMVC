using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace FilmReview.Models
{
    public partial class FilmReview_DBContext : DbContext
    {
        public FilmReview_DBContext()
        {
        }

        public FilmReview_DBContext(DbContextOptions<FilmReview_DBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ActorsTable> ActorsTables { get; set; }
        public virtual DbSet<ActorsToMovie> ActorsToMovies { get; set; }
        public virtual DbSet<DirectorTable> DirectorTables { get; set; }
        public virtual DbSet<DirectorsToMovie> DirectorsToMovies { get; set; }
        public virtual DbSet<MovieTable> MovieTables { get; set; }
        public virtual DbSet<ProducerTable> ProducerTables { get; set; }
        public virtual DbSet<ProducersToMovie> ProducersToMovies { get; set; }
        public virtual DbSet<RatingTable> RatingTables { get; set; }
        public virtual DbSet<UserTable> UserTables { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-SBTJQ6S\\SQLEXPRESS;Database=FilmReview_DB;User Id=filmreviewdb;Password=123");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<ActorsTable>(entity =>
            {
                entity.ToTable("ActorsTable");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Gender)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("gender");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<ActorsToMovie>(entity =>
            {
                entity.ToTable("ActorsToMovie");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ActorId).HasColumnName("actorID");

                entity.Property(e => e.MovieId).HasColumnName("movieID");

                entity.HasOne(d => d.Actor)
                    .WithMany(p => p.ActorsToMovies)
                    .HasForeignKey(d => d.ActorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ActorsToMovie_ActorsTable");

                entity.HasOne(d => d.Movie)
                    .WithMany(p => p.ActorsToMovies)
                    .HasForeignKey(d => d.MovieId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ActorsToMovie_MovieTable");
            });

            modelBuilder.Entity<DirectorTable>(entity =>
            {
                entity.ToTable("DirectorTable");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Gender)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("gender");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<DirectorsToMovie>(entity =>
            {
                entity.ToTable("DirectorsToMovie");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DirectorId).HasColumnName("directorID");

                entity.Property(e => e.MovieId).HasColumnName("movieID");

                entity.HasOne(d => d.Director)
                    .WithMany(p => p.DirectorsToMovies)
                    .HasForeignKey(d => d.DirectorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DirectorsToMovie_DirectorTable");

                entity.HasOne(d => d.Movie)
                    .WithMany(p => p.DirectorsToMovies)
                    .HasForeignKey(d => d.MovieId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DirectorsToMovie_MovieTable");
            });

            modelBuilder.Entity<MovieTable>(entity =>
            {
                entity.ToTable("MovieTable");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AverageRating).HasColumnName("averageRating");

                entity.Property(e => e.Genre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("genre");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.Language)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("language");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("name");

                entity.Property(e => e.RelaseDate)
                    .HasColumnType("date")
                    .HasColumnName("relaseDate");

                entity.Property(e => e.Subject)
                    .HasMaxLength(50)
                    .HasColumnName("subject");
            });

            modelBuilder.Entity<ProducerTable>(entity =>
            {
                entity.ToTable("ProducerTable");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Adress)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("adress");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<ProducersToMovie>(entity =>
            {
                entity.ToTable("ProducersToMovie");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MovieId).HasColumnName("movieID");

                entity.Property(e => e.ProducerId).HasColumnName("producerID");

                entity.HasOne(d => d.Movie)
                    .WithMany(p => p.ProducersToMovies)
                    .HasForeignKey(d => d.MovieId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProducersToMovie_MovieTable");

                entity.HasOne(d => d.Producer)
                    .WithMany(p => p.ProducersToMovies)
                    .HasForeignKey(d => d.ProducerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProducersToMovie_ProducerTable");
            });

            modelBuilder.Entity<RatingTable>(entity =>
            {
                entity.ToTable("RatingTable");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Comment)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("comment");

                entity.Property(e => e.CommentDate)
                    .HasColumnType("datetime")
                    .HasColumnName("commentDate");

                entity.Property(e => e.MovieId).HasColumnName("movieId");

                entity.Property(e => e.Rating).HasColumnName("rating");

                entity.Property(e => e.UserId).HasColumnName("userId");

                entity.HasOne(d => d.Movie)
                    .WithMany(p => p.RatingTables)
                    .HasForeignKey(d => d.MovieId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RatingTable_MovieTable");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.RatingTables)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RatingTable_UserTable");
            });

            modelBuilder.Entity<UserTable>(entity =>
            {
                entity.ToTable("UserTable");

                entity.HasIndex(e => e.Name, "IX_UserTable")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IsAdmin).HasColumnName("isAdmin");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("name");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("password");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
