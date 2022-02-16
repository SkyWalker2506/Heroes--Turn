using StateMachine.HeroStateMachine;
using System;
using UnityEngine;

public class Hero : Character
{
    public HeroStateMachine HeroStateMachine;
    [SerializeField] HeroDisplayController heroDisplayController;
    public override DisplayController DisplayController => heroDisplayController;
    [SerializeField] HeroStats heroStats;
    public override CharacterStats Stats => heroStats;


    private void Awake()
    {
        heroStats.LoadData();
    }

}