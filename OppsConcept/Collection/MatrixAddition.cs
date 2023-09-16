using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcept.Collection
{
    //write c# program to create matrix of 3*3 and print sum of the matrix
    public class MatrixAddition
    {
        static void Main(string[] args)
        {
            int[, ] matrix1 = new int[3, 3] { { 1, 2, 3 }, {4,5,6 }, { 7,8,9 } };
            int[, ] matrix2 = new int[3, 3] { {6,5,4 }, { 5,7,8 }, { 8,3,4 } };
            int[, ] result = new int[3, 3];

            for( int i = 0; i < 3; i++ )
            {
                for(int j= 0; j < 3; j++ )
                {
                    result[i,j] = matrix1[i, j] + matrix2[i,j];
                    //int result1=(matrix1[i, j] + matrix2[i,j]);
                }
            }
            Console.WriteLine("Matrix 1"+ matrix1);
            DisplayMatrix(matrix1);
            Console.WriteLine("Matrix 2:" +matrix2);
            DisplayMatrix(matrix2);
            Console.WriteLine("Matrix sum:"+result );
            DisplayMatrix(result);

        }
       static void DisplayMatrix(int[,]matrix)
        {
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j=0;j< matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i,j]+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
