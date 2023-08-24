using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcept.Methods
{
    internal class SumOfAverage
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num=Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int count = 0;

            for (int i=1;i<=num; i++)
            {
                if (num % i == 0)
                {
                    sum=sum+i;
                    count++;
                }
            }
            double average=sum/count;
            Console.WriteLine($"average of factor{num}is:{average}");

        }
    }
}
