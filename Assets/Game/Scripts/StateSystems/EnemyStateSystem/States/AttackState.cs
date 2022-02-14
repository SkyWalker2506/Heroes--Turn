namespace StateMachine.EnemyStateMachine
{
    public class AttackState : EnemyState
    {
        Enemy enemy;
        Hero target;
        public AttackState(Enemy enemy, Hero targetHero)
        {
            this.enemy = enemy;
            target = targetHero;
        }

        public override void Enter()
        {
            target.ApplyDamage(enemy.EnemyStats.AttackPower);
        }
    }
}