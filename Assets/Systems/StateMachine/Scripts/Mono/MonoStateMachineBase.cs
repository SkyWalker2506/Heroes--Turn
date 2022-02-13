using System.Collections.Generic;
using UnityEngine;

namespace StateMachine
{
    public abstract class MonoStateMachineBase : MonoBehaviour, IStateMachine
    {
        public Stack<IState> StateStack { get; protected set; }
        public IState CurrentState => StateStack.Peek();

        private void Awake()
        {
            StateStack = new Stack<IState>();
        }

        protected virtual void Update()
        {
            ExecuteStateUpdate();
        }

        public void SetState(IState newState)
        {
            if (StateStack?.Count >0)
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
