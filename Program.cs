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

            // heistTeam will store new heist members that are created by user
            List<HeistMember> heistTeam = new List<HeistMember>(){};
            Console.WriteLine("Plan Your Heist!");
            
            // Heist Member variables will be set to the input from the user
            Console.WriteLine("Enter a teammember's name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter their skill level (positive whole number): ");
            int.TryParse(Console.ReadLine(), out skillLevel);
            Console.WriteLine("Enter their courage factor (decimal between 0.0 and 2.0): ");
            decimal.TryParse(Console.ReadLine(), out courageFactor);

            // Instantiating a new HeistMember "hm" by way of its constructor
            HeistMember hm = new HeistMember(name, skillLevel, courageFactor);

            // User input is displayed for the new HeistMember "hm" (name, skill level, and courage factor)
            Console.WriteLine("----------");
            Console.WriteLine($"{hm.Name} \n-Skill Level: {hm.SkillLevel} \n-Courage Factor: {hm.CourageFactor}");

        }
    }

    class HeistMember {
        public string Name {get; set;}
        public int SkillLevel {get; set;}
        public decimal CourageFactor {get; set;}

        public HeistMember(string name, int skillLevel, decimal courageFactor)
        {
            this.Name = name;
            this.SkillLevel = skillLevel;
            this.CourageFactor = courageFactor;
        }
    }
}
