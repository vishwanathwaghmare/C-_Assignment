using OppsConcept.Methods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcept.Methods
{
    internal class ProdDiscount
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public override string ToString()
        {
            return $"Product ID: {Id}, Name: {Name}, Price: {Price:C}";
        }

        public void ApplyDiscount(decimal discountPercentage)
        {
            if (discountPercentage < 0 || discountPercentage > 100)
            {
                Console.WriteLine("Invalid discount percentage. Please provide a value between 0 and 100.");
                return;
            }

            decimal discountAmount = (discountPercentage / 100) * Price;
            Price -= discountAmount;
        }
    }
}



class ProdDisc1
{
    static void Main(string[] args)
    {
        // Creating and initializing a Product object using object initializer
        ProdDiscount product = new ProdDiscount
        {
            Id = 1,
            Name = "laptop",
            Price = 100
        };

        // Displaying the original product details
        Console.WriteLine("Original Product Details:");
        Console.WriteLine(product.ToString());

        // Applying a discount
        Console.Write("\nEnter Discount Percentage: ");
        decimal discountPercentage = decimal.Parse(Console.ReadLine());
        product.ApplyDiscount(discountPercentage);

        // Displaying updated product details after applying discount
        Console.WriteLine("\nProduct Details After Applying Discount:");
        Console.WriteLine(product.ToString());
    }
}
