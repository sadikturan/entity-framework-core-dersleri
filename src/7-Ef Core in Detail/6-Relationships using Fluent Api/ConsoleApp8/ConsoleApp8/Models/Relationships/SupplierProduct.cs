using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp8.Models.Relationships
{
    public class SupplierProduct
    {
        //Composite Keys
        public int SId { get; set; }
        public Supplier Supplier { get; set; }

        public int PId { get; set; }
        public Product Product { get; set; }
    }
}
