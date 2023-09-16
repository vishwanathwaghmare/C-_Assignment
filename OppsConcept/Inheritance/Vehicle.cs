using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcept.Inheritance
{
    // hirearchical inheritance

    class Vehicle
    {
        public void Start()
        {
            Console.WriteLine("The vehicle is starting.");
        }
    }

    class Car : Vehicle
    {
        public void Drive()
        {
            Console.WriteLine("The car is driving.");
        }
    }

    class Bike : Vehicle
    {
        public void Ride()
        {
            Console.WriteLine("The bike is riding.");
        }
    }

   

}
