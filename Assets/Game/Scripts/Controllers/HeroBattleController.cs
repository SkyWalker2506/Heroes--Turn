using StateMachine.HeroStateMachine;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class HeroBattleController : MonoBehaviour
{
    [SerializeField] Transform[] heroContainers;
    Hero[] heroes;
    public List<Hero> aliveHeroes { get; private set; }
    public UnityEvent OnAllHeroesDied;

    public void SetHeroes()
    {
        var count = HeroManager.SelectedHeroes.Count;
        heroes = new Hero[count];
        for (int i = 0; i < count; i++)
        {
            heroes[i] = ((GameObject)Instantiate(Resources.Load(HeroManager.SelectedHeroes[i]), heroContainers[i])).GetComponent<Hero>();
            var stateMachine = heroes[i].HeroStateMachine;
            stateMachine.SetState(new GettingReadyToBattleState(stateMachine));
        }
        aliveHeroes.AddRange(heroes);

        foreach (var hero in aliveHeroes)
        {
            hero.HeroStats.OnHealthBelowZero.AddListener(() => RemoveHero(hero));
        }
    }

    void RemoveHero(Hero hero)
    {
        aliveHeroes.Remove(hero);
        if (aliveHeroes.Count == 0)
            OnAllHeroesDied?.Invoke();
    }

    public Hero GetRandomHero()
    {
        var count = aliveHeroes.Count;
        if (count > 0)
            return aliveHeroes[Random.Range(0, count)];
        else
            return null;
    }

}