using System.Collections;
using UnityEngine;

public class DisplayController : MonoBehaviour
{
    [SerializeField] GameObject gettingReadyToAttackImage;
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
            yield return new WaitForSecondsRealtime(.025f);
            gettingDamagedImage.SetActive(false);
            yield return new WaitForSecondsRealtime(.025f);
        }
    }

    public void ShowAttackingState()
    {
        StartCoroutine(IEShowGettingReadyToAttack());
    }

    IEnumerator IEShowGettingReadyToAttack()
    {
        for (int i = 0; i < 3; i++)
        {
            gettingReadyToAttackImage.SetActive(true);
            yield return new WaitForSecondsRealtime(.15f);
            gettingReadyToAttackImage.SetActive(false);
            yield return new WaitForSecondsRealtime(.15f);
        }
    }
}
