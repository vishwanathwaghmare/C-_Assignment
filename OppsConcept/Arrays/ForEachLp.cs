using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcept.Arrays
{
    internal class ForEachLp
    {
        static void Main(string[] args)
        {
            /*int[] arr = { 10, 20, 30, 40, 50 };

            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }*/

            int[,] arr1 = new int[3, 4]
            {
                {1,2, 3, 4},
                {5,6,7,8 },
                {9,10,11,12}
            };
            foreach(var item in arr1)
            {
                Console.Write(item  + " ");
            }
            Console.WriteLine();
        }
    }
}
