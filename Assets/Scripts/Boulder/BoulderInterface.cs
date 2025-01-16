public interface IDamageDiller
{
    int GetDamage();
}

public interface IBoulderHealth
{
    void TakaDamage(IPlayerDamageDiller damageDiller);
}