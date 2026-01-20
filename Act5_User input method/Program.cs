using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuyos_act5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Louis Aian Cuyos
            // ACTIVITY 5: Customize a User-Input Method

            // Call the method to register athletes
            Sports[,] sportsArray = RegisterAthletes();

            Console.Clear();
            Console.WriteLine("\n--- FINAL REGISTERED ATHLETES LIST ---");

            // Display information of all registered athletes
            foreach (var sport in sportsArray)
            {
                sport.DisplayInfo();
                Console.WriteLine("--------------------------------");
            }
            Console.ReadKey();
        }
        // Method to register athletes
        static Sports[,] RegisterAthletes()
        {
            // Create a 2D array to hold sports objects
            Sports[,] sportsArray = new Sports[2, 3];
            Console.ForegroundColor = ConsoleColor.Yellow;

            // Input loop for athlete registration
            for (int i = 0; i < sportsArray.GetLength(0); i++)
            {
                Console.Write("\n\tChoose Sport: [1] Basketball [2] Arnis: ");
                string choice = Console.ReadLine();
                Console.WriteLine("\n\tSelection: " + (choice == "1" ? "Basketball" : "Arnis"));
                
                // Inner loop for each athlete in the sport
                for (int j = 0; j < sportsArray.GetLength(1); j++)
                {
                    // Display department options
                    Console.WriteLine("\tAvailable Department --- CCS, CBM, CN, CASP ---");
                    // Input athlete details
                    Console.Write("\tDept: "); string dept = Console.ReadLine();
                    Console.Write("\tName: "); string name = Console.ReadLine();
                    Console.Write("\tID  : "); string id = Console.ReadLine();
                    Console.Write("\tPts : "); int pts = int.Parse(Console.ReadLine());
                    
                    // Create appropriate object based on sport choice
                    if (choice == "1")
                        sportsArray[i, j] = new Basketball(dept, name, id, pts);
                    else
                        sportsArray[i, j] = new Arnis(dept, name, id, pts);

                    Console.WriteLine("\tAdded successfully.\n");
                }
            }
            return sportsArray;
        }
    }
}
