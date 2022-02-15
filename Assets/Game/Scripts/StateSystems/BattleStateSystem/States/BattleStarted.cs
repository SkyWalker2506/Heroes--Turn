
using UnityEngine;

namespace StateMachine.BattleStateMachine
{
    public class BattleStarted : BattleStateBase
    {
        BattleStateMachine battleStateMachine;
        HeroBattleController heroBattleController;
        EnemyBattleController enemyBattleController;

        public BattleStarted(BattleStateMachine battleStateMachine, HeroBattleController heroBattleController, EnemyBattleController enemyBattleController)
        {
            this.battleStateMachine = battleStateMachine;
            this.heroBattleController = heroBattleController;
            this.enemyBattleController = enemyBattleController;
        }

        public override void Enter()
        {
            heroBattleController.SetHeroes();
            enemyBattleController.SetEnemyForBattle();
            if (Random.value > .5f)
                battleStateMachine.SetState(new PlayerTurn(heroBattleController, enemyBattleController));
            else
                battleStateMachine.SetState(new EnemyTurn());

        }
    }
}