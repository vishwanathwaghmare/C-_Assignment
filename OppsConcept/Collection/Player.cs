using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OppsConcept.Collection
{
    class Player : IComparable<Player>
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Runs { get; set; }
   

    public Player(int id,string name, int runs)
    {
            ID = id;
            Name = name;
            Runs = runs;
      
    }

    // Implement the CompareTo method from IComparable interface
    public int CompareTo(Player other)
    {
        // Compare players based on runs
        return other.Runs.CompareTo(this.Runs);
    }
}

class Players1
{
    static void Main(string[] args)
    {
        List<Player> players = new List<Player>();

        // Create player objects and add them to the list
        players.Add(new Player(101,"Virat", 3000));
        players.Add(new Player(102,"Sachin", 2500));
        players.Add(new Player(103,"Dhoni", 4000));

        // Sort the players based on runs using IComparable
        players.Sort();

        // Display player with the most runs
        Console.WriteLine("Player with the most runs:");
        Console.WriteLine($"Name: {players[0].Name}");
        Console.WriteLine($"Runs: {players[0].Runs}");
    }
}
}
