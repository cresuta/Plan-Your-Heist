using System;
using System.Collections.Generic;

namespace plan_your_heist
{
    class Program
    {
        static void Main(string[] args)
        {

            // List of all possible operatives that we could employ for future heists
            List<IRobber> rolodex = new List<IRobber>()
            {
                new Hacker("Hank", 30, 10),
                new Hacker("Hannah", 35, 15),
                new Muscle("Mark", 30, 10),
                new Muscle("Margarette", 35, 15),
                new LockSpecialist("Logan",40, 20),
                new LockSpecialist("Lisa",45, 25)
            };



            // decimal courageFactor;
            // string trialRunResponse;
            // int bankDifficultyLevel = 0;

            // Team team = new Team();


            // Console.WriteLine("Please enter your bank difficulty level: ");
            // int.TryParse(Console.ReadLine(), out bankDifficultyLevel);

            Console.WriteLine("Plan Your Heist!");
            Console.WriteLine("----------------");

            // Print out the number of current operatives in the rolodex
            Console.WriteLine($"1) Number of current operatives in the rolodex: {rolodex.Count}");

            while (true)
            {
                // Ask user to enter 
                Console.WriteLine("Enter the name of a new crew member: ");
                string name = Console.ReadLine();

                if (name != "")
                {
                    // Console.WriteLine("Enter their skill level (positive whole number): ");
                    // int.TryParse(Console.ReadLine(), out skillLevel);
                    // Console.WriteLine("Enter their courage factor (decimal between 0.0 and 2.0): ");
                    // decimal.TryParse(Console.ReadLine(), out courageFactor);

                    // //Add each new heist member the user creates, then display the size of team
                    // team.AddMember(new HeistMember(name, skillLevel, courageFactor));

                    Console.WriteLine("2) Select a specialty from the list below. Type in 'Hacker', 'Muscle' or 'Lock Specialist': ");
                    Console.WriteLine("\tHacker (Disables alarms)");
                    Console.WriteLine("\tMuscle (Disarms guards)");
                    Console.WriteLine("\tLock Specialist (cracks vaults)");
                    string specialty = Console.ReadLine();
                    Console.WriteLine($"3) Enter the {specialty}'s skill level (between 1 and 100): ");
                    int skillLevel;
                    int.TryParse(Console.ReadLine(), out skillLevel);
                    Console.WriteLine($"4) Enter the {specialty}'s pay cut percentage (positive whole number): ");
                    int cut;
                    int.TryParse(Console.ReadLine(), out cut);

                    if (specialty == "Hacker")
                    {
                        rolodex.Add(new Hacker(name, skillLevel, cut));
                    }
                    else if (specialty == "Muscle")
                    {
                        rolodex.Add(new Muscle(name, skillLevel, cut));
                    }
                    else if (specialty == "Lock Specialists")
                    {
                        rolodex.Add(new LockSpecialist(name, skillLevel, cut));
                    }
                }
                else
                {
                    Bank bank = new Bank();
                    bank.AlarmScore = new Random().Next(0,100);
                    bank.VaultScore = new Random().Next(0,100);
                    bank.SecurityGuardScore = new Random().Next(0,100);
                    bank.CashOnHand = new Random().Next(50_000,1_000_000);
                    // printing Recon Report
                    bank.ReconReport();

                    // Console.WriteLine("How many trial runs would you like to try?");
                    // trialRunResponse = Console.ReadLine();
                    // int parsedTrialRunResponse = Int32.Parse(trialRunResponse);
                    // int successes = 0;
                    // int failures = 0;

                    // for (int i = 0; i < parsedTrialRunResponse; i++)
                    // {

                    //     if (team.TeamSkillLevel() + bank.LuckValue() > bankDifficultyLevel)
                    //     {
                    //         successes++;
                    //     }
                    //     else
                    //     {
                    //         failures++;
                    //     }
                    // }

                    // Console.WriteLine($"Team Skill Level: {team.TeamSkillLevel()}");
                    // Console.WriteLine($"Bank Difficulty Level: {bankDifficultyLevel}");
                    // Console.WriteLine($"Successes: {successes}");
                    // Console.WriteLine($"Failures: {failures}");
                    break;
                }

            }
        }
    }

}
