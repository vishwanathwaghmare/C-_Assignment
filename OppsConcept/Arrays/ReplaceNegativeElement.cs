using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcept.Arrays
{
    internal class ReplaceNegativeElement
    {
        static void Main(string[] args)
        {
            int[] arr = { 12, 3, -19, 29, 5, -61, 44, 7, -9 };
            int[] Array = NegativeReplace(arr);

            foreach(int num in arr)
            {
                Console.WriteLine(num + "");
            }

        }
        static int[] NegativeReplace(int[] arr) 
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0 && i > 0)
                {
                    arr[i] = arr[i - 1] *arr[i - 1];
                }
            }
            return arr;
        }
    }
}
