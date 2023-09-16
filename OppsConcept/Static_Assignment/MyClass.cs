using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcept.Static_Assignment
{
    using System;

    class MyClass
    {
        // Static variable
        public static int staticVar = 10;

        // Non-static (instance) variable
        public int instanceVar = 20;

        // Static method accessing static variable
        public static void AccessStaticVar()
        {
            Console.WriteLine($"Accessing staticVar from static method: {staticVar}");
        }

        // Static method attempting to access non-static variable (This will result in a compilation error)
        public static void AccessNonStaticVarFromStaticMethod()
        {
           
           
        }

        // Non-static (instance) method accessing static variable
        public void AccessStaticVarFromNonStaticMethod()
        {
            Console.WriteLine($"Accessing staticVar from non-static method: {staticVar}");
        }

        // Non-static (instance) method accessing non-static variable
        public void AccessNonStaticVar()
        {
            Console.WriteLine($"Accessing instanceVar from non-static method: {instanceVar}");
        }
    }

    class Static1
    {
        static void Main(string[] args)
        {
            MyClass.AccessStaticVar(); // Access static variable from a static method

            

            MyClass obj = new MyClass();
            obj.AccessStaticVarFromNonStaticMethod(); // Access static variable from a non-static method
            obj.AccessNonStaticVar(); // Access non-static variable from a non-static method
        }
    }

}
