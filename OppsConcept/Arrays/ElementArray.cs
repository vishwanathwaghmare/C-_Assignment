using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcept.Arrays
{
    public class ElementArray
    {
        static void Main(string[] args)
        {
            int[] num = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Console.WriteLine("enter a number to check");
            int num2 = Convert.ToInt32(Console.ReadLine());
            bool isPresent = false;


            foreach(int num3 in num)
            {
                if (num3 == num2)
                {
                    isPresent = true;
                   
                    break;
                }
                

                
            }
            if (isPresent)
            {
                Console.WriteLine($"{num2} Element is present in array{isPresent}");
            }
            else
            {
                Console.WriteLine(" Element not present in array");
            }
            
        }
    }
}
