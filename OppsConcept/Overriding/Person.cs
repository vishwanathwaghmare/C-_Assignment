using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcept.Overriding
{
    public class Person
    {
        public virtual void readScript()
        {
            Console.WriteLine("The person is reading a script.");
        }
    }
    class Actor : Person
    {
        public override void readScript()
        {
            Console.WriteLine("The actor is reading a movie script.");
        }
    }

    class Person1
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Actor actor = new Actor();

            // Calling the readScript() method on the base class object
            person.readScript();

            // Calling the readScript() method on the derived class object
            actor.readScript();
        }
    }
}
