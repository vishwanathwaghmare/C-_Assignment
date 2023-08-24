using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcept.Arrays
{
    internal class AscArry
    {
        static void Main(string[] args)
        {
            int[] arr = {45,67,12,89,5};

            for(int i=0; i<arr.Length; i++)
            {
                for(int j=0; j<arr.Length; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        int temp ;
                        temp= arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;

                    }
                    

                }
            }
            Console.WriteLine("asc order");
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            
        }
    }
}
