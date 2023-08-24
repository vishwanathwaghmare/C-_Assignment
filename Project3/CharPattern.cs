using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    internal class CharPattern
    {
        static void Main(string[] args)
        {
            for(char i = 'A'; i <= 'D'; i++)
            {
                for(char j='A';j<=i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
}
// *****OUTPUT*****
//A
//AB
//ABC
//ABCD