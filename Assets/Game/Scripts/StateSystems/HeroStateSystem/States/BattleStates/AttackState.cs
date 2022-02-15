namespace StateMachine.HeroStateMachine
{
    public class AttackState : HeroState
    {
        Hero hero;
        Enemy enemy;

        public AttackState(Hero hero,Enemy enemy)
        {
            this.hero = hero;
            this.enemy = enemy;
        }

        public override void Enter()
        {
            enemy.ApplyDamage(hero.Stats.AttackPower);
        }
    }
}
