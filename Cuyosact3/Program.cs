using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuyosact3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            // Declare a 2D array of strings with 3 rows and 3 columns
            string[,] surname = new string[3, 3]
            {
                // Assign values to the elements of the array
                { "\tCuyos", "\tLoon",  "\tBelleza"},
                { "\tSalvo", "\tPedro", "\tYagonia" },
                { "\tSalon", "\tAtillo","\tOkay" }

            };

            // Access and print the elements of the array
            Console.WriteLine("\t\t-------LIST OF SURNAMES------- \n");     
            Console.WriteLine("\t" + "Column 1: \t" + "Column 2: \t" + "Column 3: \t");

            // Nested loops to iterate through the 2D array
            for (int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    // Print each element followed by a tab space
                    Console.Write(surname[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();





        }
    }
}
