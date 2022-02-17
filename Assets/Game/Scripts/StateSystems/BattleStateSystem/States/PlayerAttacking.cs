namespace StateMachine.BattleStateMachine
{
    public class PlayerAttacking : BattleStateBase
    {
        public override void Enter()
        {
            BattleManager.HeroBattleController.SetNotAttackingHeroesToIdle();
        }
    }
}