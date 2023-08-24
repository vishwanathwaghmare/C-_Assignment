using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcept.Overriding
{
    internal class Vehicle
    {
        public virtual string Accelerate(long mph)
        {
            return $"Vehicle is accelerating at {mph} mph.";
        }

        public string Stop()
        {
            return "Vehicle is stopped.";
        }

        public string Run()
        {
            return "Vehicle is running.";
        }
    }
    class Car : Vehicle
    {
        public override string Accelerate(long mph)
        {
            return $"Car is accelerating at {mph} mph.";
        }
    }
}
