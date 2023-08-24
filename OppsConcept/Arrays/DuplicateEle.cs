using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcept.Arrays
{
    internal class DuplicateEle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The original array is");
            int[] arr = { 2, 5, 4, 1, 1, 5, 6, 5, 6, 6, 1, 5 };
            int dup = 0;
            
            foreach(var item in arr)
            {
               
                Console.WriteLine(item);
                
            }
            
            for(int i=0; i<arr.Length; i++)
            {
                int count = 1;
                bool isVisited = false;
                for(int k=i-1;k>=0;k--)
                {
                    if (arr[k] == arr[i])
                    {
                        isVisited= true;
                        break;
                    }
                }
                if(isVisited==false)
                {
                    for(int j = i + 1; j < arr.Length; j++)
                    {
                        if (arr[j] == arr[i])
                        {
                            count++;
                        }
                    }
                    if (count > 1)
                    {
                        dup++;
                        Console.WriteLine($"element {arr[i]} has {count} duplicates");
                        
                    }
                }
               

            }
            Console.WriteLine($"The total duplicate elements are:{dup}");
            
        }
    }
}
