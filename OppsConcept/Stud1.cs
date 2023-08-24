using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcept
{
    public class Stud1
    {
        static void Main(string[] args)
        {
            /* Student1 stud = new Student1();
             stud.RollNo = 1;
             stud.Name = "Vishwanath";
             stud.Percentage = 80.50;
             Console.WriteLine($"RollNo={stud.RollNo}\n Name={stud.Name}\nPercentage={stud.Percentage}");


             Console.WriteLine(stud.Print());

             Student1 stud2 = new Student1()
             { RollNo = 2, Name = "sagar", Percentage = 70.60 };

             Console.WriteLine($"RollNo={stud2.RollNo}\n Name={stud2.Name}\nPercentage={stud2.Percentage}");*/

            Book b1 = new Book(1, 500, "java", "sagar");

            Console.WriteLine(b1.show());
        }
           

        
    }
}
