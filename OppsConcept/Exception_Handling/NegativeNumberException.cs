using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    using System;

    // If number is negative then throw negative number exception.
    public class NegativeNumberException : Exception
    {
        public NegativeNumberException() : base("Negative numbers are not allowed.")
        {
        }
    }

    class NegativeNum
    {
        static void Main(string[] args)
        {
            try
            {
                int number = -5; // Replace with your number

                if (number < 0)
                {
                    throw new NegativeNumberException();
                }

                Console.WriteLine($"The number is: {number}");
            }
            catch (NegativeNumberException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                // Handle the exception or perform any necessary actions here
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }

}
