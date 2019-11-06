using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp8.Models.CustomEf
{
    public class CustomMovieContext : DbContext
    {
        public CustomMovieContext()
        {
        }

        public CustomMovieContext(DbContextOptions<CustomMovieContext> options) 
            : base(options)
        {
        }

        public DbSet<Movie> Movie { get; set; }
        public DbSet<Trailer> Trailer { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=(localdb)\\MsSqllocalDb;Database=MovieDb");
            }
        }
    }
}
