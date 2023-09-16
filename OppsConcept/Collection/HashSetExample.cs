using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcept.Collection
{
    public class HashSetExample
    {
        static void Main(string[] args)
        {
            HashSet<string> list1= new HashSet<string>();   
            list1.Add("c");
            list1.Add("c++");
            list1.Add("Java");
            list1.Add("Html");

            HashSet<string> list2 = new HashSet<string>();
            list1.Add("python");
            list1.Add("c++");
            list1.Add("ML");
            list1.Add("java");

            list1.UnionWith(list2);
            //list1.IntersectWith(list2);
          // list1.ExceptWith(list2);
          
            foreach(string item in list1)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

        }

    }
}
