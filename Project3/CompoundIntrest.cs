using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    internal class CompoundIntrest
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Principal(P):");
            double principal=Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Time(T):");
            double time = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Rate of Intrest(R):");
            double rate = Convert.ToDouble(Console.ReadLine());

            rate = rate / 100;

            double compoundInt = principal * Math.Pow((1 + rate), time) - principal;

            Console.WriteLine($"The compound intrest:{compoundInt:f2}");


        }
    }
}
