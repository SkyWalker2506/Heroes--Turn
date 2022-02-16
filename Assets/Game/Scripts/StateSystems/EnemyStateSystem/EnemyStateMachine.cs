namespace StateMachine.EnemyStateMachine
{
    public class EnemyStateMachine : StateMachine
    {
        BattleManager battleManager;
        EnemyState currentEnemyState => (EnemyState)CurrentState;

        public EnemyStateMachine(BattleManager battleManager)
        {
            this.battleManager = battleManager;
        }


        public void SetState(EnemyState newState)
        {
            newState.BattleManager = battleManager;
            base.SetState(newState);
        }
    }
}