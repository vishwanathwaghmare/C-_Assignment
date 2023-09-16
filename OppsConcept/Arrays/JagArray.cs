using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace OppsConcept.Arrays
{
    internal class JagArray
    {
        static void Main(string[] args)
        {
            int[][] jarr = new int[4][];
            
                jarr[0]=new int[4]; 
                jarr[1]=new int[3];
                jarr[2]=new int[2];
                jarr[3]=new int[1];

            for(int row=0;row<jarr.Length;row++)
            {
                for(int col = 0; col < jarr[row].Length; col++)
                {
                    jarr[row][col] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("\n");

            
        }
    }
}
