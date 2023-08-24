using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcept.Methods
{
    public class Person
    {
        public string FName { get; set; }
        public string LName { get; set; }

        public Person()

        {
            FName = "Sagar";
            LName = "Wagh";
        }

        public Person(string firstName)
        {
            FName= firstName;
            LName = "Waghmare";
                
        }
        public Person(string firstName,string lastName )
        {
            FName= firstName;
            LName= lastName;
                
        }

        public void DisplayFullName()
        {
            Console.WriteLine($"First Name is:{FName}\n Last Name is:{LName}");

        }
    }
}
