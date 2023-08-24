using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcept.Arrays
{
    internal class MethodArr
    {
        public static int Average(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum / array.Length;
        }

        public static double Average(double[] array)
        {
            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum / array.Length;
        }

        static void Main(string[] args)
        {
            int[] intArray = { 1, 2, 3, 4, 5 };
            double[] doubleArray = { 1.5, 2.5, 3.5, 4.5, 5.5 };

            int intAvg = Average(intArray);
            double doubleAvg = Average(doubleArray);

            Console.WriteLine("Average of intArray: " + intAvg);
            Console.WriteLine("Average of doubleArray: " + doubleAvg);
        }
    }
}


