using StateMachine.GameStateMachine;
using UnityEngine;

public class BattleManager : MonoBehaviour
{
    [SerializeField] HeroBattleController heroBattleController;
    [SerializeField] EnemyBattleController enemyBattleController;

    private void OnEnable()
    {
        BattleState.OnBattleStarted.AddListener(InitializeBattle);
    }

    private void OnDisable()
    {
        BattleState.OnBattleStarted.RemoveListener(InitializeBattle);
    }

    void InitializeBattle()
    {
        heroBattleController.SetHeroes();
        enemyBattleController.SetEnemyForBattle();
    }

}
