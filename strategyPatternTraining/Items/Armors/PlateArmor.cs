using System;

public class PlateArmor : IArmor
{
    private int defence = 10;
    public int Defend(int incomingDamage)
    {
        Random rnd = new Random();
        float AttackRating = (float) rnd.Next(0, 100) / 100;

        //Full hit, can' t dodge in plate
        return incomingDamage - defence;
    }
}