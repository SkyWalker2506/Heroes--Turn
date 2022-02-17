namespace StateMachine.BattleStateMachine
{
    public class PlayerLostState : BattleStateBase
    {
        public override void Enter()
        {
            BattleManager.BattleUIController.ShowLostScreen();
        }
    }
}