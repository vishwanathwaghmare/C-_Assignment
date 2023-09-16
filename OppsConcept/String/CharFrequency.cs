using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcept.String
{
    public class CharFrequency
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string ");
            string str=Convert.ToString(Console.ReadLine());

            char[] ch = new char[256];
            int maxFreq = 0;

            foreach(char c in ch)
            {
                ch[c]++;
                if (ch[c] > maxFreq)
                {
                    maxFreq = ch[c];
                }
            }

            for(int i = 0; i < ch.Length; i++)
            {
                if (ch[i] ==maxFreq) 
                {
                    Console.WriteLine($"character:{(char)i},frequency {maxFreq}");
                }
            }

        }
    }
}
