using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace OppsConcept.Methods
{
    internal class InterClass
    {
        static void Main(string[] args)
        {
            /* ICustomer c1 = new Transaction();
             Console.WriteLine(c1.Display());

             IOrders o1= new Transaction();
             Console.WriteLine(o1.Display());*/

            /*Car2 c = new Car2("toyota", 2023);
            c.DisplayInfo();
            Console.ReadLine();*/

            Person1.DisplayCount();

            Person1 p = new Person1("Vishwanath",26);
            p.Introduce();
            Person1.DisplayCount();


            Person1 p1 = new Person1("Sandesh", 27);
            p1.Introduce();
            Person1.DisplayCount();

            Person1 p2 = new Person1("Sagar", 23);
            p2.Introduce();
            Person1.DisplayCount();


        }

    }
}
