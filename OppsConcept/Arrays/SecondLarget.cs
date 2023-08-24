using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcept.Arrays
{
    public class SecondLarget
    {
        public static void print2Largest(int[]arr,int arr_size)
        {
            int i, first, second;

            if(arr_size<2)
            {
                Console.WriteLine("invalid input");
                return;
            }
            first = second = int.MinValue;
            for(i=0; i<arr_size; i++)
            {
                if (arr[i] > first)
                {
                    second = first;
                    first = arr[i];
                }

                else if (arr[i] > second && arr[i]!=first) 
                
                   second = arr[i];
                
            }
            if (second == int.MinValue)
                Console.WriteLine("there is no second largest value \n");
            else
                Console.WriteLine("the second largest element" +"is"+second);

        }
    }
}
