using System;

public class Buckler : IShield
{
    private double parryChancePercentage = 0.4f;
    public int Defend(int incomingDamage)
    {
        Random rnd = new Random();
        double AttackRating = (float) rnd.Next(0, 100)/100;
        if (AttackRating < parryChancePercentage) return 0;
        return incomingDamage;
    }

}