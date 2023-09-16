using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcept.Arrays
{
    public class ArrayIteration
    {
        static void Main(string[] args)
        {
            ArrayList myArrayList = new ArrayList();

            // Adding elements to the ArrayList
            myArrayList.Add("Apple");
            myArrayList.Add("Banana");
            myArrayList.Add("Cherry");
            myArrayList.Add("Date");
            myArrayList.Add("Grape");

            Console.WriteLine("Elements in the ArrayList:");

            // Iterating over the ArrayList using a foreach loop
            foreach (var item in myArrayList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
