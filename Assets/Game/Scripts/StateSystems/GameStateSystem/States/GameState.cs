using System;

namespace StateMachine.GameStateMachine
{

    public abstract class GameState : IState
    {
        protected string sceneNameToLoad;  

        public GameState(string sceneName)
        {
            sceneNameToLoad = sceneName;
        }
        
        public virtual void Enter(){}

        public virtual void Exit(){}

        public virtual void Update(){}
    }
}