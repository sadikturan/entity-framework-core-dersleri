using System;
using System.Collections.Generic;

namespace ConsoleApp8.Models.EfCore
{
    public partial class Movie
    {
        public Movie()
        {
            MovieCategory = new HashSet<MovieCategory>();
            Trailer = new HashSet<Trailer>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public MovieDetail MovieDetail { get; set; }
        public ICollection<MovieCategory> MovieCategory { get; set; }
        public ICollection<Trailer> Trailer { get; set; }
    }
}
