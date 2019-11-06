using System;
using System.Collections.Generic;

namespace ConsoleApp8.Models.EfCore
{
    public partial class MovieCategory
    {
        public int Id { get; set; }
        public int MovieId { get; set; }
        public int CategoryId { get; set; }

        public Category Category { get; set; }
        public Movie Movie { get; set; }
    }
}
