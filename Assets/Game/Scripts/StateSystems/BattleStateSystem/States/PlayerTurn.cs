namespace StateMachine.BattleStateMachine
{
    public class PlayerTurn : BattleStateBase
    {
        HeroBattleController heroBattleController;
        EnemyBattleController enemyBattleController;

        public PlayerTurn(HeroBattleController heroBattleController, EnemyBattleController enemyBattleController)
        {
            this.heroBattleController = heroBattleController;
            this.enemyBattleController = enemyBattleController;
        }

        public override void Enter()
        {
            heroBattleController.SetAliveHeroesForTurn(enemyBattleController.Enemy);
            enemyBattleController.SetEnemyForDefending();
        }

    }
}