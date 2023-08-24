using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcept.Arrays
{
    public class AlternateElement
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("Enter number of elements in array");
           // int num=Convert.ToInt32(Console.ReadLine());

            int[] arr = {12,13,15,14,18,23,92,32};
            

            for(int i = 0; i <arr.Length; i+=2)
            {
                Console.WriteLine(arr[i]);
                //Console.WriteLine($"element{i+1}");
                //arr[i]= Convert.ToInt32(Console.ReadLine());

            }
        }
    }
}
