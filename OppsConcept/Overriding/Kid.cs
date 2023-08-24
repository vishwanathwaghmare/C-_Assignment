using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcept.Overriding

/*WAP to create a class Kid with method readBook() and another method readBook () with 2
parameters. The method readBook here is over-loaded (same method name but different
parameters) Create a class BigKid which extends Kid created above. Implement readBook() differently in
BigKid class. Here the method readBook() has been over-ridden in the child class BigKid()*/
{
    internal class Kid
    {
        public void ReadBook()
        {
            Console.WriteLine("Kid is reading a book");
        }
        public void ReadBook(string bookTitle,int Pages)
        {
            Console.WriteLine($"kid is reading book'{bookTitle}' which has {Pages} pages.");
        }
    }
    class BigKid : Kid
    {
        public new void ReadBook()
        {
            Console.WriteLine("Big kid is reading book very carefully...");
        }
    }
}
