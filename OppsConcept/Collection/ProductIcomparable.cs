using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcept.Collection
{
    public class ProductIcomparable:IComparable
    {
        private int price;
        private string name;
        public ProductIcomparable(int price, string name)
        {
            this.price = price;
            this.name = name;
        }

        public int CompareTo(object obj) 
        {


            ProductIcomparable p = (ProductIcomparable)obj; 
            if (this.price > p.price)
            {
                return 1;
            }
            else if (this.price < p.price)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        public override string ToString()
        {
            return $"{price} -> {name}";
        }


    }




  public class IComparableEx
    {
        static void Main(string[] args)
        {
            ProductIcomparable p1 = new ProductIcomparable(12000, "Mobile");
            ProductIcomparable p2 = new ProductIcomparable(70000, "Laptop");

            int result = p1.CompareTo(p2);
            if (result == 1)
            {
                Console.WriteLine("Mobile price is more than laptop");
            }
            else if (result == -1)
            {
                Console.WriteLine("Mobile price is less than laptop");
            }
            else
            {
                Console.WriteLine("Mobile and Laptop has same price");
            }
        }


    }

}


