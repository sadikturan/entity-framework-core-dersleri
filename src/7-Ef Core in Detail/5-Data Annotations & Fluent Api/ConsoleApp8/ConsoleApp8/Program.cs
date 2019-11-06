using ConsoleApp8.Models.CustomEf;
using ConsoleApp8.Models.DataAnnotations;
using ConsoleApp8.Models.FluentApi;
using System;
using System.Linq;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            fluentApiUrunContext db = new fluentApiUrunContext();

            foreach (var item in db.Urunler.ToList())
            {
                Console.WriteLine(item.UrunAdi);
            }

            Console.ReadLine();
        }
    }
}
