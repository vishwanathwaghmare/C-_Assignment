using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    internal class DivisibleBy11For
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=25;i++ ) 
            {
                if (i % 11 == 0)
                {
                    break;
                }
                Console.WriteLine(i);
            }
        }
    }
}
