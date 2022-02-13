namespace StateMachine.GameStateMachine
{
    public class GameStateMachine : StateMachineBase
    {
        public GameState CurrentGameState => (GameState)CurrentState;
    }
}