namespace StateMachine.EnemyStateMachine
{
    public class EnemyStateMachine : StateMachine
    {
        EnemyState currentEnemyState => (EnemyState)CurrentState;
    }
}