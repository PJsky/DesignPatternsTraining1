using System;

public class ScaleArmor : IArmor
{
    private int defence = 4;
    private double dodgeChancePercentage = 0.1f;
    public int Defend(int incomingDamage)
    {
        Random rnd = new Random();
        float AttackRating = (float) rnd.Next(0, 100) / 100;

        //Dodge
        if (AttackRating < dodgeChancePercentage) return 0;
        //Graze
        else if (AttackRating < dodgeChancePercentage + 0.20f) return (incomingDamage * 2 / 4) - defence;
        //Full hit
        return incomingDamage - defence;
    }
}