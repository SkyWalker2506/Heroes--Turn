namespace StateMachine.HeroStateMachine
{
    public class ReadyToAttackState : HeroState
    {
        Hero hero;
        Enemy enemy;

        public ReadyToAttackState(Hero hero, Enemy enemy)
        {
            this.hero = hero;
            this.enemy = enemy;
        }

        public override void OnTap()
        {
            StateMachine.SetState(new AttackState(hero, enemy));
        }

        public override void OnHold()
        {
            StateMachine.PushState(new DisplayStatsState(hero));
        }
    }
}
