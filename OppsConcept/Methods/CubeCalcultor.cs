using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcept.Methods
{
    public class CubeCalcultor
    {
        // no return type no parameter
        public void CalculateCube()
        {
            Console.Write("Enter a number: ");
            double num = Convert.ToDouble(Console.ReadLine());
            double cube = num * num * num;
            Console.WriteLine($"The cube of {num} is {cube}");
        }

        //With Return Type, No Parameters:
        public double CalculateCube1()
        {
            Console.Write("Enter a number: ");
            double num = Convert.ToDouble(Console.ReadLine());
            double cube = num * num * num;
            return cube;
        }

        // No Return Type, With Parameter Passing:
        public void CalculateCube2(double num)
        {
            double cube = num * num * num;
            Console.WriteLine($"The cube of {num} is {cube}");
        }

        //With Return Type, With Parameter Passing
        public double CalculateCube3(double num)
        {
            double cube = num * num * num;
            return cube;
        }
    }

    public class CalcCube
    {
        static void Main(string[] args)
        {
            CubeCalcultor calculator = new CubeCalcultor();
            calculator.CalculateCube();

            CubeCalcultor calculator1 = new CubeCalcultor();
            double result = calculator.CalculateCube1();
            Console.WriteLine($"The cube of the number is {result}");

            CubeCalcultor calculator2 = new CubeCalcultor();
            Console.Write("Enter a number: ");
            double input = Convert.ToDouble(Console.ReadLine());
            calculator.CalculateCube2(input);

            CubeCalcultor calculator3 = new CubeCalcultor();
            Console.Write("Enter a number: ");
            double input1 = Convert.ToDouble(Console.ReadLine());
            double result1 = calculator.CalculateCube3(input);
            Console.WriteLine($"The cube of the number is {result}");
        }
    }
}
