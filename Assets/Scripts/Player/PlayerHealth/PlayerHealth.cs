using UnityEngine;
using System;

public class PlayerHealth : MonoBehaviour, IPlayerHealth
{
    private Action<IPlayerHealth> _onDeath; 

    private const int _startHealth = 1;
    private int _currentHealth;

    private bool _isDead;

    public void TakeDamage(IDamageDiller damageDiller)
    {
        if (damageDiller.GetDamage() <= 0)
            throw new ArgumentException("Value less than or equal to 0");

        _currentHealth -= damageDiller.GetDamage();

        if (_currentHealth <= 0)
            _isDead = true;

        _onDeath.Invoke(this);
    }

    public bool GetDeathState() => _isDead;
}