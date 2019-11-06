using EfCoreTransactions.Models;
using System;
using System.Linq;

namespace EfCoreTransactions
{
    class Program
    {
        static void Main(string[] args)
        {
            using (NorthwindContext db = new NorthwindContext())
            {
                using (var transaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        var products = db.Products.Take(5).ToList();

                        foreach (var item in products)
                        {
                            Console.WriteLine("updating product is : {0}", item.ProductId);

                            item.UnitsInStock += 100;
                            db.SaveChanges();

                            if (item == products[4])
                            {
                                item.UnitsInStock += 32765;
                            }
                            db.SaveChanges();
                        }

                        transaction.Commit();
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        Console.WriteLine("error...");
                    }

                }
            }
        }
    }
}
