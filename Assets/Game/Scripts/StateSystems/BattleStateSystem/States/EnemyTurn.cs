namespace StateMachine.BattleStateMachine
{
    public class EnemyTurn : BattleStateBase
    {
        public override void Enter()
        {
            BattleManager.BattleUIController.SetTurnText("Enemy Turn");
            BattleManager.HeroBattleController.SetAliveHeroesToIdle();
            BattleManager.EnemyBattleController.SetEnemyForAttacking();
        }
    }
}