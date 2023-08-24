using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    internal class FrequecyDigit
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number");
            int num=Convert.ToInt32(Console.ReadLine());
            int copy = num;

            for(int i = 0; i<9;i++) 
            {
                int count = 0;

                while (num > 0)
                {
                    int digit = num % 10;
                    if (digit == i)
                    {
                        count++;    
                    }
                    num = num / 10;
                }
                Console.WriteLine(i+" 's Frequency is="+count);
                num = copy;
            }
        }
    }
}
