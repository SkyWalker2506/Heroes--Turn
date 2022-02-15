namespace StateMachine.HeroStateMachine
{
    public class IdleState : HeroState
    {
        BattleManager battleManager;
        public IdleState(BattleManager battleManager)
        {
            this.battleManager = battleManager;
        }
    }
}
