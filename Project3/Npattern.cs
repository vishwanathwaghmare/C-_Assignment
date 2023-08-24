using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    internal class Npattern
    {
        static void Main(string[] args)
        {
            for(int i=0;i<=6;i++) 
            {
                for ( int j = 0; j <= 6; j++)
                {
                    if(j==1 || j==5 ||(i==j && j!=0 && j != 6))
                    {
                        Console.WriteLine("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();

            }
            

        }
    }
}
