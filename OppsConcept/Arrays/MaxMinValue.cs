using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcept.Arrays
{
    internal class MaxMinValue
    {
        static void Main(string[] args)
        {
            //int[] arr = new int [5];
            int[] arr = {10,12,11,2,25,21};
            /*for (int i=0; i<arr.Length; i++)
            {
                //Console.WriteLine(i);
               // arr[i] = Convert.ToInt32(Console.ReadLine());
            }*/
            int n = arr[0];
            for (int i=0;i<arr.Length ; i++)
            {
                if (arr[i] > n)
                {
                    n= arr[i];
                }
            }
            Console.WriteLine($"Max Value is:{n}");
            int m = arr[0];
            for(int i=0;i<arr.Length ;i++)
            {
                if (arr[i] < m)
                {
                    m= arr[i];
                }
            }
            Console.WriteLine($"Min Value is:{m}");
        }
    }
}
