using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Cuyos_Act_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            // TITLE: Sports Sorting Program
            Console.WriteLine("\t\t=====Sports Sorting Program =====\n");

            // Declare Array
            string[] sport= new string[6];
       

            // User Input
            Console.WriteLine("Enter 6 different sports:");
            for (int idx = 0; idx < sport.Length; idx++)
            {
                Console.Write($"Sport #{idx + 1}: ");
                sport[idx] = Console.ReadLine();
            }

            // Display Sports in Ascending Order
            Console.WriteLine("\nHere is the List of Sports Name\n");
            foreach(string sports in sport)
            {
                Console.WriteLine(sports);
            }
            // Ask user for sorting preference
            Console.Write("\nSort Ascending or Descending? (A/D): ");
            char choice = Convert.ToChar(Console.ReadLine().ToUpper());

            // Sort and Display based on user choice
            Array.Sort(sport);
            Console.WriteLine("\nHere are the List of Sports Name in Ascending Order ");
            for (int i = 0; i < sport.Length; i++)
                Console.WriteLine($"{i + 1}. {sport[i]}");

            Console.ReadKey();
        }
    }
}
