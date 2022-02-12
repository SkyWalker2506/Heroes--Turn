namespace StateMachine.HeroStateMachine
{
    public class SelectedHeroState : HeroState
    {
        HeroDisplayManager heroDisplayManager;
        public SelectedHeroState(HeroStateMachine heroStateMachine) : base(heroStateMachine)
        {
            heroDisplayManager = heroStateMachine.Hero.DisplayManager;
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
            heroDisplayManager.ToggleSelected(true);
        }

        public override void Exit()
        {
            HeroManager.SelectedHeroes.Remove(StateMachine.Hero);
            heroDisplayManager.ToggleSelected(false);
        }
    }
}
