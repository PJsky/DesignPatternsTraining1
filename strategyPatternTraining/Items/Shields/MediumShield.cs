using System;

public class MediumShield : IShield
{
    private int defence = 3;
    private double parryChancePercentage = 0.1f;
    public int Defend(int incomingDamage)
    {
        Random rnd = new Random();
        double AttackRating = (float) rnd.Next(0, 100)/100;
        if (AttackRating < parryChancePercentage) return 0;
        return incomingDamage-defence;
    }

}