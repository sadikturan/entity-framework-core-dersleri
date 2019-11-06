using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp8.Models.DataAnnotations
{

    public class UrunContext : DbContext
    {
        public UrunContext()
        {
        }

        public UrunContext(DbContextOptions<UrunContext> options)
            : base(options)
        {
        }

        public DbSet<Urun> Urunler { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=(localdb)\\MsSqllocalDb;Database=MovieDb");
            }
        }

    }
}
