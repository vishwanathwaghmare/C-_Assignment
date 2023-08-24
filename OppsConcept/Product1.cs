using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcept
{
    internal class Product1
    {
         static void Main(string[] args)
        {
             Console.WriteLine(" original Price of Mobile:");
             int amt1=Convert.ToInt32(Console.ReadLine());
             Product p1 = new Product(1, "mobile", amt1);

             Console.WriteLine("original Price of charger:");
             int amt2 = Convert.ToInt32(Console.ReadLine());
             Product p2 = new Product(2, "charger", amt2);

             Console.WriteLine("original Price of battery:");
             int amt3 = Convert.ToInt32(Console.ReadLine());
             Product p3 = new Product(3, "battery", amt3);

             Console.WriteLine("------------------------");
             Console.WriteLine(p1.Discount(5));
             Console.WriteLine(p2.Discount(20));
             Console.WriteLine(p3.Discount(10));


            // Creating and initializing a Product object using object initializer
            /*Product product = new Product
            {
                Id = 1,
                Name = "mobile",
                Price = 500000
            };

            // Printing the product details using ToString()
            Console.WriteLine(product.ToString());*/


        }
    }
}
