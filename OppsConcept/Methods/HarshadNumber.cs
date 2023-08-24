using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcept.Methods
{
    internal class HarshadNumber
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.WriteLine("Enter a number");
            int num=Convert.ToInt32(Console.ReadLine());

            while(num > 0)
            {
                sum =sum+ num % 10;
                
                sum=num/10; 
            }
            if (num == sum)
            {
                Console.WriteLine("Harshad number");
            }
            else
            {
                Console.WriteLine("Not harshad number");
            }

        }
       

    }
}
