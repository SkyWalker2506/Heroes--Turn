using StateMachine.EnemyStateMachine;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public EnemyStateMachine EnemyStateMachine = new EnemyStateMachine();
    [SerializeField] EnemyStats enemyStats;
    public EnemyStats EnemyStats => enemyStats;
    [SerializeField] HealthUI healthUI;

    public void InitializeHealth()
    {
        enemyStats.ResetHealth();
        healthUI.SetCharacterStats(enemyStats);
        healthUI.ToggleUI(true);
    }
}