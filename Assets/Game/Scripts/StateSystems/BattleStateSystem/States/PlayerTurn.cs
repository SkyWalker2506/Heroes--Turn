namespace StateMachine.BattleStateMachine
{
    public class PlayerTurn : BattleStateBase
    {
        HeroBattleController heroBattleController;
        EnemyBattleController enemyBattleController;
        BattleUIController battleUIController;

        public override void Enter()
        {
            heroBattleController = BattleManager.HeroBattleController;
            enemyBattleController = BattleManager.EnemyBattleController;
            battleUIController = BattleManager.BattleUIController;
            battleUIController.SetTurnText("Player Turn");
            heroBattleController.SetAliveHeroesForTurn(BattleManager);
            enemyBattleController.SetEnemyForDefending();
        }

    }
}