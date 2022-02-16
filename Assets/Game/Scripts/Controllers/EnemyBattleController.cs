using System;
using StateMachine.EnemyStateMachine;
using UnityEngine;
using UnityEngine.Events;

public class EnemyBattleController : MonoBehaviour
{
    [SerializeField] Enemy enemy;
    public Enemy Enemy => enemy;
    public UnityAction OnEnemyDied { get { return Enemy.Stats.OnHealthBelowZero; } set { Enemy.Stats.OnHealthBelowZero = value; } }

    public void SetEnemyForBattle()
    {
        Enemy.EnemyStateMachine.SetState(new GettingReadyToBattleState());
    }

    public void SetEnemyForDefending()
    {
        Enemy.EnemyStateMachine.SetState(new IdleState());
    }

    public void SetEnemyForAttacking()
    {
        Enemy.EnemyStateMachine.SetState(new ReadyToAttackState());
    }

}
