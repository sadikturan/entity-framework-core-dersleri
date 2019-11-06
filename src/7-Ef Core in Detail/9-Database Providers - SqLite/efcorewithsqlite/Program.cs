using System;
using efcorewithsqlite.Models;

namespace efcorewithsqlite
{
    class Program
    {
        static void Main(string[] args)
        {
           using (DataContext db=new DataContext())
           {
              db.Products.Add(new Product(){ Name="IPhone 8", Price="4000"});

              db.SaveChanges();

           }         


        }
    }
}
