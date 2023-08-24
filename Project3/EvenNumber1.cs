using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    internal class EvenNumber1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num = Convert.ToInt32(Console.ReadLine());

            while(num>0)
            {
                int digit = num % 10;
                num /= 10;

                if(digit%2 !=0)
                {
                    continue;
                   
                }
                Console.WriteLine(num);
            }
        }
    

    }
}
