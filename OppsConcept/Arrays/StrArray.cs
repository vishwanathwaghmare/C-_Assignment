using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcept.Arrays
{
    internal class StrArray
    {
        static void Main(string[] args)
        {
            string[] arr = new string[5];
            for(int i=0; i<arr.Length; i++)
            {
                Console.WriteLine($"Enter name{i+1}:");
                arr[i] = Console.ReadLine();

               
            }
            for(int i=0; i<arr.Length;i++)
            {
                Console.WriteLine($"name{i+1}:{arr[i]}");
            }
           
        }
    }
}
