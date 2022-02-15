using StateMachine.BattleStateMachine;
using StateMachine.GameStateMachine;
using UnityEngine;

public class BattleManager : MonoBehaviour
{
    BattleStateMachine battleStateMachine = new BattleStateMachine();
    [SerializeField] HeroBattleController heroBattleController;
    [SerializeField] EnemyBattleController enemyBattleController;

    private void OnEnable()
    {
        BattleState.OnBattleStarted?.AddListener(InitializeBattle);
        enemyBattleController.OnEnemyDied?.AddListener(SetPlayerWon);
        heroBattleController.OnAllHeroesDied?.AddListener(SetPlayerLost);
    }

    private void OnDisable()
    {
        BattleState.OnBattleStarted?.RemoveListener(InitializeBattle);
        heroBattleController.OnAllHeroesDied?.RemoveListener(SetPlayerLost);
        enemyBattleController.OnEnemyDied?.RemoveListener(SetPlayerWon);
    }

    void InitializeBattle()
    {
        battleStateMachine.SetState(new BattleStarted(battleStateMachine,heroBattleController, enemyBattleController));
    }

    void SetPlayerLost()
    {
        battleStateMachine.SetState(new PlayerLostState());
    }

    void SetPlayerWon()
    {
        battleStateMachine.SetState(new PlayerWonState());
    }

}
