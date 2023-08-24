using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcept
{
    public class Movie
    {
        private int id,noOfTicket;
        private string name,type;
        private double price;

        public Movie(int id,int noOfTicket,string name,string type,double price)
        {
            this.id = id;
            this.noOfTicket = noOfTicket;
            this.name = name;
            this.type= type;
            this.price = price;
        }

        public string DisplayDetails()
        {
            return $"Movie Id={id} ,Number of tickets available{noOfTicket},Type={type}, Movie name{name} , Amount={price}";
        }

        public bool BookTickets(int numTickets)
        {
            if(numTickets<=noOfTicket)
            {
                noOfTicket -=numTickets;
                return true;
            }
            else
            {
                return false;
            }
        }
        public double CalculateTotalCost(int numTickets)
        {
            return price*numTickets;
        }

    }
}
