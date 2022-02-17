using StateMachine.GameStateMachine;
using StateMachine.HeroStateMachine;
using UnityEngine;

public class HeroSelectionController : MonoBehaviour
{
    [SerializeField] Transform heroContainer;
    [SerializeField] GameObject[] heros;
    int availableHeroCount{get { return (GameManager.Instance.PlayedGameCount / 5) + 3; }}

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
            hero.HeroStateMachine.SetState(new ReadyToSelectState(hero));
        }
    }
}
