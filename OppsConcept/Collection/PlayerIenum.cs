using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcept.Collection
{
    public class Player
    {
        private int runs;
        private string name;
        public Player(int runs, string name)
        {
            this.runs = runs;
            this.name = name;
        }
        public override string ToString()
        {
            return $"{runs} -> {name}";
        }
    }

    public class Team : IEnumerable
    {
        private Player[] players;
        public Team()
        {
            players = new Player[3]
            {
                new Player(5000,"Sachin"),
                new Player(4000,"Virat"),
                new Player(3000,"Rohit")
            };

        }
        public IEnumerator GetEnumerator()
        {
            return players.GetEnumerator();
        }
    }


    public class IEnumerableEx
    {
        static void Main(string[] args)
        {
            Team team = new Team();

            foreach (Player item in team)
            {
                Console.WriteLine(item);
            }
        }
    }

}
