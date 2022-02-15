namespace StateMachine.HeroStateMachine
{
    public class ReadyToSelectState : HeroState
    {
        Hero hero;
        public ReadyToSelectState(Hero hero) 
        {
            this.hero= hero;
            StateMachine = hero.HeroStateMachine;
        }

        public override void OnTap()
        {
            if(HeroManager.CanNewHeroBeSelected)
                StateMachine.SetState(new SelectedHeroState(hero));
        }

        public override void OnHold()
        {
            StateMachine.PushState(new DisplayStatsState(hero));
        }
    }
}
