using UnityEngine.Events;

public interface ICharacterStats
{
    int Health { get; }
    int CurrentHealth { get; }
    float HealthPercentage { get; }
    int AttackPower { get; }
    UnityEvent OnHealthUpdated { get; }

}