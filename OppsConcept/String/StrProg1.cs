using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcept.String
{
    public class StrProg1
    {
        static void Main(string[] args)
        {
            string message = " hello to all ";
            string message2 = "good morning";
            
            string str1=string.Concat(message," "+message2);
            Console.WriteLine(str1);
            Console.WriteLine(str1.Trim());//trim,trimstart,trimend use to remove spaces in string .
            Console.WriteLine(message.ToUpper());
            Console.WriteLine(message.ToLower());
            Console.WriteLine("index:"+message2.IndexOf('o'));
            Console.WriteLine("last index"+message2.LastIndexOf('o'));

            //convert string to string array
            string[] starr = message2.Split('h');
            
            //convert string to char array
            char[] ch=message.ToCharArray();

            //convert char array to string
            string str2=new string(ch);
            Console.WriteLine(str2);
            foreach(char c in ch)
            {
                Console.WriteLine(c);
            }
            foreach(string s in starr)
            {
                Console.WriteLine(s);
            }

            for(int i=0;i<message2.Length;i++)
            {
                Console.WriteLine(message2[i]);
            }



        }
    }
}
