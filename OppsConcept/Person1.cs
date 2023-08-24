using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcept
{
    internal class Person1
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public static int Count { get; set; }

        static Person1()
        {
            Count = 0;
        }
        public Person1(string name, int age)
        {
            Name = name;
            Age = age;
            Count++;
        }
        public void Introduce()
        {
            Console.WriteLine($"Hello my name is {Name} and i am {Age} years old");
        }
        public static void DisplayCount()
        {
            Console.WriteLine($"total number of person:{Count}");
        }
    }
}
