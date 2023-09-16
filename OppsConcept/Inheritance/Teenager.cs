using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcept.Polymorphism
{

    using System;

    class Kid
    {
        public virtual void readBook()
        {
            Console.WriteLine("Kid is reading a picture book.");
        }
    }

    class BigKid : Kid
    {
        public override void readBook()
        {
            Console.WriteLine("BigKid is reading an adventure book.");
        }
    }

    class Teenager : Kid
    {
        public override void readBook()
        {
            Console.WriteLine("Teenager is reading a novel.");
        }
    }

    class Teenager1
    {
        static void Main(string[] args)
        {
            Kid k1 = new BigKid();
            Kid k2 = new Teenager();

            k1.readBook(); // Calls BigKid's implementation
            k2.readBook(); // Calls Teenager's implementation
        }
    }

}
