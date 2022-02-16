using System.Collections;
using UnityEngine;

namespace StateMachine.EnemyStateMachine
{
    public class ReadyToAttackState : EnemyState
    {
        Enemy enemy;
        HeroBattleController heroBattleController;

        public override void Enter()
        {
            enemy = BattleManager.EnemyBattleController.Enemy;
            heroBattleController = BattleManager.HeroBattleController;
            enemy.StartGettingReadyToAttack();
            GameManager.Instance.StartCoroutine(IEAttack());
        }

        IEnumerator IEAttack()
        {
            yield return new WaitForSecondsRealtime(2.5f);
            var target = heroBattleController.GetRandomHero();
            enemy.EnemyStateMachine.SetState(new AttackState());
        }

    }
}