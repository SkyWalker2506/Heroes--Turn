﻿using UnityEngine;

public class Hero : MonoBehaviour
{
    public HeroStats HeroStats;
    public HeroDisplayController DisplayController;

    private void Awake()
    {
        HeroStats.LoadData();
    }

}
