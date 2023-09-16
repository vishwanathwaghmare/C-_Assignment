using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcept.String
{
    //Write a C# program to count total number of vowels and consonants in a string.
    public class VowelCount
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string");
            string str=Convert.ToString(Console.ReadLine());

            int vCount = 0;
            int consCount = 0;

            foreach(char c in str)
            {
               // Console.WriteLine(c);
                
                if(c=='a'|| c=='A' || c=='e'|| c=='E'|| c=='i'|| c=='I' ||  c=='o'|| c=='O' || c=='u'|| c == 'U')
                {
                    vCount++;
                }
                else
                {
                    consCount++;
                }
            }
            Console.WriteLine($"Total number of vowels:{vCount}");
            Console.WriteLine($"Total number of Consonants:{consCount}");
        }
    }
}
