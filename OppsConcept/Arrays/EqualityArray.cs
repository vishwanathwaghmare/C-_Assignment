using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace OppsConcept.Arrays
{
    public class EqualityArray

    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 12, 22, 32, 42, 52, 62 };
            int[] arr2 = new int[] { 52, 22, 62, 12, 42, 22 };


        }

       public static void CheckEquality(int[]arr1, int[] arr2)
        {
            for(int i=0; i<arr1.Length; i++)
            {
                for(int j=i+1; j<arr1.Length; j++)
                {
                    int temp;
                    temp= arr1[i];
                    arr1[i] = arr1[j];
                    arr1[j] = temp;
                }
            }
            for(int i=0;i<arr2.Length; i++)
            {
                for( int j=i+1;j<arr2.Length; j++)
                {
                    int temp;
                    temp= arr2[i];
                    arr2[i] = arr2[j];
                    arr2[j] = temp;
                }
            }
            bool flag = false;
            for(int i=0;i<=arr1.Length;i++)
            {
                for(int j=0;j<=arr2.Length;j++)
                {
                    if (arr1[i] == arr2[j])
                    {
                        flag = true;
                    }
                }
            }
            if( flag )
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("not equal");
            }
            Console.WriteLine();
       } 
        
       /* public static void Main(string[] args)
        {
            int[] arr1 = new int[] { 12, 22, 32, 42, 52, 62 };
            int[] arr2 = new int[] { 52, 22, 62, 12, 42, 22 };
            CheckEquality(arr1 , arr2);

        }*/
       
    }
}
