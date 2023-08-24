using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcept.String
{
    public class StringSplit
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string to print ");
            string str=Convert.ToString(Console.ReadLine());

            string[] words = str.Split(' ');

            for(int i=0; i<words.Length; i++)
            {
                for(int j=0; j<=i; j++)
                {
                    Console.WriteLine(words[j]);
                    if(j<i)
                    {
                        Console.Write(" ");
                    }

                }
                

            }
            Console.WriteLine();
        }
    }
}
