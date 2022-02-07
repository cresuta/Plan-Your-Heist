using System;
using System.Collections.Generic;
using System.Linq;

class Bank
{
    public int DifficultyLevel = 100;
    public int CashOnHand { get; set; }
    public int AlarmScore { get; set; }
    public int VaultScore { get; set; }
    public int SecurityGuardScore { get; set; }

    public bool IsSecure(int difficultyLevel, int cashOnHand, int alarmScore, int vaultScore, int securityGuardScore)
    {
        List<int> bankInfo = new List<int>()
        {
            difficultyLevel,cashOnHand,alarmScore,vaultScore,securityGuardScore
        };

        return bankInfo.All(info =>
        {
            if (info <= 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        });

    }
    public int LuckValue()
    {
        Random random = new Random();
        return random.Next(-10, 10);
    }

    public void ReconReport()
    {
        Dictionary<string, int> bankScores = new Dictionary<string, int>()
        {
            {"Alarm", this.AlarmScore},
            {"Vault", this.VaultScore},
            {"Security Guard", this.SecurityGuardScore}
        };

        string mostSecure = "";
        string leastSecure = "";

        foreach (var pair in bankScores)
        {
            if (pair.Value.Equals(bankScores.Values.Max()))
            {
                mostSecure = pair.Key;
            }
            else if (pair.Value.Equals(bankScores.Values.Min()))
            {
                leastSecure = pair.Key;
            }
        }
        Console.WriteLine("RECON REPORT");
        Console.WriteLine("--------------------");
        Console.WriteLine($"Most Secure: {mostSecure} \nLeast Secure: {leastSecure}");

    }
}