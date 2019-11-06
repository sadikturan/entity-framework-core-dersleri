using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp8.Models.Relationships
{
    public class DataContext : DbContext
    {
        public DataContext()
        {
        }

        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=(localdb)\\Mssqllocaldb;Database=ProductDb");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Product>()
            //     .HasOne(i => i.Category)
            //     .WithMany(i => i.Products)
            //     .HasForeignKey(i => i.CatId);

            modelBuilder.Entity<Category>()
                .HasMany(i => i.Products)
                .WithOne(i => i.Category)
                .HasForeignKey(i => i.CatId)
                .OnDelete(DeleteBehavior.Cascade);

            //composite keys
            modelBuilder.Entity<SupplierProduct>().HasKey(i => new { i.PId, i.SId });

            modelBuilder.Entity<SupplierProduct>()
                .HasOne(i => i.Product)
                .WithMany(i => i.SupplierProducts)
                .HasForeignKey(i => i.PId);

            modelBuilder.Entity<SupplierProduct>()
                .HasOne(i => i.Supplier)
                .WithMany(i => i.SupplierProducts)
                .HasForeignKey(i => i.SId);

            modelBuilder.Entity<Product>()
                .HasOne(i => i.ProductDetail)
                .WithOne(i => i.Product)
                .HasForeignKey<ProductDetail>(i => i.PrId);
        }

    }
}
