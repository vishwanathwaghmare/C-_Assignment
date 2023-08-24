using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Project3
{
    internal class KrushnaMurthi
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num=Convert.ToInt32(Console.ReadLine());
            int rem = 0;
            int temp = num;
            int sum = 0;

            while (num>0)
            {
                rem = num % 10;
                int fact = 1;
                for(int i=1; i<rem; i++)
                {
                    fact = fact * i;
                    sum = sum + fact;
                    num = num / 10;
                }
                
            }
            if (temp == sum)
            {
                Console.WriteLine("The number is Krushnamurthi");
            }
            else
            {
                Console.WriteLine("the number is not krushnamurthi");
            }
        }
    }
}
