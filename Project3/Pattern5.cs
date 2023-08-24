using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    internal class Pattern5
    {
        static void Main(string[] args)
        {
            int num = 1;
            for(int i=1;i<=5;i++)
            {
                for(int j=1;j<=5;j++)
                { 
                    if(num==1)
                    {
                        Console.Write("1");
                    }
                    else
                    {
                        Console.Write("0");
                    }
                    num *= -1;


                }
                if (5 % 2 == 0)
                {
                    num *= -1;
                }
                Console.WriteLine();
            }
        }
    }
}
