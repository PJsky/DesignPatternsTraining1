public class Mace : IWeapon
{
    public int Damage { get; set; } = 25;
    public void Attack(Character enemyCharacter){
        enemyCharacter.Hp -=2;
        enemyCharacter.ExecuteDefense(Damage);
    }
}