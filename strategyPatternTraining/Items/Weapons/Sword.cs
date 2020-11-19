public class Sword : IWeapon
{
    public int Damage { get; set; } = 15;
    public void Attack(Character enemyCharacter){
        enemyCharacter.ExecuteDefense(Damage);
        enemyCharacter.ExecuteDefense(Damage);
    }
}