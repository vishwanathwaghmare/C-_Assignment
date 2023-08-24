using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    internal class PiryamidPattern1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of rows");
            int num=Convert.ToInt32(Console.ReadLine());
            

            for(int i=0; i<=num; i++) 
            { 
                for(int j=1;j<=num; j++)
                {
                    Console.Write("");
                }
                for (int j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                    
                }
                
                


                Console.WriteLine();

            }
            
        }
    }
}
