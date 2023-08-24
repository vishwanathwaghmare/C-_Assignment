using OppsConcept;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcept
{
    public class Employee
    {
        private int id;
        private string name;
        private double salary, hra, da, ta, pf, gross;
        private static int count;
        /*public void AcceptEmployeeData(int id,string name,double salary)
        {
            this.id  = id;
            this.name = name;
            this.salary = salary;
            
        }*/
        public Employee()//non paramaterise constructor
        {
            id = 0;
            name = "";
            salary = 0.0;
        
        }

        public Employee( string name, double salary)//parametarise constructor
        {
            count++;
            this.id = count;
            this.name = name;
            this.salary = salary;
            
        }

        public static int GetEmpCount()//static method
        {
            return count;
        }

        public void CalculateSalary()//method
        {
            hra = salary * 0.40;
            //da = salary * 0.20;
            ta = salary * 0.20;
            pf = salary * 0.12;
            gross = (salary + hra + ta) - pf;  
        }

        public override string ToString()
        {
            return $"Emp id={id}\n Name={name}\n Basic Salary={salary}\n Gross={gross}";
        }
    }
  
}






public class program1
{
    static void Main(string[] args)//main method
    {
         Employee obj1=new Employee();
        Console.WriteLine("Name Of employee"); ;
        string nm1 = Convert.ToString(Console.ReadLine());
        Console.WriteLine("Enter Basic Salary");
        int sal1 = Convert.ToInt32(Console.ReadLine());
        Employee obj2 = new Employee( nm1, sal1);


        Console.WriteLine("Name Of employee"); ;
        string nm2 = Convert.ToString(Console.ReadLine());
        Console.WriteLine("Enter Basic Salary");
        int sal2 = Convert.ToInt32(Console.ReadLine());
        Employee obj3 = new Employee(nm1, sal1);



        obj2.CalculateSalary();
        obj3.CalculateSalary();
        

        Console.WriteLine(obj2.ToString());
        Console.WriteLine(obj3.ToString());

        Console.WriteLine("Count Of the employee is:"+Employee.GetEmpCount());




    }
}


