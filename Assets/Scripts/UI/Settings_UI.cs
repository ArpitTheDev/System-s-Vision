using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Settings_UI : UI_Screen
{
    public UI_Screen mainMenu;

    public UI_Screen promptScreen;

    public TMP_Dropdown dropdown;

    public void OpenMainMenu()
    {
        HideScreen();
        mainMenu.ShowScreen();
    }

    private void Start()
    {
        dropdown.onValueChanged.AddListener(OnDropdownValueChanged);
    }

    private void OnDropdownValueChanged(int index)
    {
        //Debug.Log("Selected option index: " + index);

        InputManager.strategyIndex = index;

        promptScreen.ShowScreen();
    }
}
