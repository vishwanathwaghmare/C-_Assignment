using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    internal class Table1To5
    {
        static void Main(string[] args)
        {
            for(int t=1; t<=5;t++)
            {
                for(int i=1; i<=10;i++)
                {
                    Console.WriteLine(t +"*" +(i)+"="+(t*(i)));    

                }
                Console.WriteLine("---------------");

            }
           
           
        }
    }
}
