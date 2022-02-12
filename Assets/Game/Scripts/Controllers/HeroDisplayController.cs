using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroDisplayController : MonoBehaviour
{
    [SerializeField] GameObject selectedObject;
    [SerializeField] HeroStatsController statsController;

    private void Awake()
    {
        ToggleSelected(false);
        DisplayStats(false);
    }

    public void ToggleSelected(bool value)
    {
        selectedObject.SetActive(value);
    }

    public void DisplayStats(bool value)
    {
        if(value)
            statsController.ShowStats();
        else
            statsController.HideStats();
    }
}