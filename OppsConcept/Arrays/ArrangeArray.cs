using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcept.Arrays
{
    // write c# program to arrange the element of an given array of integers where all negative integers appear
    //before  all the positive numbers.
    public class ArrangeArray
    {
        static void Main(string[] args)
        {
            int[] arr = { 11, -4, 3, -7, 65, 78, 33, 75, -76, -60 };

            Array.Sort(arr);

            foreach(int num in arr)
            {
                Console.WriteLine(num);
            }
        }
    }
}
