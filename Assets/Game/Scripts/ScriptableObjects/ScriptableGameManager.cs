using UnityEngine;

[CreateAssetMenu(menuName = "Scriptable Game Manager")]
public class ScriptableGameManager : ScriptableObject
{
    public void OpenHeroSelection()
    {
        GameManager.Instance.OpenHeroSelection();
    }

    public void OpenBattle()
    {
        GameManager.Instance.OpenBattle();
    }
}