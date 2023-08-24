using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcept
{
    public class SumUsingmethod
    {
        static int Sum(params int[] numbers)
        {
            int totalSum = 0;
            foreach (int num in numbers)
            {
                totalSum += num;
            }
            return totalSum;
        }


        static void Main(string[] args)
        {
            int result1 = Sum(1, 2, 3, 4, 5);
            int result2 = Sum(10, 20, 30);

            Console.WriteLine($"Sum of numbers in result1: {result1}"); 
            Console.WriteLine($"Sum of numbers in result2: {result2}");




        }
    }


}
