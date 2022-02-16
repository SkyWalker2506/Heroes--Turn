using UnityEngine;

public abstract class Character : MonoBehaviour
{
    public abstract CharacterStats Stats { get; }
    public abstract DisplayController DisplayController { get; }

    public void InitializeHealth()
    {
        Stats.ResetHealth();
        DisplayController.SetHealthForBattle(Stats);
    }

    public void ApplyDamage(int damage)
    {
        Stats.DecreaseHealth(damage);
        DisplayController.ShowGettingDamaged();
    }

}