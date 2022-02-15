
using TMPro;
using UnityEngine;

public class HeroStatsController : MonoBehaviour
{
    HeroStats heroStats;
    [SerializeField] GameObject statsPanel;
    [SerializeField] TMP_Text nameText;
    [SerializeField] TMP_Text levelText;
    [SerializeField] TMP_Text attackText;
    [SerializeField] TMP_Text expText;

    private void Awake()
    {
        heroStats = (HeroStats)GetComponent<Hero>()?.Stats;
    }

    public void ShowStats()
    {
        SetStats();
        statsPanel.SetActive(true);
    }

    public void HideStats()
    {
        statsPanel.SetActive(false);
    }

    void SetStats()
    {
        if (heroStats == null) return;
        nameText?.SetText(heroStats.Name);
        levelText?.SetText(heroStats.Level.ToString());
        attackText?.SetText(heroStats.AttackPower.ToString());
        expText?.SetText(heroStats.Experience.ToString());
    }
}
