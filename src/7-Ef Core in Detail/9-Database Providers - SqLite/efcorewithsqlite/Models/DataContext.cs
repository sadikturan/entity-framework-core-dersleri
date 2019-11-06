
using Microsoft.EntityFrameworkCore;

namespace efcorewithsqlite.Models
{
    public class DataContext:DbContext
    {
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=database.db");
        }
    }


}