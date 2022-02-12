using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroDisplayManager : MonoBehaviour
{
    [SerializeField] GameObject selectedObject;
    [SerializeField] GameObject statsPanel;

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
        statsPanel.SetActive(value);
    }
}