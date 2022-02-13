using UnityEngine;

[CreateAssetMenu(menuName = "Scriptable Game Manager")]
public class ScriptableGameManager : ScriptableObject
{
    GameManager gameManager;

    public void SetGameManager(GameManager gameManager)
    {
        this.gameManager = gameManager;
    }

    public void OpenHeroSelection()
    {
        gameManager.OpenHeroSelection();
    }

    public void OpenBattle()
    {
        gameManager.OpenBattle();
    }
}