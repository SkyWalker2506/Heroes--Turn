namespace StateMachine.BattleStateMachine
{
    public class PlayerWonState : BattleStateBase
    {
        public override void Enter()
        {
            BattleManager.BattleUIController.ShowWinScreen();
        }
    }
}