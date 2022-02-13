﻿using StateMachine.GameStateMachine;
using StateMachine.HeroStateMachine;
using UnityEngine;

public class HeroBattleController : MonoBehaviour
{
    [SerializeField] Transform[] heroContainers;
    Hero[] heros;

    private void OnEnable()
    {
        BattleState.OnBattleStarted.AddListener(SetHeroes);
    }

    private void OnDisable()
    {
        BattleState.OnBattleStarted.RemoveListener(SetHeroes);
    }

    void SetHeroes()
    {
        var count = HeroManager.SelectedHeroes.Count;
        heros = new Hero[count];
        for (int i = 0; i < count; i++)
        {
            heros[i] = ((GameObject)Instantiate(Resources.Load(HeroManager.SelectedHeroes[i]), heroContainers[i])).GetComponent<Hero>();
            var stateMachine = heros[i].HeroStateMachine;
            stateMachine.SetState(new ReadyToAttackState(stateMachine));
        }

        foreach (var hero in heros)
        {
            hero.ResetHealth();
        }
    }
}