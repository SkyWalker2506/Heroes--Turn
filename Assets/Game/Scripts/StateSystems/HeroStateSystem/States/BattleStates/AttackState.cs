using StateMachine.BattleStateMachine;
using System.Collections;
using UnityEngine;

namespace StateMachine.HeroStateMachine
{
    public class AttackState : HeroState
    {
        Hero hero;
        Enemy enemy;
        BattleManager battleManager;
        int attackPower;

        public AttackState(Hero hero, BattleManager battleManager)
        {
            this.hero = hero;
            enemy = battleManager.EnemyBattleController.Enemy;
            attackPower = hero.Stats.AttackPower;
            this.battleManager = battleManager;

        }

        public override void Enter()
        {
            battleManager.BattleStateMachine.SetState(new PlayerAttacking());
            GameManager.Instance.StartCoroutine(IEAttack());
        }

        IEnumerator IEAttack()
        {
            var heroTransform = hero.transform;
            var heroStartPosition = heroTransform.position;
            var enemyPosition = enemy.transform.position;

            float step = 0;

            while (step<1)
            {
                heroTransform.position = Vector3.Lerp(heroStartPosition, enemyPosition, step);
                yield return null;
                step += Time.deltaTime;
            }
            enemy.ApplyDamage(attackPower);

            step = 0;
            while (step < 1)
            {
                heroTransform.position = Vector3.Lerp(enemyPosition, heroStartPosition, step);
                yield return null;
                step += Time.deltaTime;
            }

            if (enemy.Stats.CurrentHealth>0)
                battleManager.BattleStateMachine.SetState(new EnemyTurn());
            else
                battleManager.BattleStateMachine.SetState(new PlayerWonState());

        }
    }
}
