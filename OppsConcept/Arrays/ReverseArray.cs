using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcept.Arrays
{
    public class ReverseArray
    {
        static void Main(string[] args)
        {
            int[] arr = { 3, 90, 45, 29, 37, 78 };
            Console.WriteLine("original array");
            PrintArray(arr);
            ReverseArray1(arr); 
                             


            static void ReverseArray1(int[] arr)
            {
                int start = 0;
                int end = arr.Length - 1;

                while (start < end)
                {
                    int temp = arr[start];
                    arr[start] = arr[end];
                    arr[end] = temp;
                    start++;
                    end--;
                }
            }
            static void PrintArray(int[] arr)
            {
                foreach (int i in arr)
                {
                 Console.WriteLine(i);
                }
              
            }
            Console.WriteLine("reverse array");

            PrintArray(arr);
        }
    }
}
