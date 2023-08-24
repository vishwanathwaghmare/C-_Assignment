using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcept.Arrays
{
    public class OddIndex
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 23, 45, 63, 76, 13, 15, 35, 25, 64, 78, 23 };


            for(int i=0; i<arr.Length; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine($" element at index {i}:{arr[i]}");
                }
            }
        }
    }
}
