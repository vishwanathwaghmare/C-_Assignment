using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcept.Collection
{
    public class StackExample
    {
        static void Main(string[] args)
        {
            Stack s = new Stack();
            s.Push(10);
            s.Push(20);
            s.Push(30);
            s.Push(40);

            s.Pop();
            Console.WriteLine("top element is"+s.Peek());
            foreach (var item in s)
            {
                Console.WriteLine(item);
            }
                
        }
    }
}
//create  and calculate sum of even element from the array.  2 wc to create array and display odd position element from the array