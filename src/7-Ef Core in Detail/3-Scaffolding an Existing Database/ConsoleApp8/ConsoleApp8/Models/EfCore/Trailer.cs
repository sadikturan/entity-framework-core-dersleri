using System;
using System.Collections.Generic;

namespace ConsoleApp8.Models.EfCore
{
    public partial class Trailer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Duration { get; set; }
        public int MovieId { get; set; }

        public Movie Movie { get; set; }
    }
}
