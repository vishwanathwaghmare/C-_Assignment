using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcept.Arrays
{
    public class JaggedArray
    {
        static void Main(string[] args)
        {
            int[][]jArray = new int[3][];
            jArray[0]=new int[] {1,2,3};
            jArray[1]=new int[] {2,3};
            jArray[2]=new int[] {3,4,5,6,7};

            Console.WriteLine("Jagged Array:");
            DisplayJArray(jArray);

        }
        static void DisplayJArray(int[][] jArray)
        {
            for(int i = 0; i < jArray.Length; i++)
            {
                for( int j = 0; j < jArray[i].Length; j++)
                {
                    Console.Write(jArray[i][j]+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
