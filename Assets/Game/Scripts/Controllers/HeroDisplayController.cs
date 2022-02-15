using System;
using System.Collections;
using UnityEngine;

public class DisplayController : MonoBehaviour
{
    [SerializeField] GameObject gettingDamagedImage;
    [SerializeField] HealthUI healthUI;

    protected virtual void Awake()
    {
        healthUI.ToggleUI(false);
    }

    public void SetHealthForBattle(CharacterStats stats)
    {
        healthUI.SetCharacterStats(stats);
        healthUI.ToggleUI(true);
    }

    public void ShowGettingDamaged()
    {
        StartCoroutine(IEShowGettingDamaged());
    }

    IEnumerator IEShowGettingDamaged()
    {
        for (int i = 0; i < 25; i++)
        {
            gettingDamagedImage.SetActive(true);
            yield return null;
            gettingDamagedImage.SetActive(false);
            yield return null;
        }
    }
}

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