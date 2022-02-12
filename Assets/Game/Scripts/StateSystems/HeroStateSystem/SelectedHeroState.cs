namespace StateMachine.HeroStateMachine
{
    public class SelectedHeroState : HeroState
    {
        HeroDisplayController heroDisplayController;
        public SelectedHeroState(HeroStateMachine heroStateMachine) : base(heroStateMachine)
        {
            heroDisplayController = heroStateMachine.Hero.DisplayController;
        }

        public override void OnTap()
        {
            StateMachine.SetState(new DefaultHeroState(StateMachine));
        }

        public override void OnHold()
        {
            StateMachine.PushState(new DisplayStatsState(StateMachine));
        }

        public override void Enter()
        {
            HeroManager.SelectedHeroes.Add(StateMachine.Hero);
            heroDisplayController.ToggleSelected(true);
        }

        public override void Exit()
        {
            HeroManager.SelectedHeroes.Remove(StateMachine.Hero);
            heroDisplayController.ToggleSelected(false);
        }
    }
}
