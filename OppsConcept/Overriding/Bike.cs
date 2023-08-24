using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcept.Overriding
{
    internal class Bike
    {
        protected string color;
        protected int speed;

        public Bike(string color, int speed)
        {
            this.color = color;
            this.speed = speed;
        }

        public virtual void BikeInfo()
        {
            Console.WriteLine($"Bike color: {color}");
            Console.WriteLine($"Bike speed: {speed} mph");
        }
    }
    class Pulsar : Bike
    {
        public Pulsar(string color, int speed) : base(color, speed)
        {
        }

        public override void BikeInfo()
        {
            Console.WriteLine($"Pulsar color: {color}");
            Console.WriteLine($"Pulsar speed: {speed} mph");
        }
    }
}
