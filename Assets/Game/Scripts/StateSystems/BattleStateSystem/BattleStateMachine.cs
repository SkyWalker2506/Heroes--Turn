
namespace StateMachine.BattleStateMachine
{
    public class BattleStateMachine : StateMachine
    {
        public BattleState CurrentGameState => (BattleState)CurrentState;
    }
}