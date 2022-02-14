namespace StateMachine.HeroStateMachine
{
    public class ReadyToAttackState : HeroState
    {
        public ReadyToAttackState(HeroStateMachine heroStateMachine) : base(heroStateMachine)
        {
        }

        public override void OnTap()
        {
            StateMachine.SetState(new AttackState(StateMachine));
        }

        public override void OnHold()
        {
            StateMachine.PushState(new DisplayStatsState(StateMachine));
        }
    }
}
