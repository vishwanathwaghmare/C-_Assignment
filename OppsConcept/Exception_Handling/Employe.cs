using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    public  class Employe
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter name of employee");
            string name=Convert.ToString(Console.ReadLine());
            Console.WriteLine(name);
            try
            {
                if (string.IsNullOrEmpty(name))
                {
                    throw new Exception("name is required.....");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
