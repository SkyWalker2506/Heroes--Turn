namespace StateMachine.EnemyStateMachine
{
    public class GettingReadyToBattleState : EnemyState
    {
        Enemy enemy;
        public GettingReadyToBattleState(Enemy enemy) 
        {
            this.enemy = enemy;
        }

        public override void Enter()
        {
            enemy.InitializeHealth();
        }
    }
}