using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu_UI : UI_Screen
{
    public UI_Screen settings;
    public TMP_Dropdown dropdown;

    public void OpenSettings() 
    {
        HideScreen();
        settings.ShowScreen();
    }

    public void QuitGame()
    {
        Application.Quit();
    }
    public void LoadGame()
    {
        SceneManager.LoadScene(1);
    }

    private void Start()
    {
        dropdown.onValueChanged.AddListener(OnDropdownValueChanged);
    }

    private void OnDropdownValueChanged(int index)
    {
        //Debug.Log("Selected option index: " + index);

        InitializeGame.objectIndex = index;
    }
}
