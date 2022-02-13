using UnityEngine.Events;

namespace StateMachine.GameStateMachine
{
    public class BattleState : SceneLoadState
    {
        public static UnityEvent OnBattleStarted = new UnityEvent();

        public BattleState(string sceneName) : base(sceneName){}

        public override void Enter()
        {
            LoadScene();
        }
        protected override void OnSceneLoaded()
        {
            OnBattleStarted?.Invoke();
        }

        public override void Exit()
        {
            UnloadScene();
        }

    }
}