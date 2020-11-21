public class Mace : IWeapon
{
    private int damage  = 25;
    const int maceEffectdamage = 2;
    public void Attack(ICharacter enemyCharacter){
        enemyCharacter.LoseHealth(maceEffectdamage);
        enemyCharacter.ExecuteDefense(damage);
    }
}