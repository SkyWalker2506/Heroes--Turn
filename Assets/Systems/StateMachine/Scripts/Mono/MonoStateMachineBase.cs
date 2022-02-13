using System.Collections.Generic;
using UnityEngine;

namespace StateMachine
{
    public abstract class MonoStateMachineBase : MonoBehaviour, IStateMachine
    {
        StateMachine stateMachine = new StateMachine();

        public Stack<IState> StateStack => stateMachine.StateStack;

        public IState CurrentState => stateMachine.CurrentState;

        public void SetState(IState newState) => stateMachine.SetState(newState);

        public void PushState(IState newState) => stateMachine.PushState(newState);

        public void PopState() => stateMachine.PopState();

        public bool Contains(IState state) => stateMachine.Contains(state);

        public void ExecuteStateUpdate() => stateMachine.ExecuteStateUpdate();

        protected virtual void Update()
        {
            ExecuteStateUpdate();
        }
    }

}
