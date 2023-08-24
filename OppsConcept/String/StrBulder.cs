using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcept.String
{
    public class StrBulder
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---Original string is---");
            StringBuilder sb = new StringBuilder("Hello to all");
            Console.WriteLine(sb);

            Console.WriteLine("---to add string with existing string---");
            sb.Append("Good Morning");
            Console.WriteLine(sb);

            Console.WriteLine("---To Remove chracter we can use remove()");
            sb.Remove(4, 5);
            Console.WriteLine(sb);

            Console.WriteLine("---To replace character---");
            sb.Replace('l', 'L');
            Console.WriteLine(sb);

            Console.WriteLine("---to check capacity of string---");
            Console.WriteLine("capacity="+sb.Capacity);
            Console.WriteLine(sb);
        }
    }
}
