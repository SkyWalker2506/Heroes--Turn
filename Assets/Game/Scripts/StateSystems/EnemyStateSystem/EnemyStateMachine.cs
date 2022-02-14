namespace StateMachine.HeroStateMachine
{
    public class EnemyStateMachine : StateMachine
    {
        EnemyState currentEnemyState => (EnemyState)CurrentState;
    }
}