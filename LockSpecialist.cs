using System;

class LockSpecialist : IRobber
{
    public string Name { get; set; }
    public int SkillLevel { get; set; }
    public int PercentageCut { get; set; }

    public string Specialty()
    {
        return this.GetType().ToString();
    }

    public LockSpecialist(string name, int skillLevel, int percentageCut)
    {
        Name = name;
        SkillLevel = skillLevel;
        PercentageCut = percentageCut;
    }

    public void PerformSkill(Bank bank, LockSpecialist lockSpecialist)
    {
        bank.SecurityGuardScore -= lockSpecialist.SkillLevel;
        Console.WriteLine($"{this.Name} is picking the lock. Decreased security by {this.SkillLevel} points.");
        if (bank.SecurityGuardScore <= 0)
        {
            Console.WriteLine($"{this.Name} has successfully picked the lock!");
        }
    }
}