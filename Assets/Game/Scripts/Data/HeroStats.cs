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
    public int AttackPower { get { return (int)(BaseAttackPower * Mathf.Pow(1.1f, (Level - 1))); } }
    public int BaseHealth;
    public int Health { get { return (int)(BaseHealth * Mathf.Pow(1.1f, (Level - 1))); } }
    public int CurrentHealth { get; set; }

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

    public void ResetHealth()
    {
        CurrentHealth = Health;
    }
}
