namespace StateMachine.HeroStateMachine
{
    public class IdleState : HeroState
    {
        Hero hero;

        public IdleState(Hero hero)
        {
            this.hero = hero;
            StateMachine = hero.HeroStateMachine;
        }

        public override void OnHold()
        {
            StateMachine.PushState(new DisplayStatsState(hero));
        }
    }
}
