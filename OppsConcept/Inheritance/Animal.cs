using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace OppsConcept.Inheritance
{
    //Single Inheritance
    public class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Animal is eating");
        }

    }
    public class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("Dog is barking");
        }
    }
    public class Puppy : Dog             // multilevel inheritance
    {
        public void Breadth()
        {
            Console.WriteLine("puppy is breadthing");
        }
    }

    public class Cat : Animal
    {
        public void Meown()
        {
            Console.WriteLine("Cat is Meowning");
        }
    }
}
