using System;

//Can make it abstract then make other characters that are a bit different but inherit those things
public class Character
{
    public Character(string name)
    {
        Name = name;   
    }
    public string Name {get; set;}
    public int Hp { get; set; } = 100;
    public IWeapon Weapon { get; set; }
    public IArmor Armor { get; set; }
    public IShield Shield { get; set; }
    public void ExecuteAttack(Character enemyCharacter)
    {
        Console.WriteLine($"{Name} attacks {enemyCharacter.Name}");
        Weapon.Attack(enemyCharacter);
    }
    public void ExecuteDefense(int incomingDamage)
    {
        System.Console.WriteLine($"{Name} tries to defend {incomingDamage} damage");
        var leftOverDamage = Armor.Defend(incomingDamage);
        System.Console.WriteLine($"Damage after armor: {leftOverDamage}");
        leftOverDamage = Shield.Defend(incomingDamage);
        System.Console.WriteLine($"Damage after shield: {leftOverDamage}");
        Hp -= leftOverDamage;
        Console.WriteLine($"{Name} has been hit for: {leftOverDamage}. Hp left: {Hp}");
    }


}