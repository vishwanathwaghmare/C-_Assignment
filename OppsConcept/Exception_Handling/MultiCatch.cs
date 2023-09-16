using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    using System;

    class MultiCatch
    {
        static void Main(string[] args)
        {
            int n = 10;
            try
            {
                // Code that may throw exceptions
                int[] numbers = null;
                int result = n/ 0;
                string str = "Hello";
                char ch = str[10];
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Caught DivideByZeroException: {ex.Message}");
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"Caught IndexOutOfRangeException: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Caught Exception: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Finally block executed.");
            }

            Console.WriteLine("After try-catch-finally block.");
        }
    }

}
