using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    internal class Prime1To10
    {
        static void Main(string[] args)
        {
            bool isPrime = true;

            for(int i=11; i <= 20; i++)
            {
                for(int j=2; j <= 10; j++)
                {
                    if(i !=j && i % j == 0)
                    {
                        isPrime = false;
                        break;
                       
                    }

                }
                if(isPrime==true)
                {
                    Console.Write("\n"+i);

                }
                
                
            }
            Console.WriteLine();
            
        }
    }
}
