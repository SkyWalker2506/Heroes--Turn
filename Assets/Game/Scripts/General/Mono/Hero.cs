using StateMachine.HeroStateMachine;
using System;
using UnityEngine;

public class Hero : MonoBehaviour
{
    public HeroStateMachine HeroStateMachine;
    [SerializeField] HeroStats heroStats;
    public HeroStats HeroStats => heroStats;
    public HealthUI HealthUI;
    public HeroDisplayController DisplayController;

    private void Awake()
    {
        HeroStats.LoadData();
    }

    public void ApplyDamage(int damage)
    {
        HeroStats.DecreaseHealth(damage);
    }

    public void SetHealthForBattle()
    {
        HealthUI.SetCharacterStats(HeroStats);
        HealthUI.ToggleUI(true);
    }
}
