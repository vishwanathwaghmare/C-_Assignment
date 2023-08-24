using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    internal class CaprekarNum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number");
            int num=Convert.ToInt32(Console.ReadLine());

            int count=0;
            int sq = num * num;
            int copy = num;


            while (num > 0)
            {
                
                num = num * 10;
                count++;
            }
            int power = 1;
            for(int i = 1; i<=count; i++)
            {
                power = power * 10;

            }
            int end = sq % power;
            int start = sq / power;
            Console.WriteLine(end + " "+start);
            num = copy;

            if(num==copy)
            {
                Console.WriteLine("the number is kaprekar");
            }
            else
            {
                Console.WriteLine("The number is not kaprekar");
            }
            
            
        }
    }
}
