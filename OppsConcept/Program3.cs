using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcept
{
    internal class Program3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the default balance");
            double bal=Convert.ToDouble(Console.ReadLine());
            Bank b1 = new Bank(11223, "Vishwanath", bal);
            Console.WriteLine(b1.Print());

            Console.WriteLine("_______________________");
            Console.WriteLine("Enter a credit Amount");
            double cre=Convert.ToDouble(Console.ReadLine());
            b1.Credit(cre);
           

            Console.WriteLine("Enter a debit Amount");
            double debit = Convert.ToDouble(Console.ReadLine());
            string msg = b1.Debit(debit);

            Console.WriteLine(msg);
            Console.WriteLine(b1.Print());
        }
    }
}
