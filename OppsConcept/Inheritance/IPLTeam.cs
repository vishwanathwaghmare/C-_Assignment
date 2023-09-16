using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcept.Inheritance
{
    public class IPLTeam
    {
        public string TeamName { get; set; }    
        public IPLTeam(string teamName)
        {
            TeamName = teamName;
        }
        public void play()
        {
            Console.WriteLine($"{TeamName}is playing");
        }

    }
    class CSK : IPLTeam
    {
        public CSK (string teamName):base(teamName)
        {

        }
    }
    class RCB : IPLTeam
    {
        public RCB(string teamName):base(teamName) 
        { 
        }
    }

    class Teams
    {
        static void Main(string[] args)
        {
            CSK csk=new CSK("Chennai superKings");
            RCB rcb = new RCB("royal challenger banglore");
            csk.play();
            rcb.play();
        }
    }
}
