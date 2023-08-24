using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcept.Collection
{
    public class SortedListExample
    {
        static void Main(string[] args)
        {
            SortedList sl = new SortedList();
            sl.Add(103, "HR");
            sl.Add(101, "Sales");
            sl.Add(104, "IT");
            sl.Add(102, "Management");

            sl.Remove(104);

            foreach (DictionaryEntry entry in sl)
            {
                Console.WriteLine($"{entry.Key},{entry.Value}");
            }
        }
    }
}
