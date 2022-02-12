namespace StateMachine.HeroStateMachine
{
    public class DefaultHeroState : HeroState
    {
        public DefaultHeroState(HeroStateMachine heroStateMachine) : base(heroStateMachine)
        {
        }

        public override void OnTap()
        {
            if(HeroManager.CanNewHeroSelected)
                StateMachine.SetState(new SelectedHeroState(StateMachine));
        }

        public override void OnHold()
        {
            StateMachine.PushState(new DisplayStatsState(StateMachine));
        }
    }
}
