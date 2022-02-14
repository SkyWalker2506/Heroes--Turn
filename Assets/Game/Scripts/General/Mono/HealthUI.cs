using System;
using UnityEngine;
using UnityEngine.UI;

public class HealthUI: MonoBehaviour
{
    [SerializeField] Slider healthSlider;

    ICharacterStats characterStats;

    public void SetCharacterStats(ICharacterStats stats)
    {
        if (characterStats != null)
            characterStats.OnHealthUpdated.RemoveListener(UpdateUI);
        characterStats = stats;
        characterStats.OnHealthUpdated.AddListener(UpdateUI);
        UpdateUI();
    }

    public void ToggleUI(bool value)
    {
        gameObject.SetActive(value);
    }

    private void OnDisable()
    {
        if (characterStats != null)
            characterStats.OnHealthUpdated.RemoveListener(UpdateUI);
    }

    void UpdateUI()
    {
        if(healthSlider)
            healthSlider.value = characterStats.HealthPercentage;
    }
}