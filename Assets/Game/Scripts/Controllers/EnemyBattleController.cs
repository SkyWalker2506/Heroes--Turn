using UnityEngine;

public class EnemyBattleController : MonoBehaviour
{
    [SerializeField] Enemy enemy;

    public void SetEnemyForBattle()
    {
        enemy.InitializeHealth();
    }

}
