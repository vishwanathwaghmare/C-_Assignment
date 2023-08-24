using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcept.Arrays
{
    internal class SecondSmall
    {
        static int SecondSmallest(int[]arr)
        {
            if (arr.Length < 2)
            {
                Console.WriteLine("array should have atlist two element");
                return -1;
            }
            int Fsmall=int.MaxValue;
            int Ssmall=int.MaxValue;

            foreach(int num in arr)
            {
                if (num < Fsmall)
                {
                    Ssmall = Fsmall;
                    Fsmall = num;
                }
                else if(num<Ssmall && num !=Fsmall)
                {
                    Ssmall = num;
                }
                   
            }
            return Ssmall;
        }
    }
}
