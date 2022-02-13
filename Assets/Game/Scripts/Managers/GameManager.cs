using StateMachine.GameStateMachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    GameStateMachine gameStateMachine = new GameStateMachine();
    GameState CurrentState => gameStateMachine.CurrentGameState;
    [SerializeField] ScriptableGameManager scriptableGameManager;
    [SerializeField] string heroSelectionScene;
    [SerializeField] string battleScene;

    private void Awake()
    {
        scriptableGameManager?.SetGameManager(this);
        OpenHeroSelection();
    }

    public void OpenHeroSelection()
    {
        gameStateMachine.SetState(new HeroSelectionState(heroSelectionScene));
    }

    public void OpenBattle()
    {
        gameStateMachine.SetState(new BattleState(battleScene));
    }
}
