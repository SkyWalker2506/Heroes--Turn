namespace StateMachine.GameStateMachine
{
    public class GameStateMachine : StateMachine
    {
        public GameState CurrentGameState => (GameState)CurrentState;
    }
}

