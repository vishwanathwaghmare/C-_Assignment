using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcept.String
{
    //character occurance in string
    public class CharacterOcc
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string");
            string str1=Convert.ToString(Console.ReadLine());

            Console.WriteLine("Enter a character to count occurance");
            char ch1=Convert.ToChar(Console.ReadLine());

            int count = 0;
            for(int i=0;i<str1.Length;i++)
            {
                if (str1[i] == ch1)
                {
                      count++;
                }
            }
            Console.WriteLine($"Occurance of character is {count} times in string");
        }
    }
}
