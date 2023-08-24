using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcept.Arrays
{
    internal class PrimeElement
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of element in array");
            int n=Convert.ToInt32(Console.ReadLine());
            int []arr=new int[n];
            Console.WriteLine("enter the elements:");

            for(int i=0;i<n;i++)
            {
                Console.WriteLine($"elements{i+1}");
                arr[i]= Convert.ToInt32(Console.ReadLine());


            }
            Console.WriteLine("Prine element from array");
            foreach(int element in arr)
            {
                if (element <= 1)
                    continue;
                bool isPrime=true;

                for(int i = 2; i * i <= element; i++)
                {
                    if (element % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.WriteLine(element);
                }
            }
        }
    }
}
