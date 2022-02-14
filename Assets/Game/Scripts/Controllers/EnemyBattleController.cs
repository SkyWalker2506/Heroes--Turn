using StateMachine.EnemyStateMachine;
using UnityEngine;
using UnityEngine.Events;

public class EnemyBattleController : MonoBehaviour
{
    [SerializeField] Enemy enemy;
    public UnityEvent OnEnemyDied =>enemy.EnemyStats.OnHealthBelowZero;


    public void SetEnemyForBattle()
    {
        enemy.EnemyStateMachine.SetState(new GettingReadyToBattleState(enemy));
    }

}
