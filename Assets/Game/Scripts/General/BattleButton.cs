using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleButton : MonoBehaviour
{
    [SerializeField] Button battleButton;

    private void Awake()
    {
        ToggleButton();
    }

    private void OnEnable()
    {
        HeroManager.OnSelectedHeroUpdated.AddListener(ToggleButton);
    }

    private void OnDisable()
    {
        HeroManager.OnSelectedHeroUpdated.RemoveListener(ToggleButton);
    }

    void ToggleButton()
    {
        battleButton.interactable = !HeroManager.CanNewHeroBeSelected;
    }
}
