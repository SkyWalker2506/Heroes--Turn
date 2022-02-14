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
    public UnityEvent OnHealthUpdated => new UnityEvent();


    public void ResetHealth()
    {
        CurrentHealth = Health;
        Debug.Log(HealthPercentage);
        OnHealthUpdated?.Invoke();
    }

    public void DecreaseHealth(int value)
    {
        CurrentHealth = Mathf.Max(CurrentHealth - value, 0);
        OnHealthUpdated?.Invoke();
    }

    public void IncreaseHealth(int value)
    {
        CurrentHealth = Mathf.Min(CurrentHealth + value, Health);
        OnHealthUpdated?.Invoke();
    }

}
