using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    internal class DisariumNum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num=Convert.ToInt32(Console.ReadLine());
            int count = 0;
            int sum = 0;
           int  temp =num;
            while(num>0)
            {
                count++;
                num = num / 10;
            }
            num = temp;

            while (num > 0)
            {
                int digit=num%10;
                int power = 1;

                for(int i = 0; i < count;i++)
                {
                    power = power * digit;
                }
                sum=sum + power; 
                count--;
                num= num / 10;  
            }
            if (sum == temp)
            {
                Console.WriteLine("The number is Disarium");
            }
            else
            {
                Console.WriteLine("The number is not Disarium");
            }
        }
    }
}
