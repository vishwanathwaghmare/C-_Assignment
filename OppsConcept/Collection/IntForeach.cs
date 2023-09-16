using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcept.Collection
{
    public class IntForeach
    {
        static void Main(string[] args)
        {
            int[] arr = { 10, 12, 14, 16, 18 };

            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
        }
    }
}
