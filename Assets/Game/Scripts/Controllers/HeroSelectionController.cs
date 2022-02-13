using StateMachine.GameStateMachine;
using UnityEngine;

public class HeroSelectionController : MonoBehaviour
{
    [SerializeField] GameObject[] heros;
    static int availableHeroCount=3;

    private void Awake()
    {
        availableHeroCount = PlayerPrefs.GetInt("HeroCount", 3);
    }

    public static void UpdateHeroCount(int count)
    {
        availableHeroCount = count;
        PlayerPrefs.SetInt("HeroCount", availableHeroCount);
    }

    private void OnEnable()
    {
        HeroSelectionState.OnHeroSelectionStarted.AddListener(SetHeroSelection);
    }

    private void OnDisable()
    {
        HeroSelectionState.OnHeroSelectionStarted.RemoveListener(SetHeroSelection);
    }

    void SetHeroSelection()
    {
        for (int i = 0; i < availableHeroCount; i++)
        {
            Debug.Log(heros[i]);
            heros[i].SetActive(true);
        }
    }
}
