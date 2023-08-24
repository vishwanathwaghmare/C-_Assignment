using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    internal class PyramidPattern
    {
        static void Main(string[] args)
        {
            int x = 8;
            for(int i=1;i<= x; i++) 
            {
                for(int j=1;j<=(x-i);j++)
                {
                    Console.Write(" ");

                 for(int t = 1; t < i * 2; t++)
                    {
                        Console.Write("*");
                        Console.WriteLine();
                    }
                 Console.ReadLine();
                }
            
            }
        }
    }
}
