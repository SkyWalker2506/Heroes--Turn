using UnityEngine.Events;

public interface ICharacterStats
{
    int Health { get; }
    int CurrentHealth { get; }
    float HealthPercentage { get; }
    int AttackPower { get; }
    UnityAction OnHealthUpdated { get; set; }
    UnityAction OnHealthBelowZero { get; set; }

}