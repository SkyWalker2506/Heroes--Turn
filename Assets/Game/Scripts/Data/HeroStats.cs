using System;
using UnityEngine;

[Serializable]
public class HeroStats : CharacterStats
{
    public string Name;
    public int Level = 1;
    public int Experience;
    int maxExperiencePerLevel=5;
    public override int AttackPower { get { return (int)(baseAttackPower * Mathf.Pow(1.1f, (Level - 1))); } }
    public override int Health { get { return (int)(baseHealth * Mathf.Pow(1.1f, (Level - 1))); } }


    public void AddExperience(int value)
    {
        while(Experience>=maxExperiencePerLevel)
        {
            Experience %= maxExperiencePerLevel;
            Level++;
        }
        SaveData();
    }

    public void SaveData()
    {
        PlayerPrefs.SetInt(Name + "Level", Level);
        PlayerPrefs.SetInt(Name + "Exp", Experience);
    }

    public void LoadData()
    {
        Level = PlayerPrefs.GetInt(Name + "Level", 1);
        Experience = PlayerPrefs.GetInt(Name + "Exp", 0);
    }
}
