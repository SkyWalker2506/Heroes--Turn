namespace StateMachine.HeroStateMachine
{
    public class ReadyToSelectState : HeroState
    {
        public ReadyToSelectState(HeroStateMachine heroStateMachine) : base(heroStateMachine)
        {
        }

        public override void OnTap()
        {
            if(HeroManager.CanNewHeroBeSelected)
                StateMachine.SetState(new SelectedHeroState(StateMachine));
        }

        public override void OnHold()
        {
            StateMachine.PushState(new DisplayStatsState(StateMachine));
        }
    }
}
