namespace StateMachine.HeroStateMachine
{
    public class GettingReadyToBattleState : HeroState
    {
        Hero hero;
        public GettingReadyToBattleState(HeroStateMachine heroStateMachine)
        {
            hero = heroStateMachine.Hero;
        }

        public override void Enter()
        {
            hero.InitializeHealth();
        }
    }

}
