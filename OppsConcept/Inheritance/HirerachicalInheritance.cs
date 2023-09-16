using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcept.Inheritance
{
    internal class HirerachicalInheritance
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------Vehicle ------------------");
            Car myCar = new Car();
            Bike myBike = new Bike();

            myCar.Start();
            myCar.Drive();

            myBike.Start();
            myBike.Ride();

            Console.WriteLine("-----------------Shape ------------------");

            Shape myShape = new Shape();
            Circle myCircle = new Circle();
            Rectangle myRectangle = new Rectangle();

            myShape.DisplayInfo();
            myCircle.DisplayInfo();
            myRectangle.DisplayInfo();
        }
    }
}
