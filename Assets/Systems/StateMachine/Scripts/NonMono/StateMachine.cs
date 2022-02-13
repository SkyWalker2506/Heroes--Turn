using System.Collections.Generic;

namespace StateMachine
{
    public class StateMachine: IStateMachine
    {
        public Stack<IState> StateStack { get; protected set; } = new Stack<IState>();
        public IState CurrentState => StateStack.Peek();


        public void SetState(IState newState)
        {
            if (StateStack.Count > 0)
                CurrentState.Exit();
            StateStack = new Stack<IState>();
            StateStack.Push(newState);
            CurrentState.Enter();
        }

        public void PushState(IState newState)
        {
            StateStack.Push(newState);
            CurrentState.Enter();
        }

        public void PopState()
        {
            if (StateStack.Count == 0) return;
            CurrentState.Exit();
            StateStack.Pop();
        }

        public bool Contains(IState state)
        {
            return StateStack.Contains(state);
        }

        public void ExecuteStateUpdate()
        {
            if (StateStack.Count == 0) return;
            CurrentState.Update();
        }

    }

}
