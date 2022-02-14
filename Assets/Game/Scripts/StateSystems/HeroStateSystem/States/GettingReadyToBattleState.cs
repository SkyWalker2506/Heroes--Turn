namespace StateMachine.HeroStateMachine
{
    public class GettingReadyToBattleState : HeroState
    {
        Hero hero;
        public GettingReadyToBattleState(HeroStateMachine heroStateMachine) : base(heroStateMachine)
        {
            hero = heroStateMachine.Hero;
        }

        public override void Enter()
        {
            hero.HeroStats.ResetHealth();
            hero.SetHealthForBattle();
        }
    }

}
