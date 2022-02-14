using UnityEngine.Events;

namespace StateMachine.GameStateMachine
{
    public class HeroSelectionState : SceneLoadState
    {
        public static UnityEvent OnHeroSelectionStarted = new UnityEvent();

        public HeroSelectionState(string sceneName) : base(sceneName){}

        public override void Enter()
        {
            LoadScene();
        }

        protected override void OnSceneLoaded()
        {
            HeroManager.ClearHeroList();
            OnHeroSelectionStarted?.Invoke();
        }

        public override void Exit()
        {
            UnloadScene();
        }
    }
}