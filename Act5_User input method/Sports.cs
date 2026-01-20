using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuyos_act5
{
     class Sports
    {
        // Private Fields 
        private string TeamName { get; set; }
        private string PlayerName { get; set; }
        private string TeamID { get; set; }

        // Parameterized Constructor
        public Sports(string teamName, string name, string teamID)
        {
            TeamName = teamName;
            PlayerName = name;
            TeamID = teamID;
        }
        // Method to display information
        public virtual void DisplayInfo()
        {

            Console.WriteLine($"Team Name    : {TeamName} ");
            Console.WriteLine($"Player Name  : {PlayerName}");
            Console.WriteLine($"Team ID      : {TeamID}");
        }
    }
    // Derived Class 1
    class Basketball : Sports
    {
        // Private Field
        private double PointsScored { get; set; }

        // Parameterized Constructor
        public Basketball(string teamName, string name, string teamID, int pointsScored)
            : base(teamName, name, teamID)
        {
            PointsScored = pointsScored;
        }
        // Override DisplayInfo method
        public override void DisplayInfo()
        {
            Console.WriteLine("\n----- Basketball Player Info -----");
            base.DisplayInfo();
            Console.WriteLine($"Points Scored: {PointsScored}\n");
        }
    }
    // Derived Class 2
    class Arnis : Sports
    {
        // Private Field
        private int MatchesWon { get; set; }
        // Parameterized Constructor
        public Arnis(string teamName, string name, string teamID, int matchesWon)
            : base(teamName, name, teamID)
        {
            MatchesWon = matchesWon;
        }
        // Override DisplayInfo method
        public override void DisplayInfo()
        {
            Console.WriteLine("\n***** Arnis Player Info *****");
            base.DisplayInfo();
            Console.WriteLine($"Matches Won  : {MatchesWon}\n");
        }
    } 
}
