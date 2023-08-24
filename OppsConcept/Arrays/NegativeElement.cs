using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcept.Arrays
{
    public class NegativeElement
    {
        static void Main(string[] args)
        {
            int[] arr = { 3, -4, -3, 5, 6, -6, 10 };
            int count = 0;

            foreach (int i in arr)
            {
                if (i < 0)
                {
                    Console.WriteLine(i + "is negative element in array ");
                    count++;
                }
            }
            Console.WriteLine("count of total negative element in array is:"+count);
        }
    }
}
