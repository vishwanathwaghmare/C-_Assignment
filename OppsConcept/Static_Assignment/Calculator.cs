using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcept.Static_Assignment
{
    // Write a meaningful program to show the use of method overloading.

    class Calculator
    {
        // Method to add two integers
        public int Add(int a, int b)
        {
            return a + b;
        }

        // Method to add three integers
        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        // Method to add two double values
        public double Add(double a, double b)
        {
            return a + b;
        }

        // Method to concatenate two strings
        public string Add(string a, string b)
        {
            return a + b;
        }
    }

    class Calc1
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();

            int sum1 = calc.Add(5, 10);
            int sum2 = calc.Add(5, 10, 15);
            double sum3 = calc.Add(2.5, 3.5);
            string concatenated = calc.Add("Hello, ", "world!");

            Console.WriteLine($"Sum of integers: {sum1}");
            Console.WriteLine($"Sum of three integers: {sum2}");
            Console.WriteLine($"Sum of double values: {sum3}");
            Console.WriteLine($"Concatenated string: {concatenated}");
        }
    }

}
