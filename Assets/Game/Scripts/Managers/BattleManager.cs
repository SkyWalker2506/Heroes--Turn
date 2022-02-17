using StateMachine.BattleStateMachine;
using StateMachine.EnemyStateMachine;
using StateMachine.GameStateMachine;
using UnityEngine;

public class BattleManager : MonoBehaviour
{
    public BattleStateMachine BattleStateMachine;
    [SerializeField] HeroBattleController heroBattleController;
    public HeroBattleController HeroBattleController { get => heroBattleController; }
    [SerializeField] EnemyBattleController enemyBattleController;
    public EnemyBattleController EnemyBattleController { get => enemyBattleController; }
    [SerializeField] BattleUIController battleUIController;
    public BattleUIController BattleUIController { get => battleUIController; }

    private void Awake()
    {
        BattleStateMachine = new BattleStateMachine(this);
        EnemyBattleController.Enemy.EnemyStateMachine = new EnemyStateMachine(this);
    }

    private void OnEnable()
    {
        BattleState.OnBattleStarted?.AddListener(InitializeBattle);
        EnemyBattleController.OnEnemyDied+=SetPlayerWon;
        HeroBattleController.OnAllHeroesDied?.AddListener(SetPlayerLost);
    }

    private void OnDisable()
    {
        BattleState.OnBattleStarted?.RemoveListener(InitializeBattle);
        HeroBattleController.OnAllHeroesDied?.RemoveListener(SetPlayerLost);
        EnemyBattleController.OnEnemyDied-=SetPlayerWon;
    }

    //void InitializeBattle()=>StartCoroutine(IEInitializeBattle());
    void InitializeBattle()
    {
        BattleStateMachine.SetState(new BattleStarted());
    }

    void SetPlayerLost()
    {
        BattleStateMachine.SetState(new PlayerLostState());
    }

    void SetPlayerWon()
    {
        BattleStateMachine.SetState(new PlayerWonState());
    }

    public void HandleWinState()
    {
        heroBattleController.GiveExperienceToAliveHeroes();
        GameManager.Instance.IncreasePlayedGameCount();
        GameManager.Instance.OpenHeroSelection();
    }

    public void HandleLostState()
    {
        GameManager.Instance.IncreasePlayedGameCount();
        GameManager.Instance.OpenHeroSelection();
    }
}
