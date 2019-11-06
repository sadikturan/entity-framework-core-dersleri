using ConsoleApp8.Models.EfCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {

            using (MovieContext db = new MovieContext())
            {
                string name = "Movie 1";

                var movies = db.Movie
                    .FromSql($"select * from dbo.Movie where Name={name}")
                    .Select(i => new
                    {
                        i.Name
                    })
                    .OrderBy(i => i.Name)
                    .ToList();

                foreach (var movie in movies)
                {
                    Console.WriteLine(movie.Name);
                }

            }

            Console.ReadLine();
        }
    }
}
