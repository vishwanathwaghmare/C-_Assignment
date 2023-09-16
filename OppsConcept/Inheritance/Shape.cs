using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcept.Inheritance
{
    class Shape
    {
        public virtual void DisplayInfo()
        {
            Console.WriteLine("This is a shape.");
        }
    }

    class Circle : Shape
    {
        public override void DisplayInfo()
        {
            Console.WriteLine("This is a circle.");
        }
    }

    class Rectangle : Shape
    {
        public override void DisplayInfo()
        {
            Console.WriteLine("This is a rectangle.");
        }
    }
}
