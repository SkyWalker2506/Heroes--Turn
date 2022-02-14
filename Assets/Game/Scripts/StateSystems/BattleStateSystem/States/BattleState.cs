namespace StateMachine.BattleStateMachine
{
    public abstract class BattleState : IState
    {
        BattleStateMachine battleStateMachine;

        public BattleState(BattleStateMachine stateMachine)
        {
            battleStateMachine = stateMachine;
        }

        public virtual void Enter(){}

        public virtual void Exit(){}

        public virtual void Update(){}
    }
}