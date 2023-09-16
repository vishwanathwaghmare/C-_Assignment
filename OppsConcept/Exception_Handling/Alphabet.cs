using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    using System;

    // WAP to check String content only alphabets if any digit or symbol is present then throw custom exception
    public class NonAlphabeticException : Exception
    {
        public NonAlphabeticException() : base("String contains non-alphabetic characters.")
        {
        }
    }

    class AlphabetOnly
    {
        static void Main(string[] args)
        {
            try
            {
                string inputString = "Hello123"; // Replace with your input string

                if (!IsAlphabetic(inputString))
                {
                    throw new NonAlphabeticException();
                }

                Console.WriteLine($"The string is: {inputString}");
            }
            catch (NonAlphabeticException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                // Handle the exception or perform any necessary actions here
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        // Function to check if a string contains only alphabetic characters
        static bool IsAlphabetic(string input)
        {
            foreach (char c in input)
            {
                if (!char.IsLetter(c))
                {
                    return false;
                }
            }
            return true;
        }
    }

}
