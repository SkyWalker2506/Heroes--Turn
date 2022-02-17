using System;
using System.Collections;
using TMPro;
using UnityEngine;

public class BattleUIController : MonoBehaviour
{
    [SerializeField] TMP_Text turnText;
    [SerializeField] GameObject winScreen;
    [SerializeField] GameObject lostScreen;


    public void SetTurnText(string value)
    {
        turnText.SetText(value);
    }

    public void ShowWinScreen()
    {
        winScreen.SetActive(true);
    }

    public void ShowLostScreen()
    {
        lostScreen.SetActive(true);
    }
}
