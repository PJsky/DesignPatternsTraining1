using System;

//Can make it abstract then make other characters that are a bit different but inherit common stuff from the abstract class
//Or name this character a specific name and extract interface to invert the dependency
public class Character : ICharacter
{
    public Character(string name)
    {
        Name = name;
    }
    public string Name {get; set;}
    private int Hp = 100;
    public IWeapon Weapon { get; set; }
    public IArmor Armor { get; set; }
    public IShield Shield { get; set; }
    public void ExecuteAttack(ICharacter enemyCharacter)
    {
        UseWeapon(enemyCharacter);
    }
    public void ExecuteDefense(int incomingDamage)
    {
        System.Console.WriteLine($"{Name} tries to defend {incomingDamage} damage");
        var leftoverDamage = UseShield(incomingDamage);
        Hp -= leftoverDamage;
        Console.WriteLine($"{Name} has been hit for: {leftoverDamage}. Hp left: {Hp}");
    }

    private int UseShield(int incomingDamage)
    {
        int leftoverDamage = Shield.Defend(incomingDamage);
        System.Console.WriteLine($"Damage after shield: {leftoverDamage}");
        return leftoverDamage;
    }

    private int UseArmor(int incomingDamage)
    {
        var leftoverDamage = Armor.Defend(incomingDamage);
        System.Console.WriteLine($"Damage after armor: {leftoverDamage}");
        return leftoverDamage;
    }

    private void UseWeapon(ICharacter enemyCharacter)
    {
        Console.WriteLine($"{Name} attacks {enemyCharacter.Name}");
        Weapon.Attack(enemyCharacter);
    }

    public bool IsAlive(){
        return Hp > 0;
    }

    public void LoseHealth(int healthLost){
        Hp -= healthLost;
    }
}