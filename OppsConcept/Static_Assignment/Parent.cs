using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcept.Static_Assignment
{
    //WAP to check whether you can inherit static method of Parent class in Child class



    class Parent
    {
        public static void StaticMethod()
        {
            Console.WriteLine("Static method in Parent class.");
        }
    }

    class Child : Parent
    {
        // This method "shadows" or "hides" the static method in the Parent class.
        public new static void StaticMethod()
        {
            Console.WriteLine("Static method in Child class.");
        }
    }

    class Parent1
    {
        static void Main(string[] args)
        {
            Parent.StaticMethod(); // Calls the static method in the Parent class.
            Child.StaticMethod();  // Calls the static method in the Child class (shadows the parent's method).
        }
    }

}
