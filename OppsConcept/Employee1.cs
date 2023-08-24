using OppsConcept;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcept
{
    internal class Employee1
    {
        public int EmployeeId { get; private set; }
        public string Name { get; private set; }
        public double Salary { get; private set; }
        private static int totalEmployees = 0;

        public Employee1(int id, string name, double salary)
        {
            EmployeeId = id;
            Name = name;
            Salary = salary;
            totalEmployees++;
        }

        public static int TotalEmp()
        {
            return totalEmployees;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Employee ID: {EmployeeId}, Name: {Name}, Salary: {Salary}");
        }
    }
}


 public class Emp1
{
    static void Main(string[] args)
    {
        Employee1 emp1 = new Employee1(1, "Vishwanath", 80000);
        Employee1 emp2 = new Employee1(2, "Sandesh", 60000);
        Employee1 emp3 = new Employee1(3, "Payal", 55000);
        Employee1 emp4 = new Employee1(4, "Alisha", 62000);
        Employee1 emp5 = new Employee1(5, "Shubham", 58000);

        Console.WriteLine("Employee Information:");
        emp1.DisplayInfo();
        emp2.DisplayInfo();
        emp3.DisplayInfo();
        emp4.DisplayInfo();
        emp5.DisplayInfo();

        Console.WriteLine($"Total number of employees: {Employee1.TotalEmp()}"); 
    }
}
