using StateMachine.EnemyStateMachine;
using System;
using UnityEngine;


public class Enemy : Character
{
    public EnemyStateMachine EnemyStateMachine;
    [SerializeField] EnemyStats enemyStats;
    public override CharacterStats Stats => enemyStats;
    [SerializeField] EnemyDisplayController displayController;
    public override DisplayController DisplayController => displayController;


    public void StartGettingReadyToAttack()
    {
        displayController.ShowAttackingState();
    }

}
