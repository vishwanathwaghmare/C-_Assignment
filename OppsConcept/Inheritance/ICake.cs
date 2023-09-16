using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcept.Inheritance
{
  

    // Define the Cake interface
    interface ICake
    {
        void bake();
    }

    // Create a class Strawberry that implements the Cake interface
    class Strawberry : ICake
    {
        public void bake()
        {
            Console.WriteLine("Strawberry cake is being baked.");
        }
    }

    // Create a class BlackForest that also implements the Cake interface
    class BlackForest :ICake
    {
        public void bake()
        {
            Console.WriteLine("Black Forest cake is being baked.");
        }
    }

    class Cake1
    {
        static void Main(string[] args)
        {
            ICake strawberryCake = new Strawberry();
            ICake blackForestCake = new BlackForest();

            strawberryCake.bake(); // Calls bake method of Strawberry class
            blackForestCake.bake(); // Calls bake method of BlackForest class
        }
    }

}
