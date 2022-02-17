using StateMachine.GameStateMachine;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public int PlayedGameCount;
    GameStateMachine gameStateMachine = new GameStateMachine();
    GameState CurrentState => gameStateMachine.CurrentGameState;
    [SerializeField] string heroSelectionScene;
    [SerializeField] string battleScene;

    private void Awake()
    {
        if (Instance) Destroy(gameObject);
        Instance = this;
        PlayedGameCount = PlayerPrefs.GetInt("PlayedGameCount", 0);
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

    public void IncreasePlayedGameCount()
    {
        PlayedGameCount++;
        PlayerPrefs.SetInt("PlayedGameCount", PlayedGameCount);
    }
}
