using StateMachine.HeroStateMachine;
using System;
using UnityEngine;

public class Hero : MonoBehaviour
{
    public HeroStateMachine HeroStateMachine;
    public HeroStats HeroStats;
    public HeroDisplayController DisplayController;

    private void Awake()
    {
        HeroStats.LoadData();
    }

    public void ResetHealth()
    {
        HeroStats.ResetHealth();
    }
}

