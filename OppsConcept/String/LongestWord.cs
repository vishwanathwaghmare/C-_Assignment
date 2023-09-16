using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcept.String
{
    public class LongestWord
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a sentance here.....");
            string sent=Console.ReadLine();

            string[] words = sent.Split(' ');
            string longword = "";

            foreach (string word in words)
            {
                if (word.Length > longword.Length)
                {
                    longword = word;
                }
            }
            Console.WriteLine($"The Longest word is {longword}");
        }
    }
}
