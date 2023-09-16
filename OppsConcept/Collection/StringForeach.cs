using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcept.Collection
{
    public class StringForeach
    {
        //write code to crteate array of 5 string to store student name in asceding order and display using foreach loop
        static void Main(string[] args)
        {
            string[] str = new string[] { "Sagar", "Vishwanath", "priya", "Akash", "komal" };
            Console.WriteLine($"student names before sorting");
            foreach (string str1 in str)
            {
                Console.WriteLine(str1);
            }

            Array.Sort(str);
            Console.WriteLine("Students Name after sorting");

            foreach (string str2 in str)
            {
                Console.WriteLine(str2);
            }
        }
    }
}
