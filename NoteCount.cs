using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcept.Arrays
{
    public class NoteCount
    {
        static void Main(string[] args)
        {
            int[] notes = { 1000, 500, 200, 100, 50, 20, 10, 5, 2 };

            Console.WriteLine("Enter the Amount");
            int amount=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Number of notes is:");

            foreach(int note in notes) 
            {
                if (amount >= note)
                {
                    int n=amount/note;
                    Console.WriteLine($"for the amount {note}Rs->{n}notes required");
                    amount%=note;
              

                }
               

            }
            
        }
    }
}
