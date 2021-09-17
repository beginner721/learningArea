using System;
using System.Linq;

namespace EntityFrameworkDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //.net içinde ADO.NET var, bu veritabanına bağlanıp kontrol etmemizi sağlayan bir kütüphane ancak eski bi sistem
            //günümüzde bu süreçleri kolaylaştırmak adına EntityFramework adında ORM (object relational mapping) yapısını kullanırız, orm ; class ile objelerimizi ilişkilendirir.

            //GetAll();
            GetProductsByCategory(1);

        }

        private static void GetAll()
        {
            NorthwindContext northwindContext = new NorthwindContext();
            foreach (var product in northwindContext.Products)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        private static void GetProductsByCategory(int categoryId)
        {
            NorthwindContext northwindContext = new NorthwindContext();
            var result = northwindContext.Products.Where(p => p.CategoryId == categoryId);
            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
        }
    }
}
