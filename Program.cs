using System;
using System.Collections.Generic;

namespace plan_your_heist
{
    class Program
    {
        static void Main(string[] args)
        {
            // Heist Member variables that will store ReadLine() user input
            string name;
            int skillLevel;
            decimal courageFactor;

            Console.WriteLine("Plan Your Heist!");

            // Create new Team() outside while loop so there is only a single team obj in memory 
            Team team = new Team();

            while (true)
            {

                // Heist Member variables will be set to the input from the user
                Console.WriteLine("Enter a teammember's name: ");
                name = Console.ReadLine();
                // If name is an empty string, break and terminate while loop
                if(String.IsNullOrWhiteSpace(name))
                {
                    break;
                }
                Console.WriteLine("Enter their skill level (positive whole number): ");
                int.TryParse(Console.ReadLine(), out skillLevel);
                Console.WriteLine("Enter their courage factor (decimal between 0.0 and 2.0): ");
                decimal.TryParse(Console.ReadLine(), out courageFactor);

                //Add each new heist member the user creates, then display the size of team and each team members info 
                team.AddMember(new HeistMember(name, skillLevel, courageFactor));
                team.DisplayNumberOfMembers();
                team.DisplayHeistTeamInformation();

            }

        }
    }

}
