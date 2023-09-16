using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcept.Collection
{
    // write c# code to print country code using generic disctionary<T,T>
    public class CountryCodeGeneric
    {
        static void Main(string[] args)
        {
            Dictionary<int,string> dc=new Dictionary<int,string>();
            dc.Add(91, "India");
            dc.Add(40, "Austria");
            dc.Add(50, "Pakistan");
            dc.Add(63, "USA");
            Console.WriteLine("Country code and Names are:");
            foreach (KeyValuePair<int, string> entry in dc)
            {
                Console.WriteLine($"{entry.Key},{entry.Value}");
            }
        }
    }
}
