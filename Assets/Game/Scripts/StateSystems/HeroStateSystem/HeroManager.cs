using StateMachine.HeroStateMachine;
using System.Collections.Generic;

public static class HeroManager
{
    public static List<Hero> SelectedHeroes=new List<Hero>();
    static int maxSelectedCount = 3;
    public static bool CanNewHeroSelected { get { return maxSelectedCount > SelectedHeroes.Count; } }
    public static HeroStateMachine HeroThatShowsInfo;
}
