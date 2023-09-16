using OppsConcept.Arrays;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcept.Collection
{
    public class DuplicateRemove
    {
        static void Main(string[] args)
        {
            List<string> cities = new List<string>
            { 
                "pune","satara","solapur","mumbai","satara","solapur"
            };
            List<string> uniqueCities = RemoveDuplicate(cities);

            foreach (string city in cities)
            {
                Console.WriteLine(city);

            }
            Console.WriteLine("unique city");
            foreach(string city in uniqueCities)
            {
                Console.WriteLine(city);
            }
        }

        static List<string>RemoveDuplicate(List<string>inputList) 
        {
            List<string>uniqueList=new List<string>();

            for(int i=0;i<inputList.Count;i++)
            {
                bool isDuplicate = false;

                for(int j=0;j<i;j++)
                {
                    if (inputList[i].Equals(inputList[j]))
                    {
                        isDuplicate = true;
                        break;
                    }

                }

                if(! isDuplicate)
                {
                    uniqueList.Add(inputList[i]);
                }
            }

            return uniqueList;
        }




    }
}
