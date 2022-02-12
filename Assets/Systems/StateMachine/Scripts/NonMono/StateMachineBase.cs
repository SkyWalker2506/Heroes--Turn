using System.Collections.Generic;

namespace StateMachine
{
    public abstract class StateMachineBase: IStateMachine
    {
        public Stack<IState> StateStack { get; protected set; }
        public IState CurrentState => StateStack.Peek();


        public void SetState(IState newState)
        {
            if (CurrentState != null)
                CurrentState.Exit();
            StateStack.Clear();
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
            if (CurrentState != null)
                CurrentState.Update();
        }
    }

}
