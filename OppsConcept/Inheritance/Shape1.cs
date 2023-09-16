using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcept.Inheritance
{
    class Shape1
    {
        public virtual void DisplayInfo()
        {
            Console.WriteLine("This is a shape.");
        }
    }

    class Circle1 : Shape1
    {
        public override void DisplayInfo()
        {
            Console.WriteLine("This is a circle.");
        }
    }

    class ColoredCircle : Circle1
    {
        public string Color { get; set; }

        public ColoredCircle(string color)
        {
            Color = color;
        }

        public void DisplayColor()
        {
            Console.WriteLine($"This {Color} circle is part of multilevel inheritance.");
        }
    }
}
