using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcept.Methods
{
    public class EvenNumOrSqr
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=50;i++)
            {
                if (i % 2 == 0)
                {
                    int square = i * i;
                    Console.WriteLine($"{i}is even and square is:{square}");
                }
                else
                {
                    int negative = -i;
                    Console.WriteLine($"{i}is odd and its negative is:{negative}");
                }
            }
        }
    }
}
