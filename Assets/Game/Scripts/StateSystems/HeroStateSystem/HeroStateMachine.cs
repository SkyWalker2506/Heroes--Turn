using UnityEngine;

namespace StateMachine.HeroStateMachine
{
    public class HeroStateMachine : MonoStateMachineBase
    {
        public Hero Hero;
        HeroState currentHeroState=>(HeroState)CurrentState;

        [SerializeField] float holdTime = 3;
        float pressedTime;

        private void Start()
        {
            Hero = GetComponent<Hero>();
        }

        public void OnPressed()
        {
            Invoke(nameof(OnHold), holdTime);
            pressedTime = Time.time;
        }

        void OnHold()
        {
            currentHeroState.OnHold();
        }

        public void OnReleased()
        {
            if(Time.time- pressedTime<holdTime)
            {
                CancelInvoke(nameof(OnHold));
                currentHeroState.OnTap();
            }
        }
    }
}