using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcept.String
{
    // 22. Create an array of 10 names sort in descending order
    public class NameSortDescending
    {
        static void Main(string[] args)
        {
            string[] name = new string[] { "apple", "banana", "cat", "dog", "elephant", "frog", "gun", "hen", "ink", "joker" };
            Array.Sort(name);
            Array.Reverse(name);

            Console.WriteLine("name is descinding order");
            foreach(string n in name)
            {
                Console.WriteLine(n);
            }
                
        }
    }
}
