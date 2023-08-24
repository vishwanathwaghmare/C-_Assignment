using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcept.String
{
    public class SplitFun
    {
        static void Main(string[] args)
        {
            string str = "HELLO$WORLD";
            Console.WriteLine(str);

            string[] str1 = str.Split('$');
            //Console.WriteLine(str1);
            foreach (string str2 in str1)
            {
                Console.WriteLine(str2);
            }
        }
    }
}
