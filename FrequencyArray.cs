using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcept.Arrays
{
    //write code to count frequency of element in array
    public class FrequencyArray
    {
        static void Main(string[] args)
        {
            int []arr = { 1, 2, 3, 4, 5, 4, 5, 3, 5, 6, 7, 8, 9, };
            

            for(int i=0; i<arr.Length; i++)
            {
                int element = arr[i];
                int frequency = 0;

                if (element == int.MinValue)
                    continue;

                for(int j=i;j<arr.Length; j++)
                {
                    if (arr[j] == element)
                    {
                        frequency++;
                        arr[j] = int.MinValue;
                    }
                }

                Console.WriteLine($" The  {element} element iscomes {frequency} times");

            }

        }
    }
}
