using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    internal class DivisibliWhile
    {
        static void Main(string[] args)
        {
            int num = 1;
            while(num <=25) 
            {
                if (num % 11 == 0)
                {
                    break;
                }
                Console.WriteLine(num);
                num++;
            
            }
        }
    }
}
