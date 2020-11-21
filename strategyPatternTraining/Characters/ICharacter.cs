public interface ICharacter
{
    string Name { get; set; }
    IWeapon Weapon { get; set; }
    IArmor Armor { get; set; }
    IShield Shield { get; set; }

    void ExecuteAttack(ICharacter enemyCharacter);
    void ExecuteDefense(int incomingDamage);
    bool IsAlive();
    void LoseHealth(int healthLost);
}