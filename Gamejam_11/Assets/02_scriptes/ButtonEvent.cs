using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonEvent : MonoBehaviour
{
    public void SceneLoader(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    ExitManager exitManager;
    OptionManager optionManager;
    HelpManager helpManager;

    private void Start()
    {
        exitManager = FindObjectOfType<ExitManager>();
        optionManager = FindObjectOfType<OptionManager>();
        helpManager = FindObjectOfType<HelpManager>();
    }

    public void ExitButton()
    {
        exitManager.ExitClick = true;
    }

    public void ExitYesButton()
    {
        Debug.Log("게임 종료");
        Application.Quit();
    }

    public void ExitNoButton()
    {
        exitManager.ExitClick = false;
    }


    public void OptionButton()
    {
        optionManager.click = true;
    }

    public void OptionExit()
    {
        optionManager.click = false;
    }


    public bool Language = true;

    public void Option_Language()
    {
        optionManager.Language_Change();
    }

    public bool Sound = true;

    public void Option_Sound()
    {
        optionManager.Sound_on_off();
    }


    public void HelpButton()
    {
        helpManager.HelpClick = true;
    }

    public void HelpNoButton()
    {
        helpManager.HelpClick = false;
    }
}
