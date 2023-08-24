using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcept.Inheritance
{
    public class InherMain
    {
        static void Main(string[] args)
        {
            Animal animal= new Animal();
            Dog dog= new Dog();
            Puppy puppy= new Puppy();
            Cat cat= new Cat();
            cat.Meown();
            dog.Eat();
            dog.Bark();
            puppy.Breadth();
        }
    }
}
