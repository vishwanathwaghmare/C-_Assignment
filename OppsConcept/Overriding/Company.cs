using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcept.Overriding
{
    internal class Company
    {
        public virtual void Address()
        {
            Console.WriteLine("This is the base company's address.");
        }
    }

    class eBay : Company
    {
        public override void Address()
        {
            Console.WriteLine("This is eBay's address.");
        }
    }
}
