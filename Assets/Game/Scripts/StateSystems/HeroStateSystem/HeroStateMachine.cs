using System.Collections.Generic;
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
            SetState(new DefaultHeroState(this));
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

    public class DefaultHeroState : HeroState
    {
        public DefaultHeroState(HeroStateMachine heroStateMachine) : base(heroStateMachine)
        {
        }

        public override void OnTap()
        {
            if(HeroManager.CanNewHeroSelected)
                StateMachine.SetState(new SelectedHeroState(StateMachine));
        }

        public override void OnHold()
        {
            StateMachine.PushState(new DisplayStatsState(StateMachine));
        }
    }

    public class DisplayStatsState : HeroState
    {
        HeroDisplayManager heroDisplayManager;

        public DisplayStatsState(HeroStateMachine heroStateMachine) : base(heroStateMachine)
        {
            heroDisplayManager = heroStateMachine.Hero.DisplayManager;
        }

        public override void OnTap()
        {
            StateMachine.PopState();
        }

        public override void Enter()
        {
            heroDisplayManager.DisplayStats(true);
        }

        public override void Exit()
        {
            heroDisplayManager.DisplayStats(false);
        }

    }
}

public static class HeroManager
{
    public static List<Hero> SelectedHeroes=new List<Hero>();
    static int maxSelectedCount = 3;
    public static bool CanNewHeroSelected { get { return maxSelectedCount > SelectedHeroes.Count; } }

}
