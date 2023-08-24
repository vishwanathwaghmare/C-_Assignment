using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcept.Methods
{
    internal class SquareOfNum
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=20;i++)
            {
                int square = i * i;
                Console.WriteLine($"square of {i} is{square}");
            }
        }
    }
}
