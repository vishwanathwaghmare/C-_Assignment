using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcept.Overriding
{
    public class Programmer
    {
        public virtual void workingHours()
        {
            Console.WriteLine("A programmer typically works 40 hours a week.");
        }
    }
    class Employee : Programmer
    {
        public override void workingHours()
        {
            Console.WriteLine("An employee typically works 35 hours a week.");
        }
    }
    class Programmer1
    {
        static void Main(string[] args)
        {
            Programmer programmer = new Programmer();
            Employee employee = new Employee();

            // Calling the workingHours() method on the base class object
            programmer.workingHours();

            // Calling the workingHours() method on the derived class object
            employee.workingHours();
        }
    }
}
