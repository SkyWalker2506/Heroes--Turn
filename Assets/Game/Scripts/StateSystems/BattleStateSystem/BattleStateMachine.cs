
namespace StateMachine.BattleStateMachine
{
    public class BattleStateMachine : StateMachine
    {
        public BattleStateBase CurrentGameState => (BattleStateBase)CurrentState;
    }
}