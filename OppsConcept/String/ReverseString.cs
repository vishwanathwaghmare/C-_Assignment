using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcept.String
{
    public class ReverseString
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string to Reverse");
            string str=Convert.ToString(Console.ReadLine());

            string rev=str;

            char[] charr = new char[str.Length];
            int strLen=str.Length;

            for(int i=0; i<strLen; i++)
            {
                charr[i] = str[strLen-i-1]  ;
               

            }
            Console.WriteLine(charr);
            

        }
    }
}
