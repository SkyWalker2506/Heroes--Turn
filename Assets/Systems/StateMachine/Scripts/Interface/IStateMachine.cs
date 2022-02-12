using System.Collections.Generic;

namespace StateMachine
{
    public interface IStateMachine
    {
        Stack<IState> StateStack { get; }

        void SetState(IState state);
        void PushState(IState state);
        void PopState();
        bool Contains(IState state);
        void ExecuteStateUpdate();
    }

}
