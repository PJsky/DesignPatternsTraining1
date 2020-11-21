public class Sword : IWeapon
{
    private int damage = 15;
    public void Attack(ICharacter enemyCharacter){
        enemyCharacter.ExecuteDefense(damage);
        enemyCharacter.ExecuteDefense(damage);
    }
}