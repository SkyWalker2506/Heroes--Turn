namespace StateMachine.HeroStateMachine
{
    public class ReadyToAttackState : HeroState
    {
        Hero hero;
        BattleManager battleManager;

        public ReadyToAttackState(Hero hero, BattleManager battleManager)
        {
            this.hero = hero;
            this.battleManager = battleManager;
            StateMachine = hero.HeroStateMachine;
        }

        public override void OnTap()
        {
            StateMachine.SetState(new AttackState(hero.Stats.AttackPower, battleManager));
        }

        public override void OnHold()
        {
            StateMachine.PushState(new DisplayStatsState(hero));
        }
    }
}
