namespace StateMachine.HeroStateMachine
{
    public class EnemyState : IState
    {
        EnemyStateMachine enemyStateMachine;

        public EnemyState(EnemyStateMachine stateMachine)
        {
            enemyStateMachine = stateMachine;
        }

        public virtual void Enter(){}

        public virtual void Exit(){}

        public virtual void Update(){}
    }
}