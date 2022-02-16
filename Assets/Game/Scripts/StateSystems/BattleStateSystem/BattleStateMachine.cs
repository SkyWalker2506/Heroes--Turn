
namespace StateMachine.BattleStateMachine
{
    public class BattleStateMachine : StateMachine
    {
        BattleManager battleManager;
        public BattleStateBase CurrentGameState => (BattleStateBase)CurrentState;


        public BattleStateMachine(BattleManager battleManager)
        {
            this.battleManager = battleManager;
        }


        public void SetState(BattleStateBase newState)
        {
            newState.BattleManager = battleManager;
            base.SetState(newState);
        }

    }
}