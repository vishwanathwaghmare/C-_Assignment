using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcept.Inheritance
{
    

    // Define the IceCream interface
    interface IceCream
    {
        void eat();
    }

    // Define the Juice interface
    interface Juice
    {
        void drink();
    }

    // Create a class Mastani that implements both interfaces
    class Mastani : IceCream, Juice
    {
        public void eat()
        {
            Console.WriteLine("Mastani is eating ice cream.");
        }

        public void drink()
        {
            Console.WriteLine("Mastani is drinking juice.");
        }
    }

    class IceCream1
    {
        static void Main(string[] args)
        {
            Mastani mastani = new Mastani();

            mastani.eat();   // Calls the eat method from the IceCream interface
            mastani.drink(); // Calls the drink method from the Juice interface
        }
    }

}
