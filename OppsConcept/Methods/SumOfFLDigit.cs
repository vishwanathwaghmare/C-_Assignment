using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcept.Methods
{
    internal class SumOfFLDigit
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num = Convert.ToInt32(Console.ReadLine());
            int firstDigit =GetFirstDigit(num);
            int lastDigit=GetLastDigit(num);


            int sum=firstDigit+lastDigit;

            Console.WriteLine($"The sum of first digit and last digit is {sum}");

            static int GetFirstDigit(int number)
            {
                while (number >= 10)
                {
                    number /=10;
                }
                return number;
            }
            static int GetLastDigit(int number)
            {
                return number % 10;
            }
        }
    }
}
