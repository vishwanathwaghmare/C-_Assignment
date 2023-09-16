using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcept.Collection
{
    public class ListGeneric
    {
        static void Main(string[] args)
        {
            int[]arr=new int []{ 1,2,3};
            List<int> list1 = new List<int>();
            //ArrayList list = new ArrayList();
            list1.Add(11);
            list1.Add(12);
            list1.Add(13);
            list1.Insert(1, 26);
            list1.AddRange(arr);


            list1.Sort();
            //list1.Reverse();
            Console.WriteLine("count total element" + list1.Count);
            Console.WriteLine("capacity" + list1.Capacity);
            foreach (var item in list1)
            {
                Console.WriteLine(item);
            }

            //Console.WriteLine(list1);

// ****************stack Example*******************
            Stack <string>s = new Stack<string>();
            s.Push("vishwanath");
            s.Push("sagar");
            s.Push("suraj");
            s.Push("payal");

            s.Pop();
            Console.WriteLine("top element is" + s.Peek());
            foreach (var item in s)
            {
                Console.WriteLine(item);
            }

// **********queue example******************
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);
            queue.Enqueue(40);

            queue.Dequeue(); // 10

            Console.WriteLine("First element in the queue" + queue.Peek());

            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

//************** Dictinory example*************
            Dictionary <int,string> dc = new Dictionary<int,string>();
            dc.Add(91, "india");
            dc.Add(40, "Austria");
            dc.Add(16, "America");
            dc.Add(76, "Brazil");

            dc.Remove(16);

            foreach (KeyValuePair<int,string> entry in dc)
            {
                Console.WriteLine($"{entry.Key},{entry.Value}");
            }

        }
       
    }
}
