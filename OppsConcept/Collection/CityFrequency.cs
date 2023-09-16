using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcept.Collection
{
     public class CityFrequency
    {
        static void Main(string[] args)
        {
            List<string> cities = new List<string>
            {
                "pune","satara","solapur","mumbai","satara","solapur"
            };

            Dictionary<string, int> cityFrequency = CountCity(cities);

            foreach( var KeyValuePair in cityFrequency)
            {
                Console.WriteLine(KeyValuePair);
            }

        }

        static Dictionary<string,int>CountCity(List<string>inputList)
        {
            Dictionary<string, int> frequencyDict = new Dictionary<string, int>();
            foreach(string city in inputList)
            {
                if(frequencyDict.ContainsKey(city))
                {
                    frequencyDict[city]++;
                }
                else
                {
                    frequencyDict[city] = 1;
                }
            }
            return frequencyDict;

        }
    }
}
