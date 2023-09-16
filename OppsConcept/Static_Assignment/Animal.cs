using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcept.Static_Assignment
{
    //Write a meaningful program to show the use of method overriding.

    class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("The animal makes a generic sound.");
        }
    }

    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("The dog barks.");
        }
    }

    class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("The cat meows.");
        }
    }

    class Animal1
    {
        static void Main(string[] args)
        {
            Animal genericAnimal = new Animal();
            Animal myDog = new Dog();
            Animal myCat = new Cat();

            Console.WriteLine("Generic Animal:");
            genericAnimal.MakeSound(); // Calls the base class method

            Console.WriteLine("\nMy Dog:");
            myDog.MakeSound(); // Calls the overridden method in the Dog class

            Console.WriteLine("\nMy Cat:");
            myCat.MakeSound(); // Calls the overridden method in the Cat class
        }
    }

}
