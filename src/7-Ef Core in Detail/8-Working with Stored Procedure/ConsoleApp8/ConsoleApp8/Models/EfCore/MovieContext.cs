using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ConsoleApp8.Models.EfCore
{
    public partial class MovieContext : DbContext
    {
        public MovieContext()
        {
        }

        public MovieContext(DbContextOptions<MovieContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Movie> Movie { get; set; }
        public virtual DbSet<MovieCategory> MovieCategory { get; set; }
        public virtual DbSet<MovieDetail> MovieDetail { get; set; }
        public virtual DbSet<Trailer> Trailer { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=(localdb)\\Mssqllocaldb;Database=MovieDb");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Movie>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<MovieCategory>(entity =>
            {
                entity.HasOne(d => d.Category)
                    .WithMany(p => p.MovieCategory)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MovieCategory_Category");

                entity.HasOne(d => d.Movie)
                    .WithMany(p => p.MovieCategory)
                    .HasForeignKey(d => d.MovieId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MovieCategory_Movie");
            });

            modelBuilder.Entity<MovieDetail>(entity =>
            {
                entity.HasIndex(e => e.MovieId)
                    .IsUnique();

                entity.Property(e => e.Duration)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Year)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Movie)
                    .WithOne(p => p.MovieDetail)
                    .HasForeignKey<MovieDetail>(d => d.MovieId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MovieDetail_Movie");
            });

            modelBuilder.Entity<Trailer>(entity =>
            {
                entity.Property(e => e.Duration)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Movie)
                    .WithMany(p => p.Trailer)
                    .HasForeignKey(d => d.MovieId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Trailer_Movie");
            });
        }
    }
}
