using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcept.Collection
{
    public class ArrList
    {
        static void Main(string[] args)
        {
            int[]arr=new int[] {67,45,12,78 };
            ArrayList list = new ArrayList();
            list.Add(11);
            list.Add(12);
            list.Add(13);

            //list.Insert(1, 1.5);
            list.AddRange(arr);
            //list.Remove(0);
            //list.RemoveRange(2, 3);

            list.Sort();
            list.Reverse();
            Console.WriteLine("count total element"+list.Count);
            Console.WriteLine("capacity"+list.Capacity);
            foreach(var item in list)
            {
                Console.WriteLine(item);
            }
           
        }
    }
}
