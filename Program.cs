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

            Team team = new Team();
            Bank bank = new Bank();
            int bankDifficultyLevel = bank.DifficultyLevel + bank.LuckValue();


            while (true)
            {

                // Heist Member variables will be set to the input from the user
                Console.WriteLine("Enter a teammember's name: ");
                name = Console.ReadLine();
                // If name is an empty string, break and terminate while loop
                if (String.IsNullOrWhiteSpace(name))
                {
                    break;
                }
                Console.WriteLine("Enter their skill level (positive whole number): ");
                int.TryParse(Console.ReadLine(), out skillLevel);
                Console.WriteLine("Enter their courage factor (decimal between 0.0 and 2.0): ");
                decimal.TryParse(Console.ReadLine(), out courageFactor);

                //Add each new heist member the user creates, then display the size of team
                team.AddMember(new HeistMember(name, skillLevel, courageFactor));

                if (team.TeamSkillLevel() >= bankDifficultyLevel)
                {
                    Console.WriteLine($"Heist Team Skill Level Total: {team.TeamSkillLevel()}");
                    Console.WriteLine($"Bank Difficulty Level: {bankDifficultyLevel}");
                    Console.WriteLine("SUCCESS! You may attempt your heist.");
                    break;
                }
                else
                {
                    Console.WriteLine($"\nHeist Team Skill Level Total: {team.TeamSkillLevel()}");
                    Console.WriteLine($"Bank Difficulty Level: {bankDifficultyLevel}");
                    Console.WriteLine("FAILURE! Please add another teammember and retry.");
                }

            }
        }
    }

}
