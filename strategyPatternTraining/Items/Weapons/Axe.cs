

public class Axe : IWeapon
{
    private int damage = 20;
    public void Attack(ICharacter enemyCharacter)
    {
        //Axe effect
        enemyCharacter.ExecuteDefense(damage);
    }
}