using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    internal class LeapYear
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Year");
            int year=Convert.ToInt32(Console.ReadLine());

            bool isLeapYear = IsLeapYear(year);

            if(isLeapYear)
            {
                Console.WriteLine($"{year} is leap year:");
            }
            else
            {
                Console.WriteLine($"{year} is not leap year");

            }

        }
        static bool IsLeapYear(int year)
        {
            return(year% 4 == 0 && year%100 !=0)||(year%400==0);
        }
    }
}
