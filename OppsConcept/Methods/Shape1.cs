using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcept.Methods
{
    public class Shape1
    {
        static void Main(string[] args)
        {
            Circle c = new Circle(5);
            Console.WriteLine(c.Display());
            c.Area();
            Console.WriteLine(c.Draw("it is circle"));
            Console.WriteLine(c.Print());

            Console.WriteLine("*************************************");
            Rectangle r = new Rectangle(6, 8);
            Console.WriteLine(r.Display());
            r.Area();
            Console.WriteLine(r.Draw("it is rectangle"));
            Console.WriteLine(r.Print());

            Console.WriteLine("*************************************");

            Square s= new Square(4);
            Console.WriteLine(s.Display());
            s.Area();
            Console.WriteLine(s.Draw("It is square"));
            Console.WriteLine(s.Print());
            Console.WriteLine("*************************************");

            Triangle t = new Triangle(7, 10);
            Console.WriteLine(t.Display());
            t.Area();
            Console.WriteLine(t.Draw("it is triangle"));
            Console.WriteLine(t.Print());
            Console.WriteLine("_____________________________________");
            // User u= new User();
            // Console.WriteLine(u.Print());

            Person p= new Person();
            p.DisplayFullName();

            Person p1= new Person("Vishwanath");
            p1.DisplayFullName();

            Person p2 = new Person("suraj", "gaikwad");
            p2.DisplayFullName();
                
        }
    }
}
