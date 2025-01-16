public interface IPlayerHealth
{
    void TakeDamage(IDamageDiller damageDiller);

    bool GetDeathState();
}

public interface IPlayerDamageDiller
{
    int GetDamage();
}