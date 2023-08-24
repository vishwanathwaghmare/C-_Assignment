using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    internal class DivisibleInWhile
    {
        static void Main(string[] args)
        {
            int i = 1;
            while(i<=20) 
            { 
                if(i%3!=0 || i%5!=0)
                {
                    Console.WriteLine(i + "");

                }
                i++;
            }
        }
    }
}
