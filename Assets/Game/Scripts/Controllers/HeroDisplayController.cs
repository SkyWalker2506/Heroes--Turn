using System;
using UnityEngine;

public class HeroDisplayController : DisplayController
{
    [SerializeField] GameObject selectedObject;
    [SerializeField] HeroStatsController statsController;

    protected override void Awake()
    {
        base.Awake();
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