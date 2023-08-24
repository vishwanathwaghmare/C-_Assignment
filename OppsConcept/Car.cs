using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcept
{
    using System;

   public class Car
    {
        public string Model { get; set; }
        public static int TotalCarSold { get; private set; }

        public Car(string model)
        {
            Model = model;
            TotalCarSold++;
        }
    }

   public class Car1
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Toyota");
            Car car2 = new Car("Honda");
            Car car3 = new Car("Ford");

            Console.WriteLine($"Total cars sold: {Car.TotalCarSold}"); 
        }
    }

}
