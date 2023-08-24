using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcept
{
    public class MovieMainMethod
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your ticket choise:");
            string ctype = Convert.ToString(Console.ReadLine());

            Movie m = new Movie(1, 500, ctype, "DDLJ", 100);
            Console.WriteLine(m.DisplayDetails());
            Console.WriteLine("enter the number of ticket book:");
            int numtick = Convert.ToInt32(Console.ReadLine());


            if (m.BookTickets(numtick))
            {
                double total = m.CalculateTotalCost(numtick);
                Console.WriteLine("ticket book successfully......");
            }
            else
            {
                Console.WriteLine("ticket not available");

            }
        }
    }
}
