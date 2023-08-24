using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcept
{
    public class Product
    {
        private int id;
        private string name;
        private double price;

        public Product(int id, string name, double price)
        {
            this.id = id;
            this.name = name;
            this.price = price;
        }

        public string Discount(double disc)
        {
            price=price-((price/100)*disc);
            return $"product id:{id}\n Name:{name}\nPrice{price}";
        }

       // using property  
   /* public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public override string ToString()
        {
            return $"Product ID: {Id}, Name: {Name}, Price: {Price:C}";
        }*/
    }
}
