using System;
using UnityEngine;

[Serializable]
public class HeroStats
{
    public string Name;
    public int Level = 1;
    public int Experience;
    int maxExperiencePerLevel=5;
    public int BaseAttackPower;
    public int AttackPower { get { return (int)(BaseAttackPower * Mathf.Pow(1.01f, (Level - 1))); } }
    public int BaseHealth;
    public int Health { get { return (int)(BaseHealth * Mathf.Pow(1.01f, (Level - 1))); } }


    public void AddExperience(int value)
    {
        while(Experience>=maxExperiencePerLevel)
        {
            Experience %= maxExperiencePerLevel;
            Level++;
        }
    }
}
