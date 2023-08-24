using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcept.String
{
    public class IsNullEmpty
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a name");
            string name = Convert.ToString(Console.ReadLine());

            if(string.IsNullOrEmpty(name) )
            {
                Console.WriteLine("name is requires");
            }
            else
            {
                Console.WriteLine("hello" +" "+name);
            }
        }
    }
}
