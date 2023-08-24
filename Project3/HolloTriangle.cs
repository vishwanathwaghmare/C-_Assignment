using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    internal class HolloTriangle
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=5;i++) 
            { 
                for(int j=1;j<=i;j++) 
                {
                    if(j==1 || i==j || i==5)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(' ');
                    }

                
                }
                Console.WriteLine();
            
            }
        }
    }
}
