using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcept
{
    public class Book
    {
        private int Bookid, price;
        private string name, Author;

        public Book(int Bookid,int price,string name,string Author)
        {
            this.Bookid = Bookid;
            this.price = price;
            this.name = name;
            this.Author = Author;

        }
        public string show()
        {
            return $"Id={Bookid},Price={price},Name={name},Author={Author}";

        }
    }
}
