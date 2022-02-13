namespace StateMachine.HeroStateMachine
{
    public class ReadyToAttackState : HeroState
    {
        public ReadyToAttackState(HeroStateMachine heroStateMachine) : base(heroStateMachine)
        {
        }

        public override void OnTap()
        {
            //Attack State e gec
        }

        public override void OnHold()
        {
            StateMachine.PushState(new DisplayStatsState(StateMachine));
        }
    }
}
