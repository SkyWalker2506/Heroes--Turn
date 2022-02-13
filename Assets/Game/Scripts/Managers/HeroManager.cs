using StateMachine.HeroStateMachine;
using System.Collections.Generic;
using UnityEngine;

public class HeroManager 
{
    public static List<string> SelectedHeroes = new List<string>();
    static int maxSelectedCount = 3;
    public static bool CanNewHeroSelected { get { return maxSelectedCount > SelectedHeroes.Count; } }
    public static HeroStateMachine HeroThatShowsInfo;
}
