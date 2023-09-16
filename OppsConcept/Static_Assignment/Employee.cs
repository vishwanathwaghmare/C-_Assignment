using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcept.Static_Assignment
{
    /* Write Employee Class with attributes like employee_id, name, and salary.
Create parameterized constructor to initialize this 3 attributes, and write a
method to display this information of 5 objects, display total no of
employees using static method, totalEmp(), which will return total no of
employees.*/

    class Employee
    {
        // Employee attributes
        private int employee_id;
        private string name;
        private double salary;

        // Static variable to keep track of the total number of employees
        private static int totalEmployees = 0;

        // Parameterized constructor
        public Employee(int id, string empName, double empSalary)
        {
            employee_id = id;
            name = empName;
            salary = empSalary;
            totalEmployees++; // Increment the totalEmployees count when a new employee is created
        }

        // Method to display employee information
        public void DisplayEmployeeInfo()
        {
            Console.WriteLine($"Employee ID: {employee_id}, Name: {name}, Salary: {salary:C}");
        }

        // Static method to return the total number of employees
        public static int TotalEmp()
        {
            return totalEmployees;
        }
    }

    class Emp
    {
        static void Main(string[] args)
        {
            // Create 5 Employee objects with different information
            Employee emp1 = new Employee(1, "Vishwanath", 50000.0);
            Employee emp2 = new Employee(2, "Sagar", 60000.0);
            Employee emp3 = new Employee(3, "Suraj", 55000.0);
            Employee emp4 = new Employee(4, "Vaibhav", 58000.0);
            Employee emp5 = new Employee(5, "Rohan", 52000.0);

            // Display information for all 5 employees
            Console.WriteLine("Employee Information:");
            emp1.DisplayEmployeeInfo();
            emp2.DisplayEmployeeInfo();
            emp3.DisplayEmployeeInfo();
            emp4.DisplayEmployeeInfo();
            emp5.DisplayEmployeeInfo();

            // Display the total number of employees
            int totalEmps = Employee.TotalEmp();
            Console.WriteLine($"Total number of employees: {totalEmps}");
        }
    }

}
