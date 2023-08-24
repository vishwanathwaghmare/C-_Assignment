using OppsConcept;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcept
{
    internal class Calculation
    {
        public int Multiplicaton(int a,int b)
        {
            return a * b;
        }
        public double Multiplicaton(int a, double b)
        {
            return a * b;
        }
        public double Multiplicaton(double a, double b)
        {
            return a * b;
        }
        public int Multiplicaton(int a, int b,int c)
        {
            return a * b*c;
        }

    }
}


public class Calcthod
{
    static void Main(string[] args)
    {
        Calculation m = new Calculation();
        Console.WriteLine(m.Multiplicaton(5,4,3));
        Console.WriteLine(m.Multiplicaton(5,10));
        Console.WriteLine(m.Multiplicaton(5 ,4,3));
    }
}