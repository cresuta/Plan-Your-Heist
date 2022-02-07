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
            string trialRunResponse;
            int bankDifficultyLevel = 0;

            Console.WriteLine("Plan Your Heist!");
            Console.WriteLine("----------------");

            Team team = new Team();
            Bank bank = new Bank();

            Console.WriteLine("Please enter your bank difficulty level: ");
            int.TryParse(Console.ReadLine(), out bankDifficultyLevel);

            while (true)
            {
                // Heist Member variables will be set to the input from the user
                Console.WriteLine("Enter a teammember's name: ");
                name = Console.ReadLine();
                // If name is an empty string, break and terminate while loop
                if (name != "")
                {
                    Console.WriteLine("Enter their skill level (positive whole number): ");
                    int.TryParse(Console.ReadLine(), out skillLevel);
                    Console.WriteLine("Enter their courage factor (decimal between 0.0 and 2.0): ");
                    decimal.TryParse(Console.ReadLine(), out courageFactor);

                    //Add each new heist member the user creates, then display the size of team
                    team.AddMember(new HeistMember(name, skillLevel, courageFactor));
                }
                else
                {
                    Console.WriteLine("How many trial runs would you like to try?");
                    trialRunResponse = Console.ReadLine();
                    int parsedTrialRunResponse = Int32.Parse(trialRunResponse);
                    int successes = 0;
                    int failures = 0;

                    for (int i = 0; i < parsedTrialRunResponse; i++)
                    {

                        if (team.TeamSkillLevel() + bank.LuckValue() > bankDifficultyLevel)
                        {
                            successes++;
                        }
                        else
                        {
                            failures++;
                        }
                    }

                    Console.WriteLine($"Team Skill Level: {team.TeamSkillLevel()}");
                    Console.WriteLine($"Bank Difficulty Level: {bankDifficultyLevel}");
                    Console.WriteLine($"Successes: {successes}");
                    Console.WriteLine($"Failures: {failures}");
                    break;
                }

            }
        }
    }

}
