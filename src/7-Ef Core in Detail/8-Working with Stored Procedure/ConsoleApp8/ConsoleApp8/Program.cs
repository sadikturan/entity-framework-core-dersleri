using ConsoleApp8.Models.EfCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Data.SqlClient;
using System.Linq;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            using (MovieContext db = new MovieContext())
            {
                //var p0 = new SqlParameter("@Name", "Movie");

                var movies = db.Database.ExecuteSqlCommand("CreateMovie @p0 @p1 @p2", new[] {"","","" });            
            }

            Console.ReadLine();
        }
    }
}
