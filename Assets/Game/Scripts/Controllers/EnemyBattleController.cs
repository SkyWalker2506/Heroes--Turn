using System;
using StateMachine.EnemyStateMachine;
using UnityEngine;
using UnityEngine.Events;

public class EnemyBattleController : MonoBehaviour
{
    [SerializeField] Enemy enemy;
    public Enemy Enemy => enemy;
    public UnityEvent OnEnemyDied => Enemy.Stats.OnHealthBelowZero;


    public void SetEnemyForBattle()
    {
        Enemy.EnemyStateMachine.SetState(new GettingReadyToBattleState(Enemy));
    }

    public void SetEnemyForDefending()
    {
        Enemy.EnemyStateMachine.SetState(new IdleState());
    }
}
