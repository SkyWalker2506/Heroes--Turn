using System.Collections;
using System.Collections.Generic;

namespace StateMachine
{
    public interface IState 
    {
        void Enter();
        void Update();
        void Exit();
    }

}