

public class Axe : IWeapon
{
    public int Damage { get; set; } = 20;
    public void Attack(Character enemyCharacter)
    {
        //Axe effect
        System.Console.WriteLine($"Swing with axe for {Damage} damage");
        enemyCharacter.ExecuteDefense(Damage);
    }
}