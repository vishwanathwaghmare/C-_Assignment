using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcept.String
{
    public class ReplaceVowels
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write sentence here.....");
            string str = Console.ReadLine();

            string vowels = "aeiouAEIOU";
            string result = " ";

            foreach(char c in str)
            {
                char nextChar = c;
                if(vowels.Contains(c))
                {
                    if (c == 'z')
                    {
                        nextChar = 'a';
                    }
                    else if (c == 'Z')
                    {
                        nextChar = 'A';
                    }
                    else
                    {
                        nextChar = (char) (c+1);
                        result = result + nextChar;

                    }

                   // result=result+ nextChar;
                }

                
            }
            Console.WriteLine("modefied sentence :"+result);
        }

    }
}
