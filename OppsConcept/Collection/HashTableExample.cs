using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcept.Collection
{
    public class HashTableExample
    {
        static void Main(string[] args)
        {
            Hashtable ht=new Hashtable();
            ht.Add(91, "india");
            ht.Add(40, "Austria");
            ht.Add(16, "America");
            ht.Add(76, "Brazil");

            ht.Remove(16);

            foreach(DictionaryEntry entry in ht)
            {
                Console.WriteLine($"{entry.Key},{entry.Value}");
            }
        }
    }
}
