using System;

public class TowerShield : IShield
{
    public int defence = 6;
    public int Defend(int incomingDamage)
    {
        return incomingDamage - defence;
    }

}