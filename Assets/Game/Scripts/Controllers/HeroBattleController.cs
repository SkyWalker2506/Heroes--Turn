using StateMachine.HeroStateMachine;
using UnityEngine;

public class HeroBattleController : MonoBehaviour
{
    [SerializeField] Transform[] heroContainers;
    Hero[] heros;

    public void SetHeroes()
    {
        var count = HeroManager.SelectedHeroes.Count;
        heros = new Hero[count];
        for (int i = 0; i < count; i++)
        {
            heros[i] = ((GameObject)Instantiate(Resources.Load(HeroManager.SelectedHeroes[i]), heroContainers[i])).GetComponent<Hero>();
            var stateMachine = heros[i].HeroStateMachine;
            stateMachine.SetState(new GettingReadyToBattleState(stateMachine));
        }
    }
}