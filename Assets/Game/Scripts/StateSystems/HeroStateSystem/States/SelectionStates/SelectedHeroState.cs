namespace StateMachine.HeroStateMachine
{
    public class SelectedHeroState : HeroState
    {
        Hero hero;
        HeroDisplayController heroDisplayController;
        public SelectedHeroState(Hero hero) 
        {
            this.hero = hero;
            StateMachine = hero.HeroStateMachine;
            heroDisplayController = (HeroDisplayController)hero.DisplayController;
        }

        public override void OnTap()
        {
            StateMachine.SetState(new ReadyToSelectState(hero));
        }

        public override void OnHold()
        {
            StateMachine.PushState(new DisplayStatsState(hero));
        }

        public override void Enter()
        {
            HeroManager.AddHero(hero.name);
            heroDisplayController.ToggleSelected(true);
        }

        public override void Exit()
        {
            HeroManager.RemoveHero(hero.name);
            heroDisplayController.ToggleSelected(false);
        }
    }
}
