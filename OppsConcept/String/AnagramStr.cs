using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcept.String
{
    public class AnagramStr
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first string");
            string str1=Convert.ToString(Console.ReadLine());

            Console.WriteLine("Enter second number");
            string str2=Convert.ToString(Console.ReadLine());

            char[]charr1 = str1.ToLower().ToCharArray();
            char[]charr2 = str2.ToLower().ToCharArray();

            Array.Sort(charr1);
            Array.Sort(charr2);
            string str3=new string(charr1);
            string str4=new string(charr2);

            if(str3 == str4)
            {
                Console.WriteLine("string is anagram");
            }
            else
            {
                Console.WriteLine("string is not anagram");
            }


        }
    }
}
