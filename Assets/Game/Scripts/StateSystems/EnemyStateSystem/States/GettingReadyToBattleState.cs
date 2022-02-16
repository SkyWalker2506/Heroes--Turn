namespace StateMachine.EnemyStateMachine
{
    public class GettingReadyToBattleState : EnemyState
    {
        public override void Enter()
        {
            BattleManager.EnemyBattleController.Enemy.InitializeHealth();
        }
    }
}