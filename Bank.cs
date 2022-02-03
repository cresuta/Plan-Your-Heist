using System;

class Bank
{
    public int DifficultyLevel = 100;

    public int LuckValue()
    {
        Random random = new Random();
        return random.Next(-10, 10);
    }
}