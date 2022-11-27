using PostgreCSharpIntegration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace PostgreEfCSharpIntegration
{
    internal class Program
    {
        static void Main(string[] args)
        {

            using (var dbContext =new ShopContext())
            {
                // Add Method
                //dbContext.products.Add(new Product { Name = "tea", Price = 55 });
                //dbContext.SaveChanges();

                //ReadMethod
                var Products= dbContext.products;
                Products.ToList().ForEach (p => Console.WriteLine(p.Name + " " + p.Price)) ;
                int count=Products.Count();
            }

            Console.ReadLine();
        }
    }
}
