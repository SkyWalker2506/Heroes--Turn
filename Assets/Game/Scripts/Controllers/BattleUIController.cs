using System.Collections;
using TMPro;
using UnityEngine;

public class BattleUIController : MonoBehaviour
{
    [SerializeField] TMP_Text turnText;

    public void SetTurnText(string value)
    {
        turnText.SetText(value);
    }
}
