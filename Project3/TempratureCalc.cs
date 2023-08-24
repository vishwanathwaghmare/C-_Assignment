using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    internal class TempratureCalc
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter temperature in celsius:");
            double celsius=Convert.ToDouble(Console.ReadLine());

            double fahrenheit = (celsius * 9 / 5) + 32;

            Console.WriteLine($"Temprature in Fehrenhite:{fahrenheit:F2} 'F ");
        }

    }
}
