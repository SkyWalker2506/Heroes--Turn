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
            GameManager.Instance.StartCoroutine(IEAttack());
        }

        IEnumerator IEAttack()
        {
            yield return new WaitForSecondsRealtime(1f);
            enemy.StartGettingReadyToAttack();
            yield return new WaitForSecondsRealtime(2f);
            var target = heroBattleController.GetRandomHero();
            enemy.EnemyStateMachine.SetState(new AttackState());
        }

    }
}