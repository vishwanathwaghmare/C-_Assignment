using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcept.String
{
    //8. write c# program to toggle case of each character of a string
    public class ToggleCase
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string");
            string str=Convert.ToString(Console.ReadLine());

            char[] ch = str.ToCharArray();

            for(int i=0; i<ch.Length; i++)
            {
                if (char.IsLower(ch[i]))
                {
                    ch[i] = char.ToUpper(ch[i]);    
                }
                else if (char.IsUpper(ch[i]))
                {
                    ch[i] = char.ToLower(ch[i]);    
                }
            }
            Console.WriteLine(ch);

        }
    }
}
