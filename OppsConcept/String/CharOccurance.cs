using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcept.String
{
    //find the character occurance on index
    public class CharOccurance
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string");
            string str1 = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Enter a character to find");
            char char1 = Convert.ToChar(Console.ReadLine());

            int index = -1;

            for(int i=0;i<str1.Length;i++)
            {
                if (str1[i]== char1)
                {
                    index = i; break;

                }

            }

            if(index != -1)
            {
                Console.WriteLine($"The Occurance of Character is at index :{index}");
            }
            else
            {
                Console.WriteLine("char not found in given string");
            }


        }
    }
}
