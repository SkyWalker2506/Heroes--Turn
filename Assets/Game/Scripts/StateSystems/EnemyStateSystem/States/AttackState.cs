using StateMachine.BattleStateMachine;

namespace StateMachine.EnemyStateMachine
{
    public class AttackState : EnemyState
    {
        Enemy enemy;
        Hero target;
        
        public override void Enter()
        {
            enemy = BattleManager.EnemyBattleController.Enemy;
            target = BattleManager.HeroBattleController.GetRandomHero();
            target.ApplyDamage(enemy.Stats.AttackPower);
            if(BattleManager.HeroBattleController.HasAnyLiveHeroes)
                BattleManager.BattleStateMachine.SetState(new PlayerTurn());
            else
                BattleManager.BattleStateMachine.SetState(new PlayerLostState());

        }
    }
}