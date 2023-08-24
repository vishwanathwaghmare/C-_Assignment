using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    internal class Pattern4
    {
        static void Main(string[] args)
        {
            for(int i=5;i>=1;i-- ) 
            {
                for(int j=i;j<=5;j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();    
            
            }
        }
    }
}

//5
//45
//345
//2345
//12345