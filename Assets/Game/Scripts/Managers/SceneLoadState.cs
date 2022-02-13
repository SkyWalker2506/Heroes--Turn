using UnityEngine;
using UnityEngine.SceneManagement;

namespace StateMachine.GameStateMachine
{
    public abstract class SceneLoadState : GameState
    {
        public SceneLoadState(string sceneName) : base(sceneName){}

        protected void LoadScene()
        {
            SceneManager.sceneLoaded += OnSceneLoaded;
            SceneManager.LoadSceneAsync(sceneNameToLoad, LoadSceneMode.Additive);
        }

        protected void UnloadScene()
        {
            SceneManager.sceneLoaded -= OnSceneLoaded;
            SceneManager.UnloadSceneAsync(sceneNameToLoad);
        }

        void OnSceneLoaded(Scene scene, LoadSceneMode mode)
        {
            Debug.Log(scene.name);
            if (scene.name == sceneNameToLoad)
            {
                OnSceneLoaded();
            }
        }

        protected abstract void OnSceneLoaded();

    }
}