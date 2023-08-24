using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcept.Arrays
{
    internal class SearchNum
    {
        static void Main(string[] args)
        {
            int[]array=new int[5];
            for(int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Enter a number");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Enter a number to be search");
            int n= Convert.ToInt32(Console.ReadLine());

            for(int i=0;i<=array.Length;i++)
            {
                if (array[i] == n)
                {
                    Console.WriteLine($"{n}Found at{i}Index");
                }
            }
        }
    }
}
