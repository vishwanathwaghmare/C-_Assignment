using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcept.Overriding
{
    internal class MainProgram
    {
        static void Main(string[] args)
        {    //class kid
            Console.WriteLine("----------------------------------------------");
            Kid k=new Kid();
            k.ReadBook();
            Console.WriteLine("Enter the name of book");
            string sb=Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter number of pages");
            int pg=Convert.ToInt32(Console.ReadLine());
            k.ReadBook(sb,pg);

            BigKid bk=new BigKid();
            bk.ReadBook();

            Console.WriteLine();
            Console.WriteLine("----------------------------------------------");

            //Class Company
            Company company = new Company();
            Company ebay = new eBay();

            Console.WriteLine("ThinkQuotient pvt Pune");
            company.Address();

            Console.WriteLine("\n pimple nilakh pune");
            ebay.Address();
            Console.WriteLine("----------------------------------------------");

            //class vehicle
            Vehicle vehicle = new Vehicle();
            Vehicle car = new Car();

            Console.WriteLine(vehicle.Accelerate(50));
            Console.WriteLine(vehicle.Stop());
            Console.WriteLine(vehicle.Run());

            Console.WriteLine();

            Console.WriteLine(car.Accelerate(70));
            Console.WriteLine(car.Stop());
            Console.WriteLine(car.Run());
            Console.WriteLine("----------------------------------------------");
            Bike bike = new Bike("Red", 50);
            Pulsar pulsar = new Pulsar("Black", 100);

            Console.WriteLine("Bike Info:");
            bike.BikeInfo();

            Console.WriteLine("\nPulsar Info:");
            pulsar.BikeInfo();



        }
    }
}
