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
}