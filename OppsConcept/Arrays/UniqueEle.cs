using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcept.Arrays
{
    internal class UniqueEle
    {
        static void Main(string[] args)
        {
            int []arr = { 12, 20, 33, 33, 44, 52, 52 };
            Console.WriteLine("original array is");

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("The unique elements are");
            for (int i=0; i<arr.Length; i++)
            {
                bool isUnique = true;
                for(int j=0; j<i;j++ )
                {
                    if(arr[j] == arr[i] )
                    {
                        isUnique = false;
                        break;
                    }

                }
             
                if ( isUnique )
                {
                   
                    Console.WriteLine(arr[i]);
                }
            }
        }
    }
}
