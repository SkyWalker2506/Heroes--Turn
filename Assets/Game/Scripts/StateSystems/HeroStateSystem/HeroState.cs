namespace StateMachine.HeroStateMachine
{
    public abstract class HeroState : IState
    {
        public HeroStateMachine StateMachine { get; }

        public HeroState (HeroStateMachine heroStateMachine)
        {
            StateMachine = heroStateMachine;
        }

        public virtual void OnTap(){}

        public virtual void OnHold(){}

        public virtual void Enter(){}

        public virtual void Exit(){}

        public virtual void Update(){}

    }

}