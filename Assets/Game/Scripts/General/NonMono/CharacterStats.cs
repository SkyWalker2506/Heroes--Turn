using UnityEngine;
using UnityEngine.Events;

public abstract class CharacterStats : ICharacterStats
{
    [SerializeField] protected int baseHealth;
    public virtual int Health => baseHealth;
    public int CurrentHealth { get; private set; }
    public float HealthPercentage => (CurrentHealth*1f)/Health;
    [SerializeField] protected int baseAttackPower;
    public virtual int AttackPower => baseAttackPower;
    public UnityAction OnHealthUpdated { get; set; }
    public UnityAction OnHealthBelowZero { get; set; }

    public void ResetHealth()
    {
        CurrentHealth = Health;
        OnHealthUpdated?.Invoke();
    }

    public void DecreaseHealth(int value)
    {
        CurrentHealth = Mathf.Max(CurrentHealth - value, 0);
        OnHealthUpdated?.Invoke();
        if (CurrentHealth == 0)
            OnHealthBelowZero?.Invoke();
    }

    public void IncreaseHealth(int value)
    {
        CurrentHealth = Mathf.Min(CurrentHealth + value, Health);
        OnHealthUpdated?.Invoke();
    }

}
