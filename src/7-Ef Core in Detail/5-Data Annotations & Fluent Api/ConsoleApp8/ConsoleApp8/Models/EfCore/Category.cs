using System;
using System.Collections.Generic;

namespace ConsoleApp8.Models.EfCore
{
    public partial class Category
    {
        public Category()
        {
            MovieCategory = new HashSet<MovieCategory>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<MovieCategory> MovieCategory { get; set; }
    }
}
