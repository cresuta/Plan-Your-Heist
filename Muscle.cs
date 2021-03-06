using System;

class Muscle : IRobber
{
    public string Name { get; set; }
    public int SkillLevel { get; set; }
    public int PercentageCut { get; set; }

    public string Specialty()
    {
        return this.GetType().ToString();
    }

    public Muscle(string name, int skillLevel, int percentageCut)
    {
        Name = name;
        SkillLevel = skillLevel;
        PercentageCut = percentageCut;
    }

    public void PerformSkill(Bank bank, Muscle muscle)
    {
        bank.SecurityGuardScore -= muscle.SkillLevel;
        Console.WriteLine($"{this.Name} is handling the security guards. Decreased security by {this.SkillLevel} points.");
        if (bank.SecurityGuardScore <= 0)
        {
            Console.WriteLine($"{this.Name} has disabled the security guards!");
        }
    }
}