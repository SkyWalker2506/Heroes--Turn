
using UnityEngine;

namespace StateMachine.BattleStateMachine
{
    public class BattleStarted : BattleStateBase
    {
        BattleStateMachine battleStateMachine;
        HeroBattleController heroBattleController;
        EnemyBattleController enemyBattleController;

        //public BattleStarted() 
        //{
        //    battleStateMachine = BattleManager.BattleStateMachine;
        //    heroBattleController = BattleManager.HeroBattleController;
        //    enemyBattleController = BattleManager.EnemyBattleController;
        //}

        public override void Enter()
        {
            BattleManager.HeroBattleController.SetHeroes();
            BattleManager.EnemyBattleController.SetEnemyForBattle();
            if (Random.value > .5f)
                BattleManager.BattleStateMachine.SetState(new PlayerTurn());
            else
                BattleManager.BattleStateMachine.SetState(new EnemyTurn());

        }
    }
}