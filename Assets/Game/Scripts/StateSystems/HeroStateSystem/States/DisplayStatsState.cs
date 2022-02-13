namespace StateMachine.HeroStateMachine
{
    public class DisplayStatsState : HeroState
    {
        HeroDisplayController heroDisplayController;

        public DisplayStatsState(HeroStateMachine heroStateMachine) : base(heroStateMachine)
        {
            heroDisplayController = heroStateMachine.Hero.DisplayController;
        }

        public override void OnTap()
        {
            StateMachine.PopState();
        }

        public override void OnHold()
        {
            StateMachine.PopState();
        }

        public override void Enter()
        {
            heroDisplayController.DisplayStats(true);
            if (HeroManager.HeroThatShowsInfo)
                HeroManager.HeroThatShowsInfo.PopState();
            HeroManager.HeroThatShowsInfo = StateMachine;
        }

        public override void Exit()
        {
            heroDisplayController.DisplayStats(false);
            HeroManager.HeroThatShowsInfo = null;
        }

    }
}
