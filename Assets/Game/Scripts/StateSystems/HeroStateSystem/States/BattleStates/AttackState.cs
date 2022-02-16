using StateMachine.BattleStateMachine;

namespace StateMachine.HeroStateMachine
{
    public class AttackState : HeroState
    {
        int attackPower;
        BattleManager battleManager;

        public AttackState(int attackPower, BattleManager battleManager)
        {
            this.attackPower = attackPower;
            this.battleManager = battleManager;
        }

        public override void Enter()
        {
            battleManager.EnemyBattleController.Enemy.ApplyDamage(attackPower);
            battleManager.BattleStateMachine.SetState(new EnemyTurn());
        }
    }
}
