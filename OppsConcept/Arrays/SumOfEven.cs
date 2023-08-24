using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcept.Arrays
{
    public class SumOfEven
    {
        //create int type array and count sum of even element .
        static void Main(string[] args)
        {
            int[] arr = { 2, 3, 8, 10, 15, 23, 21, 40, 15 };
            int sumOfEven = 0;
            
            foreach (int i in arr)
            {
                if(i%2 == 0)
                {
                    sumOfEven=sumOfEven+i;
                }
            }

            Console.WriteLine($"Sum of even numbers in array :{sumOfEven}");
        }
        
        
    }
}
