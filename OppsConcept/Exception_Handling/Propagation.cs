using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    using System;

    class Propagation
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Main method: Start");
                DivideByZeroMethod();
                Console.WriteLine("Main method: End");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Main method: Caught an exception: {ex.Message}");
            }
        }

        static void DivideByZeroMethod()
        {
            try
            {
                Console.WriteLine("DivideByZeroMethod: Start");
                int result = Divide(10, 0); // This will throw an exception
                Console.WriteLine($"Result: {result}");
                Console.WriteLine("DivideByZeroMethod: End");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"DivideByZeroMethod: Caught an exception: {ex.Message}");
                // Re-throw the exception to propagate it up the call stack
                throw;
            }
        }

        static int Divide(int dividend, int divisor)
        {
            Console.WriteLine("Divide: Start");
            if (divisor == 0)
            {
                throw new DivideByZeroException("Division by zero is not allowed.");
            }
            int result = dividend / divisor;
            Console.WriteLine("Divide: End");
            return result;
        }
    }

}
