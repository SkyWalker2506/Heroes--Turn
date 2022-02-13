using StateMachine.HeroStateMachine;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class HeroManager 
{
    public static List<string> SelectedHeroes { get; private set; } = new List<string>();
    static int maxSelectedCount = 3;
    public static bool CanNewHeroBeSelected { get { return maxSelectedCount > SelectedHeroes.Count; } }
    public static HeroStateMachine HeroThatShowsInfo;
    public static UnityEvent OnSelectedHeroUpdated = new UnityEvent();

    public static void AddHero(string hero)
    {
        if (!CanNewHeroBeSelected) return;
        SelectedHeroes.Add(hero);
        OnSelectedHeroUpdated?.Invoke();
    }

    public static void RemoveHero(string hero)
    {
        if (!SelectedHeroes.Contains(hero))return;
        SelectedHeroes.Remove(hero);
        OnSelectedHeroUpdated?.Invoke();
    }

    public static void ClearHeroList()
    {
        SelectedHeroes.Clear();
        OnSelectedHeroUpdated?.Invoke();
    }
}
