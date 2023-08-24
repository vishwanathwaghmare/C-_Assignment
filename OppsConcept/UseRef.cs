using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcept
{
    public class UseRef
    {
        static void Swap(ref int a,ref int b)
        {
            int temp;
            temp = a;
            a = b;
            b = temp;
        }

        static void Main(string[] args)
        {
            int a = 100;
            int b = 200;
            Swap(ref a,ref b);
            Console.WriteLine($"after swap a={a},b={b}");
        }

    }
}
