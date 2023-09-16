using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    using System;

    // Custom exception class for invalid binary input
    public class InvalidBinaryException : Exception
    {
        public InvalidBinaryException(string message) : base(message)
        {
        }
    }

    class BinaryNumber
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter a binary number: ");
                string binaryInput = Console.ReadLine();

                // Check if the input is a valid binary number
                if (IsBinary(binaryInput))
                {
                    int decimalValue = ConvertBinaryToDecimal(binaryInput);
                    Console.WriteLine($"Decimal equivalent: {decimalValue}");
                }
                else
                {
                    throw new InvalidBinaryException("Invalid binary number.");
                }
            }
            catch (InvalidBinaryException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        static bool IsBinary(string input)
        {
            foreach (char c in input)
            {
                if (c != '0' && c != '1')
                {
                    return false;
                }
            }
            return true;
        }

        static int ConvertBinaryToDecimal(string binary)
        {
            int decimalValue = 0;
            int power = 0;

            for (int i = binary.Length - 1; i >= 0; i--)
            {
                if (binary[i] == '1')
                {
                    decimalValue += (int)Math.Pow(2, power);
                }
                power++;
            }

            return decimalValue;
        }
    }

}
