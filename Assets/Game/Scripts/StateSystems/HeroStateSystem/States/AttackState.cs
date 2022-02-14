namespace StateMachine.HeroStateMachine
{
    public class AttackState : HeroState
    {
        int attackPower;
        public AttackState(HeroStateMachine heroStateMachine) : base(heroStateMachine)
        {
            attackPower=heroStateMachine.Hero.HeroStats.AttackPower;
        }

    }
}
