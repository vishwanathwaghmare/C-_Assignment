using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{

    class NameException : Exception
    {
        public NameException(string message):base(message) 
        {
        }
    }
    public class Students
    {
        private string name;
        public Students(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new NameException("Name is required....");
            }
            this.name = name;
            
        }
        
    }

    public class program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter student name");
                string sname = Console.ReadLine();
                Console.WriteLine(sname);
                Students students = new Students(sname);
                Console.WriteLine();
            } 
            catch (NameException ex)
            {
            Console.WriteLine(ex.Message);
            }
        }
    }
}
