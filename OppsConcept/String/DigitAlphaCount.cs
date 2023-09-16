using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcept.String
{
    public class DigitAlphaCount
    {
        //Write a C# program to find total number of alphabets, digits or special character in a string.
        
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string");
            string str=Console.ReadLine();

            int alphaCount = 0;
            int digitCount = 0;
            int specCharCount = 0;

            foreach(char c in str)
            {
                if ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z') )
                {
                    alphaCount++;
                }
                else if(c>='0'&& c<='9')
                {
                    digitCount++;
                }
                else if (! char.IsLetterOrDigit(c) && ! char.IsWhiteSpace(c))
                {
                    specCharCount++;
                }
            }
            Console.WriteLine($"Total Alphabets in given string:{alphaCount}");
            Console.WriteLine($"Total Digits in given string:{digitCount}");
            Console.WriteLine($"total Special Characters in given string:{specCharCount}");
        }
    }
}
