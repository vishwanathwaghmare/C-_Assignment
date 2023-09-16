using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcept.Arrays
{
    public class ArrayOperation
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];

            // Accept input for the array
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Enter number {i + 1}: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\nOriginal Array:");
            DisplayArray(numbers);

            // Sort the array
            Array.Sort(numbers);
            Console.WriteLine("\nArray after Sort:");
            DisplayArray(numbers);

            // Reverse the array
            Array.Reverse(numbers);
            Console.WriteLine("\nArray after Reverse:");
            DisplayArray(numbers);

            // Create a copy of the array
            int[] copyArray = new int[numbers.Length];
            Array.Copy(numbers, copyArray, numbers.Length);
            Console.WriteLine("\nCopied Array:");
            DisplayArray(copyArray);

            // Clear the array
            Array.Clear(numbers, 0, numbers.Length);
            Console.WriteLine("\nArray after Clear:");
            DisplayArray(numbers);
        }

        static void DisplayArray(int[] arr)
        {
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}
