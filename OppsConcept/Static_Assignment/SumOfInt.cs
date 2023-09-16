using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcept.Static_Assignment
{
    internal class SumOfInt
    {
        static void Main(string[] args)
        {
            int result = SumIntegers(5, 10, 15, 20, 25);
            Console.WriteLine($"Sum of integers: {result}");
        }

        static int SumIntegers(params int[] numbers)
        {
            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }
            return sum;
        }
    }
}
