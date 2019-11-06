using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp8.Models.Relationships
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public int CatId { get; set; }
        public Category Category { get; set; }

        public ProductDetail ProductDetail { get; set; }

        public ICollection<SupplierProduct> SupplierProducts { get; set; }
    }
}
