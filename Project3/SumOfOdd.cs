using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    internal class SumOfOdd
    {
        static void Main(string[] args)
        {
            int i = 1,sum=0;
            Console.WriteLine("Enter a number:");
            int num=Convert.ToInt32(Console.ReadLine());

           
            
            while(i<=num) 
            {
                 sum += i;
                i += 2;
            }
            
            Console.WriteLine($"Sum Of odd numbers from 1 to {num} is:{sum}");
        }
    }
}
