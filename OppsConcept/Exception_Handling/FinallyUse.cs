using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    using System;

    class FinallyUse
    {
        static void Main(string[] args)
        {
            try
            {
                
                int result = Divide(10, 0);
                Console.WriteLine($"Result: {result}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                // Code inside the finally block will always be executed
                Console.WriteLine("Finally block executed.");
            }

            Console.WriteLine("After try-catch-finally block.");
        }

        static int Divide(int dividend, int divisor)
        {
            try
            {
                return dividend / divisor;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Error in Divide method: {ex.Message}");
                // Re-throwing the exception for higher-level handling
                throw;
            }
        }
    }

}
