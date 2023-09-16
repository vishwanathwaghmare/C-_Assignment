using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcept.Arrays
{
    public class RainFall
    {
        static void Main(string[] args)
        {
            // Create an array to store rainfall data for a week 
            double[] rainfallData = new double[7];

        
            for (int day = 0; day < 7; day++)
            {
                Console.Write($"Enter rainfall for Day {day + 1}: ");
                rainfallData[day] = Convert.ToDouble(Console.ReadLine());
            }

            
            Console.WriteLine("\nRainfall Data for the Week:");
            for (int day = 0; day < 7; day++)
            {
                Console.WriteLine($"Day {day + 1}: {rainfallData[day]} mm");
            }
            double totalRainfall = 0;
            for (int i = 0; i < 7; i++)
            {
                totalRainfall += rainfallData[i];
            }
            Console.WriteLine($" total rainfall of a week : {totalRainfall}");
        }
    }
}
