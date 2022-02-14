using StateMachine.GameStateMachine;
using StateMachine.HeroStateMachine;
using UnityEngine;

public class HeroSelectionController : MonoBehaviour
{
    [SerializeField] Transform heroContainer;
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
            var hero = ((GameObject)Instantiate(Resources.Load(heros[i].name),heroContainer)).GetComponent<Hero>();
            hero.name = heros[i].name;
            hero.HealthUI.ToggleUI(false);
            hero.HeroStateMachine.SetState(new ReadyToSelectState(hero.HeroStateMachine));
        }
    }
}
