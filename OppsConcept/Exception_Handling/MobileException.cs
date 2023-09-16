using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    using System;

    /*.WAP to take mobile number  in String from user 
a)if it is content number of digit less than 10 or more than 10
then throw Exception.
b)If String content any alphabet or symbol then thorw InvalidMobileException.*/
    
    public class InvalidMobileException : Exception
    {
        public InvalidMobileException(string message) : base(message)
        {
        }
    }

    class MobileException
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter your mobile number: ");
                string mobileNumber = Console.ReadLine();

                // Check if the length of the mobile number is not equal to 10
                if (mobileNumber.Length != 10)
                {
                    throw new Exception("Mobile number should contain exactly 10 digits.");
                }

                // Check if the mobile number contains only digits
                if (!IsNumeric(mobileNumber))
                {
                    throw new InvalidMobileException("Invalid mobile number. It should contain only digits.");
                }

                Console.WriteLine($"Mobile number entered: {mobileNumber}");
            }
            catch (InvalidMobileException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        // Function to check if a string contains only numeric characters
        static bool IsNumeric(string input)
        {
            foreach (char c in input)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }
    }

}
