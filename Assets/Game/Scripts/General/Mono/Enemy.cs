using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] EnemyStats enemyStats;
    [SerializeField] HealthUI healthUI;

    public void InitializeHealth()
    {
        enemyStats.ResetHealth();
        healthUI.SetCharacterStats(enemyStats);
        healthUI.ToggleUI(true);
    }
}