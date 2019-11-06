using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp8.Models.Relationships
{
    public class Supplier
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }

        public ICollection<SupplierProduct> SupplierProducts { get; set; }
    }
}
