using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    internal class OddNum1To20
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 20; i++)
            {
                if(i%2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
